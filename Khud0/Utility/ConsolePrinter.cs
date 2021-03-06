﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Khud0.Utility
{
    public class ConsolePrinter
    {
        private int arrayNumber = 0;

        public void PrintOutArray<T>(T[] array)
        {
            Console.Write($"Array #{++arrayNumber}: ");
            foreach (T element in array) Console.Write(element.ToString() + " ");
            Console.WriteLine();
        }
    }
}
