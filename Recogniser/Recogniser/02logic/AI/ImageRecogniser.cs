using Recogniser._02logic;
using System;

namespace Recogniser
{
    public static class ImageRecogniser
    {
        private static NeuralNetwork neural;
        private static double totalTrained = 0;
        private static int status = 0;
        private static double[] layers = { };

        public static double GetTotalTrained() { return totalTrained; }

        public static int GetStatus() { return status; }

        public static void ResetWeights(){ neural.GenerateWeights(); }

        public static void ResetBasis(){ neural.GenerateBasis(); }

        public static Boolean HasNeural() { return neural != null; }

        public static int CreateNeural(int[] layers, double LearningRate)
        {
            totalTrained = 0;
            status = 0;

            try
            {
                neural = new NeuralNetwork(layers, LearningRate);

                status = 1;
                return 0;
            }catch(Exception e) {

                neural = null;
                return - 1; 
            }
        }

        public static int Train(double count)
        {
            status = 2;
            ProgressLog l = new("Training neural network...", count);

            try
            {
                double[][,] data = MnistReader.GetDataToTrain(1000);

                double[,] inputs = data[1];
                double[,] outputs = data[0];

                for (int i = 0; i < count; i++)
                {
                    neural.Teach(outputs, neural.Think(inputs));
                    l.Reload(i, String.Format("Training neural network... {0}/{1}", i+1, count));
                    totalTrained += 1;
                }

                l.Finish("Trained");
                status = 3;
                return 0;
            }catch(Exception e)
            {
                l.Finish("Error training Neural Network");
                Logger.NewLine(e.ToString());
                status = -1;

                return -1;
            }
        }

        public static void PrintWinner(double[,] outputs) {
            double highest = 0;
            double position = 0;
            for (int i = 0; i < outputs.GetLength(0); i++)
            {
                for (int j = 0; j < outputs.GetLength(1); j++)
                {
                    if (outputs[i, j] > highest) { 
                        position = j;
                        highest = outputs[i, j];
                    }
                }
                Logger.NewLine("Answer: "+position);
            }
        }

        public static int RecogniseBitmap(Bitmap b)
        {
            double[,] data = new double[1, 28*28];

            for (int i = 0; i < 28; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    data[0, i*28+j] = Extensions.RgbToGray(b.GetPixel(i, j))/255;
                }
            }
            return Think(data);
        }

        public static int Think(double[,] inputs)
        {
            status = 4;
            try
            {
                double[,] output = neural.Think(inputs);
                PrintWinner(output);
                status = 2;
            }
            catch (Exception e)
            {
                Logger.NewLine(e.ToString());
                status = -1;
                return -1;
            }
            return 0;
        }

        public static int Test() {
            status = 5;
            try
            {
                double[][,] data = MnistReader.GetDataToTrain(1);

                double[,] inputs = data[1];

                double[,] output = neural.Think(inputs);
                PrintWinner(output);
            }
            catch (Exception e) {
                Logger.NewLine(e.ToString());
                status = -1;
                return -1;
            }
            return 0;
        }
    }

}