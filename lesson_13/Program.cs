namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Пожалуйста ведите число");

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Данное число четное");
            }
            else
            {
                Console.WriteLine("Данное число не четное");
            }

            
        }
    }
}
