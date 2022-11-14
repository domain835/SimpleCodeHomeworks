namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue;

            int amountOfEvenNumbers = 0;
            int amountOfOddNumbers = 0;

            Console.WriteLine("Рожалуйста ведите первое число диапазона");
            firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Рожалуйста ведите второе число диапазона");
            secondValue = int.Parse(Console.ReadLine());

            while (firstValue < secondValue)
            {
                if (firstValue % 2 == 0)
                    amountOfEvenNumbers++;
                else
                    amountOfOddNumbers++;
                firstValue++;
            }

            Console.WriteLine("Количество четных чисел в диапазоне:" + amountOfEvenNumbers);
            Console.WriteLine("Количество не четных чисел в диапазоне:" + amountOfOddNumbers);
        }            
    }
}