using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1__Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Matrix
            int nor, noe;
            Console.WriteLine("Enter Number of rows");
            nor = int.Parse(Console.ReadLine());
            int[][] matrix = new int[nor][];
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("Enter Number of elements in row" + (i + 1));
                noe = int.Parse(Console.ReadLine());
                matrix[i] = new int[noe];

                for (int j = 0; j < noe; j++)
                {
                    Console.WriteLine($"Enter Row {j + 1}\'s data");
                    matrix[i][j] = int.Parse(Console.ReadLine());

                }
            }
            int element = matrix[0][1];
            Console.WriteLine("Second element of first row " + element);
            matrix[1][2] = 15;

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine("Matrix row " + (i + 1));


                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");


                }

                Console.WriteLine();
                Console.WriteLine("**********");
            }
            Console.ReadKey();

            //2.ObjectMatrix
            int r, e;
            Console.WriteLine("Enter Number of rows for objectmatrix");
            r = int.Parse(Console.ReadLine());
            dynamic[][] objectMatrix = new dynamic[r][];

            for (int i = 0; i < objectMatrix.Length; i++)
            {
                Console.WriteLine("Enter the number of elements for" + (i + 1));
                e = int.Parse(Console.ReadLine());
                objectMatrix[i] = new dynamic[e];

                for (int j = 0; j < e; j++)
                {
                    Console.WriteLine($"Enter Row {j + 1}'s data");
                    objectMatrix[i][j] = Console.ReadLine();
                }
            }

            for (int i = 0; i < objectMatrix.Length; i++)
            {
                Console.WriteLine("Matrix row " + (i + 1));

                for (int j = 0; j < objectMatrix[i].Length; j++)
                {
                    Console.Write(objectMatrix[i][j] + " ");
                }

                Console.WriteLine();
                Console.WriteLine("**********");
            }

            Console.ReadKey();
        }
    }
}
     
