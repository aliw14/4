namespace _4;
class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int sum = 0;

        int[] numbers = { 5, 7, 10, 15, 90 };
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 5 == 0)
            {
                sum += numbers[i];
                count++;
               
            }
        }
              Console.WriteLine(sum);
        Console.WriteLine(count);






    }
}

