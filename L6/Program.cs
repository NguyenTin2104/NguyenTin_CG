using System;
namespace L6
{
    class ConvertNumbersToWords
    {
        static void Main()
        {
            Console.Write("Enter a non-negative integer up to 3 digits: ");
            int n = int.Parse((Console.ReadLine() ?? "0"));
            if (n >= 100 && n <= 999)
            {
                int hundred = n / 100;
                int tens = (n % 100) / 10;
                int ones = n % 10;
                Console.Write(GetTextNumber(hundred) + " hundred ");
                if (tens == 0 && ones == 0)
                {
                    Console.WriteLine();
                }
                else if (tens == 0)
                {
                    Console.Write("and " + GetTextNumber(ones));
                }
                else if (tens == 1)
                {
                    Console.WriteLine(" and " + GetTextNumber(10 + ones));
                }
                else
                {
                    Console.Write(" and " + GetTextNumber(tens * 10));
                    if (ones != 0)
                    {
                        Console.Write(" " + GetTextNumber(ones));
                    }
                    Console.WriteLine();    
                }
            }
            else if(n >= 10 && n <= 99)
            {
                int tens = (n % 100) / 10;//17 % 1
                int ones = n % 10;
                if(n >= 10 && n <= 19)
                {
                    Console.WriteLine(GetTextNumber(ones + 10));
                }
                else
                {
                    Console.Write(GetTextNumber(tens*10));
                    if(ones != 0)
                    {
                        Console.WriteLine(" " + GetTextNumber(ones));
                    }
                }
            }
            else
            {
                Console.WriteLine(GetTextNumber(n));
            }
        }
    
    static string GetTextNumber(int number)
    {
        switch (number)
        {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            case 10:
                return "ten";
            case 11:
                return "eleven";
            case 12:
                return "twelve";
            case 13:
                return "thirteen";
            case 14:
                return "fourteen";
            case 15:
                return "fifteen";
            case 16:
                return "sixteen";
            case 17:
                return "seventeen";
            case 18:
                return "eighteen";
            case 19:
                return "nineteen";
            case 20:
                return "twenty";
            case 30:
                return "thirty";
            case 40:
                return "forty";
            case 50:
                return "fifty";
            case 60:
                return "sixty";
            case 70:
                return "seventy";
            case 80:
                return "eighty";
            case 90:
                return "ninety";
            default:
                return "";
        }
    }
}
}

