using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsOnMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===Operations Nn Matrices===");
            Console.WriteLine("Enter number of rows for matrix 1:");
            int row1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns for matrix 1:");
            int col1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of rows for matrix 2:");
            int row2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of columns for matrix 2:");
            int col2 = Convert.ToInt32(Console.ReadLine());
            double[,]matrix1=new double[row1,col1];
            double[,]matrix2 = new double[row2, col2];
            double[,] matrix = new double[row1, col2];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write( "Enter value for element [{0},{1}]: ",i , j);
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write("Enter value for element [{0},{1}]: ", i, j);
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("=====Printing=====");
            Console.WriteLine("matrix 1");
            for (int i = 0; i < row1; i++) {
                for (int j = 0; j < col1; j++)
                {
                    Console.Write(matrix1[i, j] +"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("matrix 2");

            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < col2; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====Addition=====");
            if (row1 == row2 && col1 == col2)
            {
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        matrix[i,j]= matrix1[i, j] + matrix2[i, j];
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine() ;
                }
            }
            else
            {
                Console.WriteLine("Addition not possible!");
            }
            Console.WriteLine("=====Subtraction=====");
            if (row1 == row2 && col1 == col2)
            {
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        matrix[i, j] = matrix1[i, j] - matrix2[i, j];
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Subtraction not possible!");
            }
            Console.WriteLine("=====Multiplication=====");
            if (col1 == row2 )
            {
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        double sum = 0;
                            for (int k = 0; k < col1; k++) 
                            {
                                sum += matrix1[i, k] * matrix2[k, j];
                            }
                            matrix[i, j] = sum;
                            Console.Write(matrix[i, j]+ "\t");
                    }
                    Console.WriteLine();
                }    
                }
            else
            {
                Console.WriteLine("Multiplication not possible!");
            }
            Console.WriteLine("=====Determinant of 2 by 2 Matrix=====");
            Console.WriteLine("For Matrix 1:");
            if (col1 == row1 && row1 == 2)
            {
                double a = matrix1[0, 0];
                double b = matrix1[0, 1];
                double c = matrix1[1, 0];
                double d = matrix1[1, 1];

                double det = (a * d) - (b * c);
                Console.WriteLine("Determinant = {0}", det);
            }
            else
            {
                Console.WriteLine("Determinant not possible!");
            }
            Console.WriteLine("For Matrix 2:");
            if (col2 == row2 && row2 == 2)
            {
                double a = matrix2[0, 0];
                double b = matrix2[0, 1];
                double c = matrix2[1, 0];
                double d = matrix2[1, 1];

                double det = (a * d) - (b * c);
                Console.WriteLine("Determinant = {0}", det);
            }
            else
            {
                Console.WriteLine("Determinant not possible!");
            }
            Console.WriteLine("=====Inverse of 2 by 2 Matrix=====");
            Console.WriteLine("For Matrix 1:");
            if (col1 == row1 && row1 == 2) 
            {
                double a = matrix1[0, 0];
                double b = matrix1[0, 1];
                double c = matrix1[1, 0];
                double d = matrix1[1, 1];

                double det = (a * d) - (b * c);
                Console.WriteLine("Determinant = {0}", det);

                if (det == 0)
                {
                    Console.WriteLine("Inverse not possible!");
                }
                else
                {
                    double[,] inv1 = new double[2, 2];
                    inv1[0, 0] = d / det;
                    inv1[0, 1] = -b / det;
                    inv1[1, 0] = -c / det;
                    inv1[1, 1] = a / det;

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write(inv1[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Inverse only for 2x2 matrices!");
            }

            Console.WriteLine("For Matrix 2:");
            if (col2 == row2 && row2 == 2)
            {
                double a = matrix2[0, 0];
                double b = matrix2[0, 1];
                double c = matrix2[1, 0];
                double d = matrix2[1, 1];

                double det = (a * d) - (b * c);
                Console.WriteLine("Determinant = {0}", det);

                if (det == 0)
                {
                    Console.WriteLine("Inverse not possible!");
                }
                else
                {   
                    double[,] inv2 = new double[2, 2];
                    inv2[0, 0] = d / det;
                    inv2[0, 1] = -b / det;
                    inv2[1, 0] = -c / det;
                    inv2[1, 1] = a / det;

                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            Console.Write(inv2[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Inverse only for 2x2 matrices!");
            }
        }
           }
        }
 
