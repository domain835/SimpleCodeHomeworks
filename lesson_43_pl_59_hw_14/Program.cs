namespace Homework
{
    class Program
    {
        /* Remove value by index */
        static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index + 1; i < array.Length; i++)
                newArray[i - 1] = array[i];

            array = newArray;
        }

        /* Removing value to start array */
        static void RemoveFirst(ref int[] arr)
        {
            RemoveAt(ref arr, 0);
        }

        /* Removing value to end array */
        static void RemoveLast(ref int[] arr)
        {
            RemoveAt(ref arr, arr.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 56, 32, 88 };

            Console.WriteLine("Дан массив элементов:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("[" + i + "] = " + arr[i]);
            }

            Console.WriteLine("Элемент под каким индексом вы хотите удалить?");
            int index = int.Parse(Console.ReadLine());

            RemoveAt(ref arr, index);

            Console.WriteLine("Итоговый массив элементов:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("[" + i + "] = " + arr[i]);
            }
        }
    }
}
