using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recogniser._03database
{
    static class NeuralSaver
    {
        public static double[,] Read(string file, int w, int h) {
            String input = File.ReadAllText("Saves/"+file + ".txt");

            int i = 0, j = 0;
            double[,] result = new double[w, h];
            foreach (string row in input.Split('\n'))
            {
                if (!row.Equals(""))
                {
                    j = 0;
                    foreach (string col in row.Trim().Split(' '))
                    {
                        if (!col.Equals(""))
                        {
                            result[i, j] = double.Parse(col.Trim());
                            j++;
                        }
                    }
                    i++;
                }
            }
            return result;
        }


        public static void Write(string file, double[,] content)
        {
            using (var sw = new StreamWriter("Saves/" + file+".txt"))
            {
                for (int i = 0; i < content.GetLength(0); i++)
                {
                    for (int j = 0; j < content.GetLength(1); j++)
                    {
                        sw.Write(content[i, j] + " ");
                    }
                    sw.Write("\n");
                }

                sw.Flush();
                sw.Close();
            }
        }
    }
}
