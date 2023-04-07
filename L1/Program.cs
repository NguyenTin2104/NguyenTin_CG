using System;
namespace L1{
    class Program{
        static void Main(){
        float width, height;
        Console.Write("Enter width: ");
        width = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        height = float.Parse(Console.ReadLine());
        Console.WriteLine("Area is: " + (width*height));
        }
    }
}