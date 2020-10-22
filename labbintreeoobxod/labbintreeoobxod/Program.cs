using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace labbintreeoobxod
{

    class Node
    {
        private static Random RandomGenerator => new Random();
        private static int MaxValue => 450;
        static readonly int MaxDept = 3;
        static int MaxWidth = 1;
        static int MatrixMaxWidth = 1;


        public static void TreeGeneration()
        {
            for (int i = 0; i < MaxDept - 1; i++)
            {
                MatrixMaxWidth = MatrixMaxWidth * 2;
            }
            int[,] TreeMatrix = new int[MaxDept, MatrixMaxWidth];
            for (int i = 0; i < MaxDept; i++)
            {
                for (int j = 0; j < MaxWidth; j++)
                {
                    TreeMatrix[i, j] = RandomGenerator.Next(MaxValue);
                }
                MaxWidth = MaxWidth * 2;
            }
            MaxWidth = 1;
            ConsoleOutput(TreeMatrix);
            WriteToFile(TreeMatrix);
        }
        public static void ConsoleOutput(int[,] TreeMatrix)
        {
            for (int i = 0; i < MaxDept; i++)
            {
                for (int j = 0; j < MaxWidth; j++)
                {
                    Console.Write(TreeMatrix[i, j] + ", ");
                }
                MaxWidth = MaxWidth * 2;
                Console.WriteLine();
            }
            MaxWidth = 1;
        }
        public static void WriteToFile(int[,] TreeMatrix)
        {
            StreamWriter sw = new StreamWriter("Запись дерева", false);
            for (int i = 0; i < MaxDept; i++)
            {
                for (int j = 0; j < MaxWidth; j++)
                {
                    sw.Write(TreeMatrix[i, j] + ", ");
                }
                MaxWidth = MaxWidth * 2;
                sw.WriteLine();
            }

            MaxWidth = 1;
            sw.Close();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Node.TreeGeneration();
        }
    }
}