using System;
namespace Hello{
    class Program{
        static void Main(){
            Console.Write("Enter your name: ");
            string name = Console.ReadLine() ?? "0";
            Console.WriteLine("Hello: " + name);

        }
    }
}