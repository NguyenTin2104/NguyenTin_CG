namespace L3{
    class Program{
        const float VND = 23000; 
        static void Main(){
            double USD;
            Console.Write("Enter USD: ");
            USD = float.Parse((Console.ReadLine()) ?? "0");
            Console.WriteLine($"{USD} USD = {USD * VND} VND");
            
        }
    }
}