﻿using System; // I have done everything, probaly)

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 
            Console.WriteLine("answer for 1 task");
            double BMI = 73 / Math.Pow(17.5, 2);
            Console.WriteLine($"My BMI is {BMI}");
            #endregion


            #region 2
            Console.WriteLine("answer for 2 task");
            int number = 11;
            double a = 100 / number;
            double b = 18 - (a / number);
            int grad = 10 * 11;
            double L = (a * (2.28 * (Math.Pow(b / a, 1.44)) + 4)) / grad;
            Console.WriteLine(L);
            #endregion

            #region 3
            int a0 = 11;
            int S = 10106;
            int n = int.Parse(Console.ReadLine());
            int an = S / n * 2 - a0;
            double d = (an - a0) / n;
            Console.WriteLine(d);
            #endregion
        }
    }
}

