namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            for (int k = 0; k < 2; k++)
            {
                for (; i < 10; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                for (; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
