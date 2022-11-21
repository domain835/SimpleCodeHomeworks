namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Найти наименьшее число в массиве */

            int result = 0;

            Console.Write("Пожалуйста ведите количество элементов в массиве: ");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] array = new int[elementsCount];

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Пожалуйста введите элемент массива под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nНаименьшее число в массиве: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (result > array[i] || result <= 0)
                    result = array[i];
            }

            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}