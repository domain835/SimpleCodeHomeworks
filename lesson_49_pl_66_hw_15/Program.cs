namespace Homework
{
    class Program
    {
        static void myFunc(int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                myFunc(array, i + 1);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 2, 56, 32, 88 };

            myFunc(myArray);
        }
    }
}

