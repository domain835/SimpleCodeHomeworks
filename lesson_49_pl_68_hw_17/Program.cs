namespace Homework
{
    class Program
    {
        static int CreateSum(int number)
        {
            //if (number < 10)
            //    return number;

            //int lastDigit = number % 10;

            //int remainingNumber = number / 10;

            //return lastDigit + CreateSum(remainingNumber);

            /* Loop soluion */

            int result = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }

            return result;

        }
        static void Main(string[] args)
        {
            int number = 735;

            int result = CreateSum(number);
        }
    }
}
