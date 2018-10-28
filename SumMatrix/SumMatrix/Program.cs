using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину и высоту матриц");
            int width, heigth;
            width = Int32.Parse(Console.ReadLine());
            heigth = Int32.Parse(Console.ReadLine());
            IOManager manager = new IOManager();
            double[,] x = new double[width, heigth];
            Console.WriteLine("Введите первую матрицу");
            x = manager.InputMatrix(width,heigth);
            Console.WriteLine("Первая матрица:");
            manager.OutputMatrix(width, heigth, x);
            double[,] y = new double[width, heigth];
            Console.WriteLine("Введите вторую матрицу");
            y = manager.InputMatrix(width, heigth);
            Console.WriteLine("Вторая матрица:");
            manager.OutputMatrix(width, heigth, y);
            double[,] result = new double[width, heigth];
            for (int i = 0; i < width; i++)
                for (int j = 0; j < heigth; j++)
                    result[i,j]=x[i,j]+y[i,j];
            Console.WriteLine("Результат:");
            manager.OutputMatrix(width, heigth, result);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}
