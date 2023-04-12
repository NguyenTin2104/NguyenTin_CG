using System;

namespace L11
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine() ?? "0");
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            Console.Write("Enter the element to be inserted: ");
            int x = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter the position the element to be inserted: ");
            int p = int.Parse(Console.ReadLine() ?? "0");
            p -= 1;
            int[] NewArr = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                if (i < p)
                {
                    NewArr[i] = arr[i];
                }
                else if (i == p)
                {
                    NewArr[i] = x;
                }
                else
                    NewArr[i] = arr[i - 1];

            }
            for (int i = 0; i < NewArr.Length; i++)
            {
                Console.Write(NewArr[i] + " ");
            }
        }
    }
}
