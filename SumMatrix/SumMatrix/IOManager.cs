using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrix
{
    class IOManager
    {
        public double[,] InputMatrix(int width, int height)
        {
            double[,] array = new double[width,height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.WriteLine("Элемент № "+(i+1)+", "+(j+1));
                    array[i, j]=Double.Parse(Console.ReadLine());
                }
            }

            return array;
        }

        public void OutputMatrix(int width, int height, double[,] array)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(array[i, j]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
        }
    }
}
