namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] chessArray = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    chessArray[i, j] = (i + j) % 2 == 0 ? 1 : 0;
                    Console.Write("{0,4}",chessArray[i, j]);
                }
                Console.WriteLine();
            }
    
        }
    }
}
