using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    public static class MnistReader
    {
        private const string TrainImages = "C:\\Users\\juani\\source\\repos\\NumberRecogniserC-\\Recogniser\\Recogniser\\MnistDatabase\\/train-images.idx3-ubyte";
        private const string TrainLabels = "C:\\Users\\juani\\source\\repos\\NumberRecogniserC-\\Recogniser\\Recogniser\\MnistDatabase\\/train-labels.idx1-ubyte";
        private const string TestImages = "C:\\Users\\juani\\source\\repos\\NumberRecogniserC-\\Recogniser\\Recogniser\\MnistDatabase\\/t10k-images.idx3-ubyte";
        private const string TestLabels = "C:\\Users\\juani\\source\\repos\\NumberRecogniserC-\\Recogniser\\Recogniser\\MnistDatabase\\/t10k-labels.idx1-ubyte";

        public static IEnumerable<Image> ReadTrainingData()
        {
            foreach (var item in Read(TrainImages, TrainLabels))
            {
                yield return item;
            }
        }

        public static IEnumerable<Image> ReadTestData()
        {
            foreach (var item in Read(TestImages, TestLabels))
            {
                yield return item;
            }
        }

        private static IEnumerable<Image> Read(string imagesPath, string labelsPath)
        {
            using (FileStream f1 = new FileStream(labelsPath, FileMode.Open))
            {
                using (FileStream f2 = new FileStream(imagesPath, FileMode.Open)) {
                    BinaryReader labels = new BinaryReader(f1);
                    BinaryReader images = new BinaryReader(f2);

                    int magicNumber = images.ReadBigInt32();
                    int numberOfImages = images.ReadBigInt32();
                    int width = images.ReadBigInt32();
                    int height = images.ReadBigInt32();

                    int magicLabel = labels.ReadBigInt32();
                    int numberOfLabels = labels.ReadBigInt32();

                    for (int i = 0; i < numberOfImages; i++)
                    {
                        var bytes = images.ReadBytes(width * height);
                        var arr = new byte[height, width];

                        arr.ForEach((j, k) => arr[j, k] = bytes[j * height + k]);

                        yield return new Image()
                        {
                            Data = arr,
                            Label = labels.ReadByte()
                        };
                    }
                    labels.Close();
                    images.Close();
                }
            }
        }

        public static double[][,] GetDataToTrain(int count) {
            double[,] normaliced = new double[count, 28 * 28];
            double[,] outputs = new double[count, 10];
            int i = 0;
            foreach (Image b in ReadTrainingData())
            {
                if (i == count) break;
                for (int ii = 0; ii < 10; ii++)
                {
                    outputs[i, ii] = 0;
                }
                outputs[i, b.Label] = 1;
                for (int j = 0; j < 28; j++)
                {
                    for (int k = 0; k < 28; k++)
                    {
                        normaliced[i, 28 * j + k] = b.Data[j, k];
                    }
                }
                i++;
            }

            return new double[][,] { outputs, normaliced};
        }
    }
}
