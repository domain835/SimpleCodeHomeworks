namespace Homework 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Средеее арифметическое
            /*            double firstValue, secondValue;

                        Console.WriteLine("Пожалуйста введите первое число:");
                        firstValue = double.Parse(Console.ReadLine());

                        Console.WriteLine("Пожалуйста введите второе число:");
                        secondValue = double.Parse(Console.ReadLine());

                        double result = (firstValue + secondValue) / 2;

                        Console.WriteLine("Среднее арифметическое = " + result);*/

            // Сумма и произведение трех чисел
            /* double firstValue, secondValue, thirdValue;

             Console.WriteLine("Пожалуйста введите первое число:");
             firstValue = double.Parse(Console.ReadLine());

             Console.WriteLine("Пожалуйста введите второе число:");
             secondValue = double.Parse(Console.ReadLine());

             Console.WriteLine("Пожалуйста введите второе число:");
             thirdValue = double.Parse(Console.ReadLine());

             double sum = (firstValue + secondValue + thirdValue);
             double prod = (firstValue * secondValue * thirdValue);

             Console.WriteLine("Сумма чсел = " + sum + " А их произведение = " + prod);*/

            // Конвертер валют
            double UsdToRub = 61.13;
            double UsdToEur = 0.99;
            double USD;

            Console.WriteLine("Пожалуйста введеите сумму в USD");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine("$" + USD + " в RUB = " + USD * UsdToRub + " руб");

            Console.WriteLine("$" + USD + " в EUR = $" + USD * UsdToEur);


        }
    }
}
