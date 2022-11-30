namespace Homework
{
    class Program
    {
        static int GetIndex(int[] arr, int desired) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == desired)
                {
                    return i;
                }   
            }
            return -1;
        }

        /* Создание рандомного мвассива */

        static int[] CreateRandomArr(uint length, int startValue, int endValue) 
        {
            int[] arr = new int[length];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(startValue, endValue);
            }

            return arr;
        
        }
        static void Main(string[] args)
        {
            Console.Write("Пожалуйста введите число: ");
            int desired = int.Parse(Console.ReadLine());

            int[] arr = CreateRandomArr(20, -10, 10);

            Console.WriteLine("Сгенерированный массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            int result = GetIndex(arr, desired);

            if (result == -1)
                Console.WriteLine("\nЗаданное число в массиве не найдено");
            else
                Console.WriteLine("\nИндекс заданного числа в массиве: " + result);
        }
    }
}
