namespace Homework
{
    class Program
    {
        static string CreateString(string symbol, int count)
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
            

          /*  for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }*/

        }
    }
}