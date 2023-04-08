using System;

namespace L5
{
    class IBM
    {
        static void Main()
        {
            double height;
            double weight;
            Console.Write("Please enter your height: ");
            height = double.Parse((Console.ReadLine()) ?? "0");
            Console.Write("Please enter your weight: ");
            weight = double.Parse((Console.ReadLine()) ?? "0");
            double bmi = weight / Math.Pow(height, 2);
            bmi = Math.Round(bmi, 1);
            Console.Write("BMI: " + bmi);
            if (bmi < 18)
                Console.Write(" Underweight");
            else if (bmi < 25.0)
                Console.WriteLine(" Normal");
            else if (bmi < 30.0)
                Console.WriteLine(" Overweight");
            else
                Console.WriteLine(" Obese");
        }
    }
}
