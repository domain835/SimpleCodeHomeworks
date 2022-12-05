namespace Homework
{
    class Program
    {
        static void ResizeArray(ref int[] array, int size)
        {
            int[] newArray = new int[size];

            for (int i = 0; i < array.Length && i < newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        static void Main(string[] args)
        {
            
            int[] arr = {2, 56, 32, 88 };

            Console.WriteLine("Изходный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n\nПожалйста введите желаемый размер массива: ");
            int size = int.Parse(Console.ReadLine());

            ResizeArray(ref arr, size);

            Console.WriteLine("\nИтоговый массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
