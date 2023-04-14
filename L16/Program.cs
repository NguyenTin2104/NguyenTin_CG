namespace L16
{
    class Program
    {
        public void Count(string a, char x)
        {
            int count = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (x == a[i])
                    {
                        count++;
                    }
                }
                Console.Write($"Element {x} appears {count} times");
        }
        static void Main()
        {
            string a = "Hello CodeGymmm!";
            Console.Write("Enter the element to count the number of occurrences: ");
            char x = char.Parse(Console.ReadLine() ?? "\0");
            Program p = new Program(); 
            p.Count(a, x);
        }
    }
}