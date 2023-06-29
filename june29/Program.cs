internal class Program
{
    private static void Main(string[] args)
    {
        int n = 8;
        int[,] c = new int[n, n];
        int[,] b = new int[n, n];
        int[,] a = new int[n, n];

        // Initialize matrices a and b with values
        // (You can modify this part based on your requirements)
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[i, j] = i + 1;
                b[i, j] = j + 1;
            }
        }

        // Perform matrix multiplication
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                c[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    c[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        // Print the result matrix c
        Console.WriteLine("Result:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(c[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}