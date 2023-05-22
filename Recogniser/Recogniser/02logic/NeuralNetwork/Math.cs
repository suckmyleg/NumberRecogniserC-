using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    internal static class Math
    {
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
            int rowsA = matrixa.GetLength(0);
            int colsA = matrixa.GetLength(1);

            double[,] result = new double[rowsA, colsA];

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
            int rowsA = matrixa.GetLength(0);
            int colsA = matrixa.GetLength(1);

            double[,] result = new double[rowsA, colsA];

            for (int i = 0; i < rowsA; i++)
            {
                for (int u = 0; u < colsA; u++)
                    result[i, u] = matrixa[i, u] + matrixb[u];
            }

            return result;
        }
        public static double[] MatrixSum(double[] matrixa, double[] matrixb)
        {
            int rowsA = matrixa.GetLength(0);
            double[] result = new double[rowsA];

            for (int i = 0; i < rowsA; i++)
            {
                result[i] = matrixa[i] + matrixb[i];
            }

            return result;
        }
        public static double[,] MatrixSum(double[,] matrixa, double val)
        {
            int rowsA = matrixa.GetLength(0);
            int colsA = matrixa.GetLength(1);

            double[,] result = new double[rowsA, colsA];

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
            int rowsA = matrixa.GetLength(0);
            int colsA = matrixa.GetLength(1);

            if (colsA != matrixb.GetLength(1))
            {
                string l = String.Format("Matrices dimensions don't fit. {0}x{1} {2}x{3}", rowsA, colsA, matrixb.GetLength(0), matrixb.GetLength(1));
                Logger.NewLine(l);
                throw new Exception(l);
            }

            double[,] result = new double[rowsA, colsA];

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
            double[] result = new double[matrixa.Length];

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
            int rowsA = matrixa.GetLength(0);
            int colsA = matrixa.GetLength(1);

            double[,] result = new double[rowsA, colsA];

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

            int rowsA = matrixa.GetLength(0);
            int colsA = matrixa.GetLength(1);

            int rowsB = matrixb.GetLength(0);
            int colsB = matrixb.GetLength(1);

            if (colsA != rowsB)
            {
                string l = String.Format("Matrices dimensions don't fit. {0}x{1} {2}x{3}", rowsA, colsA, matrixb.GetLength(0), matrixb.GetLength(1));
                Logger.NewLine(l);
                throw new Exception(l);
            }
            double[,] result = new double[rowsA, colsB];

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
            int rowsA = matrixa.GetLength(0);
            int colsA = matrixa.GetLength(1);

            double[,] result = new double[rowsA, colsA];

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









        /// <summary>
        /// Calculate the sigmoid of a value
        /// </summary>
        /// <returns></returns>
        public static double[,] CalculateSigmoid(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    double value = matrix[i, j];
                    matrix[i, j] = 1 / (1 + System.Math.Exp(value * -1));
                }
            }
            return matrix;
        }

        /// <summary>
        /// Calculate the sigmoid derivative of a value
        /// </summary>
        /// <returns></returns>
        public static double[,] CalculateSigmoidDerivative(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    double value = matrix[i, j];
                    matrix[i, j] = value * (1 - value);
                }
            }
            return matrix;
        }

    }
}
