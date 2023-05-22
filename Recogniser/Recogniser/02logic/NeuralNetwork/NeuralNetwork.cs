using Recogniser;
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
            // make sure that for every instance of the neural network we are geting the same radom values
            RandomO = new Random(1);
            GenerateLayers();
        }

        /// <summary>
        /// Generate our matrix with the weight of the synapses
        /// </summary>
        public void GenerateLayers()
        {

            GenerateWeights();
            GenerateBasis();
        }

        public void GenerateWeights()
        {
            LayersWeights = new double[NCompuLayers][,];
            for (int h = 0; h < NCompuLayers; h++)
            {
                LayersWeights[h] = new double[Layers[h], Layers[h + 1]];
                for (var i = 0; i < Layers[h]; i++)
                {
                    for (var j = 0; j < Layers[h + 1]; j++)
                    {
                        LayersWeights[h][i, j] = (2 * RandomO.NextDouble()) - 1;
                    }
                }
            }
        }

        public void GenerateBasis()
        {
            LayersBasis = new double[NCompuLayers][];

            for (int h = 0; h < NCompuLayers; h++)
            {
                LayersBasis[h] = new double[Layers[h + 1]];
                for (var i = 0; i < Layers[h + 1]; i++)
                {
                    LayersBasis[h][i] = (2 * RandomO.NextDouble()) - 1;
                }
            }
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
                inputMatrix = Math.CalculateSigmoid(Math.MatrixSum(Math.MatrixDotProduct(inputMatrix, LayersWeights[h]), LayersBasis[h]));
                OutputLayers[h + 1] = inputMatrix;
            }
            return inputMatrix;
        }

        /// <summary>
        /// Train the neural network to achieve the output matrix values
        /// </summary>
        public void Train(double[,] trainInputMatrix, double[,] trainOutputMatrix, double interactions)
        {
            for (int i = 0; i < interactions; i++)
            {
                Teach(trainOutputMatrix, Think(trainInputMatrix));
            }
        }

        public void Teach(double[,] expected, double[,] output)
        {
            double[,] errors = Math.MatrixSubstract(output, expected);

            double[,] WeightsDiff;
            double[] BasisDiff;

            /*We start since the last ComputLayer:: CompuLayers : Ex: [Hidden, Hidden, Output] NComputLayers = 3, ser start since the 2 to 1
            * Range = OutPutLayerLength
            **/
            //Console.WriteLine("Adjusting weights from layer {0}-{1}", NCompuLayers, 0);
            for (int h = NCompuLayers - 1; h >= 0; h--)
            {
                WeightsDiff = Math.MatrixDotProduct(Math.MatrixDotProduct(Math.MatrixTranspose(OutputLayers[h]), errors), LearningRate);

                BasisDiff = new double[LayersBasis[h].GetLength(0)];

                for (int i = 0; i < LayersBasis[h].GetLength(0); i++)
                {
                    BasisDiff[i] = 0;
                    for (int j = 0; j < errors.GetLength(0); j++)
                        for (int k = 0; k < errors.GetLength(1); k++)
                            BasisDiff[i] += errors[j, k];
                    BasisDiff[i] *= LearningRate;
                }

                LayersWeights[h] = Math.MatrixSubstract(LayersWeights[h], WeightsDiff);
                LayersBasis[h] = Math.MatrixSubstract(LayersBasis[h], BasisDiff);

                if (h != 0) errors = Math.MatrixProduct(Math.MatrixDotProduct(errors, Math.MatrixTranspose(LayersWeights[h])), Math.CalculateSigmoidDerivative(OutputLayers[h]));
            }
        }
    }
}
