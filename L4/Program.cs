namespace L4
{
    class linearEquationResolver
    {
        static void Main()
        {
            float a, b;
            
            Console.WriteLine("Linear Equation Resolver");
            Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants:");
            Console.Write("Enter a: ");
            a = float.Parse((Console.ReadLine()) ?? "0");
            Console.Write("Enter b: ");
            b = float.Parse((Console.ReadLine()) ?? "0");
            double x = -b/a;
            if(a == 0)
            {
                if(b == 0)
                {
                    Console.WriteLine("Infinitely many solutions");
                }
                else
                {
                    Console.WriteLine("The equation has no solution");
                }
            }
            else
            {
                
                Console.Write("The solution is: {0}", x);
            }
        }
    }
}