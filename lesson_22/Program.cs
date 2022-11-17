namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пожалуйста введитевысоту треуголника");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = height; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            /* Back arrow */

            for (int i = 0; i < height; i++)
            {
                for (int j = height - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = height; j > i; j--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
