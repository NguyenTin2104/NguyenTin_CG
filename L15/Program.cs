namespace DeleteElementOfArray
{
    class Program
    {
        public bool check(int[] a, int x)
        {
            for (int i = 0; i < 5; i++)
            {
                if (x == a[i])
                {
                    return true;
                }
            }
            return false;
        }
        public int index(int[] a, int x)
        {
            int index = 0;
            for (int i = 0; i < 5; i++)
            {
                if (x == a[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void D(int[] a, int x, bool flag)
        {
            int i = index(a, x);
            if (check(a, x))
            {
                for (; i < 4; i++)
                {
                    a[i] = a[i + 1];
                }
                a[4] = 0;
            }
            else
            {
                Console.WriteLine("Invalid element to be deleted!");
            }
        }
        public void PrintA(int[] a)
        {
            Console.Write("Array after deleted: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Main()
        {
            int[] a = { 5, 4, 2, 6, 1 };
            // int index = 0;
            bool flag = false;
            Console.Write("Enter the element to be deleted: ");
            int x = int.Parse(Console.ReadLine() ?? "0");
            Program p = new Program();
            p.check(a, x);
            p.D(a, x, flag);
            p.PrintA(a);


        }
    }
}