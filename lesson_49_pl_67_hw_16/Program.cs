namespace Homework
{
    class Program
    {
        static int Sum(int[] array, int i = 0)
        {
            if (i >= array.Length)
               return 0;

            int result = Sum(array, i + 1);

            return array[i] + result;
        }
        static void Main(string[] args)
        {
            int[] myArray = {2, 3, 1};

            int result = Sum(myArray);
        }
    }
}