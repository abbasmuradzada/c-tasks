using System;
using System.Globalization;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------FIRST TASK-----------------------------------


            int[] arrayA = new int[5];

            Console.WriteLine("Fill your array (must be 5 element)");
            for (int i = 0; i < arrayA.Length; i++)
            {
                int newNum = Convert.ToInt32(Console.ReadLine());
                arrayA[i] = newNum;
            }
            Console.WriteLine("Enter your break point");
            int breakPoint = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("These numbers are smaller than your breakpoint");
            foreach (var item in arrayA)
            {
                if (item < breakPoint)
                {
                    Console.WriteLine(item);
                }
            }


            //----------------------------------SECOND TASK-----------------------------------


            //int[] arrayA = new int[5];

            //Console.WriteLine("Fill your array (must be 5 element)");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    int newNum = Convert.ToInt32(Console.ReadLine());
            //    arrayA[i] = newNum;
            //}
            //Console.WriteLine("Enter your break point");
            //int breakPoint = Convert.ToInt32(Console.ReadLine());

            //int counter = 0;
            //int result = 0;
            //foreach (var item in arrayA)
            //{
            //    if (item < breakPoint)
            //    {
            //        counter++;
            //        result += item;
            //    }
            //}
            //Console.WriteLine("These number is numerical average of numbers smaller than your breakpoint");
            //Console.WriteLine(result / counter);


            //----------------------------------THIRD TASK-----------------------------------

            //int[] arraya = new int[5];

            //Console.WriteLine("fill your array (must be 5 element)");
            //for (int i = 0; i < arraya.Length; i++)
            //{
            //    int newnum = Convert.ToInt32(Console.ReadLine());
            //    arraya[i] = newnum;
            //}
            //Console.WriteLine("enter your break point");
            //int breakpoint = Convert.ToInt32(Console.ReadLine());

            //int counter = 0;
            //int result = 1;
            //foreach (var item in arraya)
            //{
            //    if (item < breakpoint)
            //    {
            //        counter++;
            //        result *= item;
            //    }
            //}

            //double root = (double)1 / counter;

            //Console.WriteLine("Geometric mean is:");
            //Console.WriteLine(Math.Pow(result, root));


            //----------------------------------FOURTH TASK-----------------------------------


            //int[] arrayA = new int[5];

            //Console.WriteLine("Fill your array (must be 5 element)");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    int newNum = Convert.ToInt32(Console.ReadLine());
            //    arrayA[i] = newNum;
            //}

            //Array.Sort(arrayA);
            //Array.Reverse(arrayA);
            //Console.WriteLine("Enter your break point");
            //int breakPoint = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("These numbers are smaller than your breakpoint");
            //foreach (var item in arrayA)
            //{
            //    if (item < breakPoint)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //----------------------------------FIFTH TASK-----------------------------------


            //int[] arrayA = new int[5];

            //Console.WriteLine("Fill your array (must be 5 element)");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    int newNum = Convert.ToInt32(Console.ReadLine());
            //    arrayA[i] = newNum;
            //}
            //Array.Sort(arrayA);

            //Console.WriteLine("Enter your break point");
            //int breakPoint = Convert.ToInt32(Console.ReadLine());

            //int result = 0;

            //foreach (var item in arrayA)
            //{
            //    if (item < breakPoint)
            //    {
            //        result = item;
            //    }
            //}

            //Console.WriteLine("The biggest of numbers");
            //Console.WriteLine(result);


            //----------------------------------SIXTH TASK-----------------------------------


            //int[] arrayX = new int[5];
            //int[] arrayY = new int[5] { 4, 5, 10, 6, 7 };


            //for (int i = 0; i < arrayX.Length; i++)
            //{
            //    arrayX[i] = arrayY[i] * arrayY[i];
            //}

            //foreach (var item in arrayX)
            //{
            //    Console.WriteLine(item);
            //}


            //----------------------------------SEVENTH TASK-----------------------------------


            //int[] arrayA = new int[5];

            //Console.WriteLine("Fill your array (must be 5 element)");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    int newNum = Convert.ToInt32(Console.ReadLine());
            //    arrayA[i] = newNum;
            //}
            //Array.Sort(arrayA);

            //int numO = (arrayA[0] + arrayA[4]) / 2;
            //int geoO = (int)Math.Pow((arrayA[0] * arrayA[4]), 0.5);

            //Console.WriteLine("Numerical overage of biggest and smallest element of array is:");
            //Console.WriteLine(numO);
            //Console.WriteLine("Geometric mean of biggest and smallest element of array is:");
            //Console.WriteLine(geoO);


            //----------------------------------EİGHTH TASK-----------------------------------


            //int[] arrayA = new int[14] { 1, 2, 4, 7, 8, 4, 5, 10, 6, 7, 11, 21, 15, 13 };
            //int[] arrayB = new int[14] { 3, 4, 3, 6, 3, 2, 7, 11, 2, 6, 12, 1, 5, 11};

            //int[] arrayC = new int[14];

            //for (int i = 0; i < arrayC.Length; i++)
            //{
            //    arrayC[i] = arrayA[i] * arrayB[i];
            //}

            //foreach (var item in arrayC)
            //{
            //    Console.WriteLine(item);
            //}


            //----------------------------------NINTH TASK-----------------------------------


            //int[] arrayA = new int[25] { 1, 2, 4, 7, 8, 4, 5, 10, 6, 7, 11, 21, 15,
            //                             13, 7, 8, 4, 5, 10, 6, 7, 11, 21, 15, 13 };
            //int[] arrayB = new int[8];
            //int[] arrayC = new int[17];

            //for (int i = 0; i < arrayB.Length; i++)
            //{
            //    arrayB[i] = arrayA[i] * arrayA[i];
            //}

            //for (int i = arrayB.Length; i < arrayA.Length; i++)
            //{

            //    arrayC[i - arrayB.Length] = arrayA[i] / 4;
            //}

            //foreach (var item in arrayB)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in arrayC)
            //{
            //    Console.WriteLine(item);
            //}


            //----------------------------------TENTH TASK-----------------------------------


            //int[] arrayA = new int[5] { 1, -2, -4, -7, 8, };

            //Array.Sort(arrayA);

            //int result = 0;
            //foreach (var item in arrayA)
            //{
            //    if (item<0)
            //    {
            //        result = item;
            //    }
            //}

            //Console.WriteLine("The biggest negative element of array is:");
            //Console.WriteLine(result);


            //----------------------------------ELEVENTH TASK-----------------------------------


            //int[] arrayA = new int[20];

            //Random r = new Random();

            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    arrayA[i] = r.Next(0, 100);
            //}

            //Array.Sort(arrayA);
            //Array.Reverse(arrayA);

            //foreach (var item in arrayA)
            //{
            //    Console.WriteLine(item);
            //}


            //----------------------------------TWELFTH TASK-----------------------------------


            //int[] arrayA = new int[20] { 1, 2, 4, 7, 8, 4, 5, 10, 6, 7, 11, 21, 15, 13, 7, 8, 4, 5, 10, 6 };

            //int resultN = 0;
            //int counterN = 0;
            //for (int i = 0; i < arrayA.Length / 2; i++)
            //{
            //    resultN += arrayA[i];
            //    counterN++;
            //}

            //Console.WriteLine("Numerical overage of first part is:");
            //Console.WriteLine(resultN / counterN);

            //int resultG = 1;
            //int counterG = 1;
            //for (int i = (arrayA.Length / 2); i < arrayA.Length; i++)
            //{
            //    resultG *= arrayA[i];
            //    counterG++;
            //}

            //Console.WriteLine("Geometric mean of second part is:");
            //Console.WriteLine(Math.Pow(resultG, (double)1 / counterG));

        }

    }
}
