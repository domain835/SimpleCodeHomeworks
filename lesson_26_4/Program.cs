namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Найти наименьшее число в массиве */

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

            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (minValue > array[i])
                    minValue = array[i];
            }

            Console.WriteLine(minValue);
            Console.ReadLine();


        }
    }
}