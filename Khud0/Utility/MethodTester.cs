using System;
using System.Collections.Generic;
using System.Text;

namespace Khud0.Utility
{
    /// <summary>
    /// Fires all the given methods by using delegates (Func or Predicate).
    /// Shows how much time they took to finish.
    /// </summary>
    public class MethodTester
    {
        public void TestMethods<TInput, TOutput>(TInput input, params Func<TInput, TOutput>[] methods)
        {
            int methodsCount = methods.Length;
            for (int i=0; i<methodsCount; i++)
            {
                Stopwatcher.Start();
                TOutput result = methods[i].Invoke(input);
                Console.WriteLine($"\nMethod {methods[i].Method.Name} returned: {methods[i].Invoke(input)}.");
                Stopwatcher.Stop();
            }
        }

        public void TestMethods<TInput>(TInput input, params Predicate<TInput>[] methods)
        {
            int methodsCount = methods.Length;
            for (int i=0; i<methodsCount; i++)
            {
                Stopwatcher.Start();
                Console.WriteLine($"\nMethod {methods[i].Method.Name} returned: {methods[i].Invoke(input)}.");
                Stopwatcher.Stop();
            }
        }
    }
}
