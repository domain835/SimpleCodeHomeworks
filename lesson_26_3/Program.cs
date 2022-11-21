namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Найти сумму четных чисел в мвссиве */

            int sum = 0;

            Console.Write("Пожалуйста ведите количество элементов в массиве: ");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] array = new int[elementsCount];

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Пожалуйста введите элемент массива под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nСумма четных чисел: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    sum +=array[i];
            }

            Console.WriteLine(sum);
            Console.ReadLine();


        }
    }
}