using System;
namespace L9{
    class Program{
        static void Main(){
            Console.Write("Enter n: ");
            int n;
            n = int.Parse((Console.ReadLine()) ?? "\0");
            int key = n - 1;
            bool flag = false;
            while(n >= 2){
                if(key == 1){
                    flag = true;
                    break;
                }
                if(n == 2){
                    flag = true;
                    break;
                }
                if(n % key == 0){
                    flag = false;
                    break;
                }
                else{
                    key--;
                }
                
            }
            if(flag){
                Console.Write($"{n} is prime number!");
            }
            else{
                Console.Write($"{n} is not prime number!");
            }
        }
    }
}