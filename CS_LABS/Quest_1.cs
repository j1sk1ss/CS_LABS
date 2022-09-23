﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_LABS
{
    public class Quest_1 : Math
    {
        private readonly Dictionary<int, Action> _works = new Dictionary<int, Action>();
        private void AddVoids()
        {
            _works.Add(1,Work_1);
            _works.Add(2,Work_2);
            _works.Add(3,Work_3);
            _works.Add(4,Work_4);
        }
        public void Main()
        {
            AddVoids();
            Console.WriteLine("Type a number of work: ");
            _works[ToInt(Console.ReadLine())]();
        }
        private static void Work_1()
        {
            Console.WriteLine("This work where u should type a value of variable X:");
                Console.WriteLine("X: ");
                double x = ToDouble(Console.ReadLine());
            Console.WriteLine("Answer: ");
            Console.Write(2 * System.Math.Atan(3 * x) * (-System.Math.Sqrt(x)) -
                          ((1) / 12 * System.Math.Pow(x, 2) + 7 * x - 5));
        }

        private static void Work_2()
        {
            double[,] cords = new double[2, 2];
            Console.WriteLine("This work where u should type a values of coordinates dot X, Y and circle X, Y and his radius:");
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)Console.WriteLine("Type Dot coordinates:");
                else Console.WriteLine("Type Circle coordinates:");
                    for (int j = 0; j < 2; j++)
                    {
                        cords[i, j] = ToInt(Console.ReadLine());
                    }
            }
            Console.WriteLine("Circle radius: ");
                double r = ToInt(Console.ReadLine());
            Console.WriteLine(CircleCheck(cords, r));
        }

        private static void Work_3()
        {
            Console.WriteLine("In this work u should type a year and he will be converted to old Japan format:");
                int year = ToInt(Console.ReadLine());
                string[] yearNames =
                {
                    "Rat", "Cow", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Ship", "Monkey", "Chicken", "Dog", "Pig"
                };
            if (year > 0) Console.WriteLine($"This year is called like {yearNames[year % 12]}.");
        }

        private static void Work_4()
        {
            Console.WriteLine("Type scholarship: ");
            var scholarship = ToDouble(Console.ReadLine());
            Console.WriteLine("Type start every month spending: ");
            var spending = ToDouble(Console.ReadLine());
            double budgetDeficit = 0;
                if (scholarship > spending) {
                    Console.WriteLine("Scholarship is higher then spending!");
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                            spending += .03d * spending;
                            budgetDeficit += (spending - scholarship);
                    }
                    Console.WriteLine(budgetDeficit + $" needs to be taken from parents with {spending} every month spending");
                }
        }
    }
}