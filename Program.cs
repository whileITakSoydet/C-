using System;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose number task: ");
            int task = int.Parse(Console.ReadLine());
            int[,] matrix;
            int[,] matrix2;
            switch (task)
            {
                case 1:
                    matrix = createMatrix();
                    showMatrix(ref matrix);
                    matrix2 = createMatrix();
                    showMatrix(ref matrix2);
                    int[,] matrixSum = sumMatrix(ref matrix, ref matrix2);
                    showMatrix(ref matrixSum);
                    break;
                case 2:
                    matrix = createMatrix();
                    showMatrix(ref matrix);
                    Console.Write("Enter number for mult on matrix: ");
                    int number = int.Parse(Console.ReadLine());
                    multMatrixOnNumber(ref matrix, ref number);
                    showMatrix(ref matrix);
                    break;
                case 3:
                    matrix = createMatrix();
                    showMatrix(ref matrix);
                    matrix2 = createMatrix();
                    showMatrix(ref matrix2);
                    int[,] matrixMult = multMatrix(ref matrix, ref matrix2);
                    showMatrix(ref matrixMult);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            Console.ReadKey();
        }
        static int[,] createMatrix()
        {
            Console.WriteLine("Enter numbers lines in matrix: ");
            int line = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter numbers columns in matrix: ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[line, column];

            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for(int j = 0; j < matrix.GetLength(1); ++j)
                {
                    Console.Write("\nEnter number by index (" + i + " : " + j + "): ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
        static void showMatrix(ref int[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int[,] sumMatrix(ref int[,] firstMatrix, ref int[,] secondMatrix)
        {
            if(firstMatrix.GetLength(0) != secondMatrix.GetLength(0) || firstMatrix.GetLength(1) != secondMatrix.GetLength(1))
            {
                Console.WriteLine("Your matrix don`t equal");
                return new int[0,0];
            }
            else
            {
                int[,] matrixSum = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
                for (int i = 0; i < firstMatrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < firstMatrix.GetLength(1); ++j)
                    {
                        matrixSum[i,j] = firstMatrix[i,j] + secondMatrix[i,j];
                    }
                }
                return matrixSum;
            }
        }
        static void multMatrixOnNumber(ref int[,] matrix, ref int number)
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    matrix[i, j] *= number;
                }
            }
        }
        static int[,] multMatrix(ref int[,] firstMatrix, ref int[,] secondMatrix)
        {
            if(firstMatrix.GetLength(0) == secondMatrix.GetLength(1)) 
            {
                int[,] multMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
                for (int i = 0; i < multMatrix.GetLength(0); ++i)
                {
                    for (int j = 0; j < secondMatrix.GetLength(1); ++j)
                    {
                        for (int k = 0; k < firstMatrix.GetLength(1); ++k)
                        {
                            multMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                        }
                    }
                }
                return multMatrix;
            }
            else
            {
                Console.WriteLine("These matrix can not mult");
                return new int[0,0];
            }
        }
    }
}