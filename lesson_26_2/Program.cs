namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Вывод массива в обратном порядке */

            Console.Write("Пожалуйста ведите количество элементов в массиве: ");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] array = new int[elementsCount];

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Пожалуйста введите элемент массива под индексом {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nВывод массива: ");

            for (int i = array.Length - 1; i > 0; i--)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();


        }
    }
}