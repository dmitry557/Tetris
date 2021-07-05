using System;
using Tetris;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] nums1 = new int[5];
             nums1[0] = 1;
             nums1[1] = 2;

             foreach (int i in nums1)
             {
                 Console.WriteLine(i);
             }

             Point[] points = new Point[3];
             points[0] = new Point(1, 2, '*');
             points[1] = new Point(3, 4, '#');
             points[2] = new Point(5, 6, '*');

             foreach (Point p in points)
             {
                 p.Draw();
             }
            */

            char[][] feild = new char[3][];
            feild[0] = new char[3];
            feild[1] = new char[3];
            feild[2] = new char[3];

            feild[0][0] = 'X';
            feild[2][2] = '0';

            for (int i = 0; i < feild.Length; i++)
            {
                for (int j = 0; j < feild[i].Length; j++)
                {
                    Console.Write(feild[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
