namespace L7
{
    class Menu
    {
        static void Main()
        {
            int length = 5, width = 5;
            int n, current;
            do
            {
                Console.WriteLine("==================================");
                Console.WriteLine("1. Print the rectangle.");
                Console.WriteLine("2. Print the square triangle.");
                Console.WriteLine("3. Print isosceles triangle.");
                Console.WriteLine("0. Exit.");
                Console.Write("Enter choice: ");
                n = int.Parse((Console.ReadLine() ?? "\0"));
                Console.WriteLine("==================================");
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("1. Print the rectangle.");
                            for (int i = 0; i < length; i++)
                            {
                                for (int j = 1; j <= width; j++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            current = 2;
                            do
                            {
                                Console.WriteLine("1. Print the triangle top-left.");
                                Console.WriteLine("2. Print the triangle top-right.");
                                Console.WriteLine("3. Print the triangle bottom-left.");
                                Console.WriteLine("4. Print the triangle bottom-right.");
                                Console.WriteLine("0. Exit.");
                                Console.Write("Enter choice: ");
                                n = int.Parse((Console.ReadLine() ?? "\0"));
                                switch (n)
                                {
                                    case 1:
                                        {
                                            Console.WriteLine("1. Print the triangle top-left.");
                                            for (int i = 0; i < length; i++)
                                            {
                                                for (int j = 0; j < width - i; j++)
                                                {
                                                    Console.Write("* ");
                                                }
                                                Console.WriteLine();
                                            }
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("2. Print the triangle top-right.");
                                            for (int i = 0; i < length; i++)
                                            {
                                                for (int j = 0; j < i; j++)
                                                {
                                                    Console.Write("  ");
                                                }
                                                for (int k = width - i; k > 0; k--)
                                                {
                                                    Console.Write(" *");
                                                }
                                                Console.WriteLine();
                                            }
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.WriteLine("3. Print the triangle bottom-left.");
                                            for (int i = 0; i < length; i++)
                                            {
                                                for (int j = 0; j < i + 1; j++)
                                                {
                                                    Console.Write("* ");
                                                }
                                                Console.WriteLine();
                                            }
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("4. Print the triangle bottom-right.");
                                            for (int i = 0; i < length; i++)
                                            {
                                                for (int j = width - i; j > 0; j--)
                                                {
                                                    Console.Write("  ");
                                                }
                                                for (int k = 0; k < i + 1; k++)
                                                {
                                                    Console.Write(" *");
                                                }
                                                Console.WriteLine();
                                            }
                                            break;
                                        }
                                    case 0:
                                        {

                                            break;
                                        }
                                }
                                current = 0;
                            }
                            while (current == 2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("3. Print isosceles triangle.");
                            for (int i = 0; i < length; i++)
                            {
                                for (int j = width - i; j > 0; j--)
                                {
                                    Console.Write("  ");
                                }
                                for (int k = 0; k < i * 2 + 1; k++)
                                {
                                    Console.Write("* ");
                                }
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please select again.");
                        break;
                }
            }
            while (n != 0);
        }
    }
}