namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                try
                {
                    Console.WriteLine("Рожалуйста ведите первое число");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Рожалуйста ведите второе число");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неизвестный операнд");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выберете операцию: '+', '-', '*', '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Ошибька! Неизвестное действие");
                        break;
                }

                Console.ReadLine();
            }


        }
    }
}