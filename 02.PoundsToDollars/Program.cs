﻿using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal course = 1.31m;
            decimal usd = pounds * course;
            Console.WriteLine($"{usd:f3}");
        }
    }
    }

