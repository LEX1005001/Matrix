using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MatrixLibrary
{
    public class MyMatrix
    {
        private int[,] matrix;
        private int rows=0;
        private int columns=0;

        /*public int Matrix 
        {
            
        }*/

        public int Rows
        {
            get
            {
                return this.rows;
            }
            set 
            {
                this.rows = value; 
            }

        }

        public int Columns
        {
            get 
            {
                return this.columns;
            }
            set 
            {
                this.columns = value;
            }
        }

        public MyMatrix() //конструктор поумолчанию
        {
            int[,] matrix = new int[0, 0];
            
        }

        public MyMatrix(int rows, int columns) //конструктор со значениями
        {
            this.Rows = rows;
            this.Columns = columns;
            matrix= new int[rows, columns];
        
        }
        public MyMatrix(MyMatrix matrix, int rows, int columns)
        {
            this.matrix=new int[this.rows=rows, this.columns=columns];


        }

        /// <summary>
        /// Заполняем матрицу случайными элементами
        /// </summary>
        public void Randomize()
        {
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    
                    matrix[i, j] = rand.Next(-100,100); 
                }
            }
        }

        /// <summary>
        /// Получение максимаольного элемента в Матрице
        /// </summary>
        /// <returns>максимальный элемент в матрице</returns>
        public int getMax()
        {
            int max = -1000;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] >= max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// Получение минимального элемента в Матрице
        /// </summary>
        /// <returns>минимальный элемент в матрице</returns>
        public int getMin()
        {
            int min = 1000;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] <= min)
                    {
                        min = matrix[i, j];
                    }
                }
            }
            return min;
        }
        
        /// <summary>
        /// Инверсирует матрицу
        /// </summary>
        public void Inversion()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] *= -1;
                }
            }
        }

        /// <summary>
        /// Умножает каждый элемент матрицы на указанное значение
        /// </summary>
        /// <param name="value">число на которое будет умножен каждый элемент матрицы</param>
        public void Multiplication(int value)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] *= value;
                }
            }
        }

        /// <summary>
        /// Сложение 2-x матриц
        /// </summary>
        /// <param name="matrix1">первая матрица</param>
        /// <param name="matrix2">вторая матрица</param>
        /// <returns>результат сложения 2-х матриц</returns>
        public MyMatrix Addition(MyMatrix matrix1,MyMatrix matrix2)
        {
            if(matrix1 == null || matrix2 == null)
            {
                return this;
            }

            if(matrix1.rows==matrix2.rows && matrix1.columns == matrix2.columns)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix1.matrix[i, j] += matrix2.matrix[i,j];
                    }
                }
            }
            
            return matrix1;
        }

        /// <summary>
        /// Умножение 2-х матриц
        /// </summary>
        /// <param name="matrix1">первая матрца</param>
        /// <param name="matrix2">вторая матрица</param>
        /// <returns>результат умножения 2-х матриц
        /// (если матрицы пусты или их размеры различный то возращаем 1 матрицу</returns>
        public MyMatrix MatrixMultiplication(MyMatrix matrix1,MyMatrix matrix2)
        {
          
            if (matrix1 == null || matrix2 == null)
            {
                return this;
            }

            if (matrix1.rows == matrix2.columns && matrix1.columns == matrix2.rows)
            {
                MyMatrix matrix3 = new MyMatrix(matrix1.rows,matrix1.columns);
                for(int i = 0; i < matrix1.matrix.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix2.matrix.GetLength(1); j++)
                    {
                        for(int k = 0; k < matrix2.matrix.GetLength(0); k++)
                        {
                            matrix3.matrix[i, j] += (matrix1.matrix[i, k] * matrix2.matrix[k, j]);
                        }
                    }
                }
                return matrix3;
            }
            return matrix1;
        }
        
        public void Transposition()
        {
            int w = matrix.GetLength(0);
            int h = matrix.GetLength(1);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    matrix[j, i] = matrix[i, j];
                }
            }
        }
        /// <summary>
        /// конвертирует матрицу в строку для вывода
        /// </summary>
        /// <returns>матрицу в формате string</returns>
        public override string ToString()
        {
            string answer = "";
            for (int i = 0; i < this.rows; i++)
            {
                for(int j = 0; j < this.columns; j++)
                {
                    answer+= matrix[i, j]+" ";
                }
                answer+= "\n";
            }
            return answer;

        }

        


    }
    
}
