using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser
{
    public static class ImageManager
    {
        public const int NUMBERSIDES = 9;
        public static List<double> Load(string imagePath)
        {
            // Cargar la imagen
            Bitmap originalImage = new Bitmap(imagePath);

            // Convertir la imagen a blanco y negro sin escala de grises
            Bitmap blackAndWhiteImage = ConvertToBlackAndWhite(originalImage);

            // Recortar la imagen en 16 cuadrados y obtener los porcentajes de negro
            double[,] percentages = GetBlackPercentages(blackAndWhiteImage, NUMBERSIDES, NUMBERSIDES);

            List<double> imagePercentages = new List<double>();

            // Mostrar los porcentajes
            for (int row = 0; row < NUMBERSIDES; row++)
            {
                for (int col = 0; col < NUMBERSIDES; col++)
                {
                    imagePercentages.Add(percentages[row, col]);
                }
            }

            return imagePercentages;
        }

        private static Bitmap ConvertToBlackAndWhite(Bitmap originalImage)
        {
            Bitmap blackAndWhiteImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // Calcular el promedio de los componentes rojo, verde y azul del píxel
                    int average = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                    // Definir un umbral para determinar si el píxel será blanco o negro
                    int threshold = 128;

                    // Establecer el nuevo color en blanco o negro según el umbral
                    Color newColor = (average >= threshold) ? Color.White : Color.Black;

                    // Establecer el nuevo color en la imagen en blanco y negro
                    blackAndWhiteImage.SetPixel(x, y, newColor);
                }
            }

            return blackAndWhiteImage;
        }

        private static double[,] GetBlackPercentages(Bitmap image, int rows, int cols)
        {
            double[,] percentages = new double[rows, cols];
            int cellWidth = image.Width / cols;
            int cellHeight = image.Height / rows;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int blackPixels = 0;
                    int totalPixels = 0;

                    // Contar los píxeles negros en la celda actual
                    for (int y = row * cellHeight; y < (row + 1) * cellHeight; y++)
                    {
                        for (int x = col * cellWidth; x < (col + 1) * cellWidth; x++)
                        {
                            Color pixelColor = image.GetPixel(x, y);

                            if (pixelColor.GetBrightness() < 0.5f) // Verificar el brillo del píxel
                            {
                                blackPixels++;
                            }

                            totalPixels++;
                        }
                    }

                    // Calcular el porcentaje de píxeles negros en la celda actual
                    float percentage = (float)blackPixels / totalPixels;
                    percentages[row, col] = percentage;
                }
            }

            return percentages;
        }

    }
}
