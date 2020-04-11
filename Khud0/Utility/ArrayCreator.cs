using System;
using System.Collections.Generic;
using System.Text;

namespace Khud0.Utility
{
    public static class ArrayCreator
    {
        /// <summary>
        /// Creates a new int array and fills it with random numbers from MinNumber to MaxNumber (inclusive).
        /// </summary>
        public static int[] CreateAndFillArray(int length, int minNumber, int maxNumber)
        {
            int[] newArray = new int[length];
            Random random = new Random();

            for (int i=0; i<length; i++)
            {
                newArray[i] = random.Next(minNumber, maxNumber+1);
            }

            return newArray;
        }
    }
}
