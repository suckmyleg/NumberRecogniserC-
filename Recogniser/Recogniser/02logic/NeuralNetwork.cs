using Recogniser._02logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    class NeuralNetwork
    {
        private Random RandomO;

        /* Layers[n] = values = MatrixLines
         * Layers.Count = HiddenLayers
         * Layers[n] = MatrixColumns
         */

        public NeuralNetwork(int[] layers, double learningRate)
        {
            Layers = layers;
            NLayers = layers.Count();
            NCompuLayers = NLayers - 1;
            LearningRate = learningRate;
            Init();
        }
        public double LearningRate { get; private set; }
        public double[][,] LayersWeights { get; private set; }
        public double[][] LayersBasis { get; private set; }
        public int[] Layers { get; private set; }
        public int NLayers { get; private set; }
        public int NCompuLayers { get; private set; }

        //Storage results by every single layer
        private double[][,] OutputLayers { get; set; }

        /// <summary>
        /// Initialize the ramdom object and the matrix of ramdon weights
        /// </summary>
        private void Init()
        {
            Logger.NewLine(String.Format("Generating synapses"));
            // make sure that for every instance of the neural network we are geting the same radom values
            RandomO = new Random(1);
            GenerateLayers();
            Logger.NewLine(String.Format("Done"));
        }

        /// <summary>
        /// Generate our matrix with the weight of the synapses
        /// </summary>
        private void GenerateLayers()
        {
            LayersWeights = new double[NCompuLayers][,];
            LayersBasis = new double[NCompuLayers][];

            for (int h = 0; h < NCompuLayers; h++)
            {
                LayersWeights[h] = new double[Layers[h], Layers[h + 1]];
                LayersBasis[h] = new double[Layers[h + 1]];
                for (var i = 0; i < Layers[h]; i++)
                {
                    for (var j = 0; j < Layers[h + 1]; j++)
                    {
                        LayersWeights[h][i, j] = (2 * RandomO.NextDouble()) - 1;
                    }
                }
                for (var i = 0; i < Layers[h + 1]; i++)
                {
                    LayersBasis[h][i] = (2 * RandomO.NextDouble()) - 1;
                }
            }
        }

        /// <summary>
        /// Calculate the sigmoid of a value
        /// </summary>
        /// <returns></returns>
        private double[,] _CalculateSigmoid(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    var value = matrix[i, j];
                    matrix[i, j] = 1 / (1 + Math.Exp(value * -1));
                }
            }
            return matrix;
        }

        /// <summary>
        /// Calculate the sigmoid derivative of a value
        /// </summary>
        /// <returns></returns>
        private double[,] _CalculateSigmoidDerivative(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    var value = matrix[i, j];
                    matrix[i, j] = value * (1 - value);
                }
            }
            return matrix;
        }

        /// <summary> 
        /// Will return the outputs give the set of the inputs
        /// </summary>
        public double[,] Think(double[,] inputMatrix)
        {
            OutputLayers = new double[NLayers][,];
            OutputLayers[0] = inputMatrix;
            for (int h = 0; h < NCompuLayers; h++)
            {
                inputMatrix = _CalculateSigmoid(MatrixSum(MatrixDotProduct(inputMatrix, LayersWeights[h]), LayersBasis[h]));
                OutputLayers[h + 1] = inputMatrix;
            }
            return inputMatrix;
        }

        /// <summary>
        /// Train the neural network to achieve the output matrix values
        /// </summary>
        public void Train(double[,] trainInputMatrix, double[,] trainOutputMatrix, double interactions)
        {
            ProgressLog l = new ProgressLog(String.Format("Training {0}/{1}", 0, interactions), interactions);

            for (var i = 0; i < interactions; i++)
            {
                Teach(trainOutputMatrix, Think(trainInputMatrix));
                l.Reload(i, String.Format("Training {0}/{1}", i, interactions));
            }

            l.Reload(interactions, String.Format("Training {0}/{1}", interactions, interactions));
            Logger.NewLine(String.Format("Done training"));
        }

        public void Teach(double[,] expected, double[,] output)
        {
            var errors = MatrixSubstract(output, expected);

            double[,] WeightsDiff;
            double[] BasisDiff;

            /*We start since the last ComputLayer:: CompuLayers : Ex: [Hidden, Hidden, Output] NComputLayers = 3, ser start since the 2 to 1
            * Range = OutPutLayerLength
            **/
            //Console.WriteLine("Adjusting weights from layer {0}-{1}", NCompuLayers, 0);
            for (int h = NCompuLayers - 1; h >= 0; h--)
            {
                WeightsDiff = MatrixDotProduct(MatrixDotProduct(MatrixTranspose(OutputLayers[h]), errors), LearningRate);

                BasisDiff = new double[LayersBasis[h].GetLength(0)];

                for (int i = 0; i < LayersBasis[h].GetLength(0); i++)
                {
                    BasisDiff[i] = 0;
                    for (int j = 0; j < errors.GetLength(0); j++)
                        for (int k = 0; k < errors.GetLength(1); k++)
                            BasisDiff[i] += errors[j, k];
                    BasisDiff[i] *= LearningRate;
                }

                LayersWeights[h] = MatrixSubstract(LayersWeights[h], WeightsDiff);
                LayersBasis[h] = MatrixSubstract(LayersBasis[h], BasisDiff);

                if (h != 0) errors = MatrixProduct(MatrixDotProduct(errors, MatrixTranspose(LayersWeights[h])), _CalculateSigmoidDerivative(OutputLayers[h]));
            }



        }

        /// <summary>
        /// Transpose a matrix
        /// </summary>
        /// <returns></returns>
        public static double[,] MatrixTranspose(double[,] matrix)
        {
            int w = matrix.GetLength(0);
            int h = matrix.GetLength(1);

            double[,] result = new double[h, w];

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }
        public static double[,] MatrixTranspose(double[] matrix)
        {
            int w = 1;
            int h = matrix.Length;

            double[,] result = new double[h, w];

            for (int i = 0; i < h; i++)
            {
                result[i, 1] = matrix[i];
            }

            return result;
        }

        /// <summary>
        /// Sum one matrix with another
        /// </summary>
        /// <returns></returns>
        public static double[,] MatrixSum(double[,] matrixa, double[,] matrixb)
        {
            var rowsA = matrixa.GetLength(0);
            var colsA = matrixa.GetLength(1);

            var result = new double[rowsA, colsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int u = 0; u < colsA; u++)
                {
                    result[i, u] = matrixa[i, u] + matrixb[i, u];
                }
            }

            return result;
        }
        public static double[,] MatrixSum(double[,] matrixa, double[] matrixb)
        {
            var rowsA = matrixa.GetLength(0);
            var colsA = matrixa.GetLength(1);

            var result = new double[rowsA, colsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int u = 0; u < colsA; u++)
                    result[i, u] = matrixa[i, u] + matrixb[u];
            }

            return result;
        }
        public static double[] MatrixSum(double[] matrixa, double[] matrixb)
        {
            var rowsA = matrixa.GetLength(0);
            var result = new double[rowsA];

            for (int i = 0; i < rowsA; i++)
            {
                result[i] = matrixa[i] + matrixb[i];
            }

            return result;
        }
        public static double[,] MatrixSum(double[,] matrixa, double val)
        {
            var rowsA = matrixa.GetLength(0);
            var colsA = matrixa.GetLength(1);

            var result = new double[rowsA, colsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int u = 0; u < colsA; u++)
                {
                    result[i, u] = matrixa[i, u] + val;
                }
            }

            return result;
        }


        /// <summary>
        /// Subtract one matrix from another
        /// </summary>
        /// <returns></returns>
        public static double[,] MatrixSubstract(double[,] matrixa, double[,] matrixb)
        {
            var rowsA = matrixa.GetLength(0);
            var colsA = matrixa.GetLength(1);

            if (colsA != matrixb.GetLength(1)) {
                string l = String.Format("Matrices dimensions don't fit. {0}x{1} {2}x{3}", rowsA, colsA, matrixb.GetLength(0), matrixb.GetLength(1));
                Logger.NewLine(l);
                throw new Exception(l);
            }

            var result = new double[rowsA, colsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int u = 0; u < colsA; u++)
                {
                    result[i, u] = matrixa[i, u] - matrixb[i, u];
                }
            }
            return result;
        }
        public static double[] MatrixSubstract(double[] matrixa, double[] matrixb)
        {
            var result = new double[matrixa.Length];

            for (int i = 0; i < matrixa.Length; i++)
            {
                result[i] = matrixa[i] - matrixb[i];
            }

            return result;
        }

        /// <summary>
        /// Multiplication of a matrix
        /// </summary>
        /// <returns></returns>
        public static double[,] MatrixProduct(double[,] matrixa, double[,] matrixb)
        {
            var rowsA = matrixa.GetLength(0);
            var colsA = matrixa.GetLength(1);

            var result = new double[rowsA, colsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int u = 0; u < colsA; u++)
                {
                    result[i, u] = matrixa[i, u] * matrixb[i, u];
                }
            }

            return result;
        }

        /// <summary>
        /// Dot Multiplication of a matrix
        /// </summary>
        /// <returns></returns>
        public static double[,] MatrixDotProduct(double[,] matrixa, double[,] matrixb)
        {

            var rowsA = matrixa.GetLength(0);
            var colsA = matrixa.GetLength(1);

            var rowsB = matrixb.GetLength(0);
            var colsB = matrixb.GetLength(1);

            if (colsA != rowsB)
            {
                string l = String.Format("Matrices dimensions don't fit. {0}x{1} {2}x{3}", rowsA, colsA, matrixb.GetLength(0), matrixb.GetLength(1));
                Logger.NewLine(l);
                throw new Exception(l);
            }
            var result = new double[rowsA, colsB];

            //Console.WriteLine("From {0}x{1} {2}x{3} to {4}x{5}", rowsA, colsA, rowsB, colsB, result.GetLength(0), result.GetLength(1));

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < rowsB; k++)
                        result[i, j] += matrixa[i, k] * matrixb[k, j];
                }
            }
            return result;
        }
        public static double[,] MatrixDotProduct(double[,] matrixa, double value)
        {
            var rowsA = matrixa.GetLength(0);
            var colsA = matrixa.GetLength(1);

            var result = new double[rowsA, colsA];

            //Console.WriteLine("From {0}x{1} {2}x{3} to {4}x{5}", rowsA, colsA, rowsB, colsB, result.GetLength(0), result.GetLength(1));

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    result[i, j] = matrixa[i, j] * value;
                }
            }
            return result;
        }
        static void PrintMatrix(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);
            Console.Write("\n");
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
        }

    }
}
