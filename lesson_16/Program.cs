namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue;

            int amountOfEvenNumbers = 0;
            int amountOfOddNumbers = 0;

            int sumOfEvenNumbers = 0;
            int sumOfOddNumbers = 0;

            Console.WriteLine("Пожалуйста ведите первое число диапазона");
            firstValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Пожалуйста ведите второе число диапазона");
            secondValue = int.Parse(Console.ReadLine());

            while (firstValue <= secondValue)
            {
                if (firstValue % 2 == 0)
                {
                    amountOfEvenNumbers++;
                    sumOfEvenNumbers = sumOfEvenNumbers + firstValue;
                }

                else
                {
                    amountOfOddNumbers++;
                    sumOfOddNumbers += firstValue;
                }
                    
                firstValue++;
            }

            Console.WriteLine("Количество четных чисел в диапазоне:" + amountOfEvenNumbers);
            Console.WriteLine("Количество не четных чисел в диапазоне:" + amountOfOddNumbers);

            Console.WriteLine("Сумма четных чисел в диапазоне:" + sumOfEvenNumbers);
            Console.WriteLine("Сумма не четных чисел в диапазоне:" + sumOfOddNumbers);

            Console.ReadLine();
        }            
    }
}