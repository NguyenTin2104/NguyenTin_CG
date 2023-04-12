namespace L12
{
    class Program
    {
        static void Main()
        {
            int[] a = new int[5];
            int sum =0;
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine() ?? "0");
            }
            for (int i = 0; i < 5; i++)
            {
                sum += a[i];
            }
            Console.Write("Sum of array: " + sum);
        }
    }
}