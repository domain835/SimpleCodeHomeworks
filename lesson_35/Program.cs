namespace Homework
{
    class Program
    {
        /*        static string CreateString(string symbol, int count)
                {
                    string result = "";

                    for (int i = 0; i < count; i++)
                    {
                        result = result + symbol;
                    }

                    return result;
                }
                static void Main(string[] args)
                {

                    Console.Write("Пожалуйста введите символ: ");
                    string symbol = Console.ReadLine();

                    Console.Write("Пожалуйста введите количество: ");
                    int count = int.Parse(Console.ReadLine());

                    Console.WriteLine(CreateString(symbol, count));
                }*/

        /* Solution from Teacher */

        static void CreateString(char symbol, uint count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
        }

        static void Main(string[] args)
        {

            Console.Write("Пожалуйста введите символ: ");
            char symbol = Console.ReadKey().KeyChar;

            Console.Write("\nПожалуйста введите количество: ");
            uint count = uint.Parse(Console.ReadLine());

            CreateString(symbol, count);
        }
    }
}