using Recogniser._02logic;
using Recogniser._03database;
using System;
using System.CodeDom;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Recogniser
{
    public static class ImageRecogniser
    {
        private static NeuralNetwork neural;
        private static double totalTrained = 0;
        private static int status = 0;
        private static double[] layers = { };
        public static int printMode = 0;

        public static int imgSize = 9 * 9;

        public static double GetTotalTrained() { return totalTrained; }
        public static int GetStatus() { return status; }
        public static void ResetWeights() { neural.GenerateWeights(); }
        public static void ResetBasis() { neural.GenerateBasis(); }
        public static Boolean HasNeural() { return neural != null; }


        public static void SetPrintMode(int mode)
        {
            printMode = mode;
        }

        public static void ChangeLearningRate(double ir)
        {
            neural.setLearningRate(ir);
        }

        public static int LoadData() {
            if (!HasNeural()) return -1;

            try
            {
                double[][,] basis = new double[neural.NLayers][,];
                double[][,] weights = new double[neural.NLayers][,];
                String name = string.Join(",", neural.Layers);
                int last = neural.Layers[0];
                for (int i = 0; i < neural.NCompuLayers; i++)
                {
                    basis[i] = NeuralSaver.Read(name + "Basis"+i, 1, neural.Layers[i + 1]);
                    weights[i] = NeuralSaver.Read(name + "Weights"+i, last, neural.Layers[i + 1]);
                    last = neural.Layers[i + 1];
                }
                neural.LoadBasis(basis);
                neural.LoadWeights(weights);

                return 1;
            }
            catch (Exception e){
                Logger.NewLine(e.ToString());
                return -1;
            }
        }

        public static int SaveData()
        {
            if (!HasNeural()) return -1;

            try
            {
                double[,] basis;
                for (int i = 0; i < neural.NLayers; i++)
                {
                    basis = new double[1, neural.Layers[i + 1]];

                    for (int j = 0; j < neural.LayersBasis[i].Length; j++)
                    {
                        basis[0, j] = neural.LayersBasis[i][j];
                    }

                    String name = string.Join(",", neural.Layers);
                    NeuralSaver.Write(name + "Basis" + i, basis);
                    NeuralSaver.Write(name + "Weights" + i, neural.LayersWeights[i]);
                }

                return 1;
            }
            catch
            {
                return -1;
            }

        }

        public static int CreateNeural(int[] layers, double LearningRate)
        {
            totalTrained = 0;
            status = 0;

            try
            {
                neural = new NeuralNetwork(layers, LearningRate);

                status = 1;
                return 0;
            }
            catch (Exception e)
            {

                neural = null;
                return -1;
            }
        }

        public static double[][,] getDataToTrain(int count)
        {
            double[,] inputs = new double[count, imgSize];
            double[,] outputs = new double[count, 10];

            double[] fileData;
            for (int i = 0; i < count; i++)
            {
                for (int ii = 0; ii < 10; ii++)
                {
                    outputs[i, ii] = 0;
                }
                outputs[i, i % 10] = 1;

                fileData = ImageManager.Load("Numbers/" + i + ".png").ToArray();
                for (int j = 0; j < imgSize; j++)
                {
                    inputs[i, j] = fileData[j];
                }

            }
            return new double[][,] { outputs, inputs };
        }

        public static int Train(double count)
        {
            status = 2;
            ProgressLog l = new("[NEURAL] Training neural network...", count);

            try
            {
                double[][,] data = getDataToTrain(30);

                double[,] inputs = data[1];
                double[,] outputs = data[0];

                double[,] actualOutputs;

                for (int i = 0; i < count; i++)
                {
                    actualOutputs = neural.Think(inputs);
                    //PrintAswer(actualOutputs);

                    neural.Teach(outputs, actualOutputs);
                    l.Reload(i, String.Format("[NEURAL] Training neural network... {0}/{1}", i + 1, count));
                    totalTrained += 1;
                }

                l.Finish("[NEURAL] Trained");
                status = 3;
                return 0;
            }
            catch (Exception e)
            {
                l.Finish("[NEURAL] Error training Neural Network");
                Logger.NewLine(e.ToString());
                status = -1;

                return -1;
            }
        }


        public static void PrintOutput(double[,] outputs)
        {
            if (printMode == 0) { PrintWinner(outputs); }
            if (printMode == 1) { PrintAll(outputs); }
        }

        public static void PrintAll(double[,] outputs)
        {
            Log l;
            string vals;
            for (int i = 0; i < outputs.GetLength(0); i++)
            {

                vals = "";
                for (int j = 0; j < outputs.GetLength(1); j++)
                {
                    vals += " " + ((int)(outputs[i, j] * 100)) + "%";
                }
                l = new("Answer[" + i + "]:" + vals);
            }
        }

        public static void PrintWinner(double[,] outputs)
        {
            double highest = 0;
            double position = 0;
            for (int i = 0; i < outputs.GetLength(0); i++)
            {
                for (int j = 0; j < outputs.GetLength(1); j++)
                {
                    if (outputs[i, j] > highest)
                    {
                        position = j;
                        highest = outputs[i, j];
                    }
                }
                Logger.NewLine("[NEURAL] Answer: " + position);
            }
        }

        public static int RecogniseFile(String file)
        {
            try
            {

                double[,] prueba = new double[1, imgSize];
                double[] fileData = ImageManager.Load(file).ToArray();
                for (int i = 0; i < imgSize; i++)
                {
                    prueba[0, i] = fileData[i];
                }

                //Extensions.PrintMatrix(inputs);
                double[,] output = neural.Think(prueba);
                PrintOutput(output);
                return 0;
            }
            catch
            {
                return -1;
            }
        }

        public static int Think(double[,] img)
        {
            status = 3;
            try
            {
                //Extensions.PrintMatrix(inputs);
                double[,] output = neural.Think(img);
                PrintOutput(output);
                status = 3;
            }
            catch (Exception e)
            {
                Logger.NewLine(e.ToString());
                status = -1;
                return -1;
            }
            return 0;
        }
    }

}