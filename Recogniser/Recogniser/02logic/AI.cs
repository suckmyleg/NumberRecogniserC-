using Recogniser._02logic;
using System;

namespace Recogniser
{
    public class AI
    {
        NeuralNetwork neural;
        static void PrintMatrix(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Logger.NewLine(string.Format("{0} ", matrix[i, j]));
                }
            }
        }

        public void Train() {
            var trainingInputs = new double[,] { { 0, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            var trainingOutputs = NeuralNetwork.MatrixTranspose(new double[,] { { 1, 0, 1, 0, 1 } });

            neural.Train(trainingInputs, trainingOutputs, 1000000);
        }

        public AI()
        {
            neural = new NeuralNetwork(new int[]{ 3, 3, 3, 1 }, 0.01);

            /*Console.WriteLine("Synaptic weights before training:");
            PrintMatrix(curNeuralNetwork.LayersWeights);
            */



            /*
            Console.WriteLine("\nSynaptic weights after training:");
            PrintMatrix(curNeuralNetwork.SynapsesMatrix);
            */

            // testing neural networks against a new problem 
            var output = curNeuralNetwork.Think(new double[,] { { 0, 0, 0 }, { 0, 0, 1 }, { 1, 1, 1 } });
            PrintMatrix(output);
        }
    }

}