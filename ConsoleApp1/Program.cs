using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { };
            Console.WriteLine(isOnionArray(arr) + "\n");
        }

        private static int isOnionArray(int[] a)
        {
            if (a.Length == 0) return 1;
            if (a.Length == 1 && a[0] < 10) return 1;

            for (int j = 0, k = a.Length - 1; j <= k; j++, k--)
            {
                if (a[j] + a[k] > 10)
                    return 0;

            }

            return 1;
        }
    }
}