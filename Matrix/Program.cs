using MatrixLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MyMatrix matrix= new MyMatrix(3,3);
           matrix.Randomize();
           Console.WriteLine(matrix.ToString());
           Console.WriteLine("Максимальный и Минимальный элемент в матрице ->" + matrix.getMax() + "/" + matrix.getMin());
           Console.WriteLine("Инверсированная матрица:");
           matrix.Inversion();
           Console.WriteLine(matrix.ToString());
           Console.WriteLine("Умножение матрицы на число 4:");
           matrix.Multiplication(4);
            Console.WriteLine(matrix.ToString());
            Console.WriteLine("Сложение 2-х матриц:\n Первая матрица:");
            Console.WriteLine(matrix.ToString());
            Console.WriteLine("Вторая матрица: ");
            MyMatrix matrix1 = new MyMatrix(3, 3);
            matrix1.Randomize();
            Console.WriteLine(matrix1.ToString());
            matrix.Addition(matrix, matrix1);
            Console.WriteLine("Результат сложения ->");
            Console.WriteLine(matrix.ToString());
            Console.WriteLine("Умножение 2-х матриц: ");
            Console.WriteLine("Первая матрица ->");
            Console.WriteLine(matrix.ToString());
            Console.WriteLine("Вторая матрица ->: ");
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine("Результат умножение 2-х матриц: ");
            matrix=matrix.MatrixMultiplication(matrix,matrix1);
            Console.WriteLine(matrix.ToString());
            Console.WriteLine("Транспонирование:");
            Console.WriteLine("Матрица до");
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine("Матрица после");
            matrix1.Transposition();
            Console.WriteLine(matrix1.ToString());
           




            Console.ReadKey();
        }
    }
}
