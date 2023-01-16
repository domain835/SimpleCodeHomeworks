namespace Homework
{
    class Program
    {
        /* Adding value by index */
        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];

            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }

        /* Adding value to start array */
        static void AddFirst(ref int[] arr, int value)
        {
            Insert(ref arr, value, 0);
        }

        /* Adding value to end array */
        static void AddLast(ref int[] arr, int value)
        {
            Insert(ref arr, value, arr.Length);
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 56, 32, 88 };

            AddFirst(ref arr, -5);
        }
    }
}