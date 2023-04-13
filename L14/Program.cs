namespace SumOfTheMainDiagonalOfA2DArray
{
    class Program
    {
        static void Main()
        {
            int row, col;
            Console.Write("Enter rows: ");
            row = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter rows: ");
            col = int.Parse(Console.ReadLine() ?? "0");
            double[,] a = new double[row, col];
            double sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    a[i, j] = double.Parse(Console.ReadLine() ?? "0");
                    if(i == j){
                        sum += a[i,j];
                    }
                }

            }
            Console.WriteLine("Sum of the main diagonal of a 2D array: " + sum);
        }
    }
}