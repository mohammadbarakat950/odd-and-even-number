using System;
class patternRecognitionexample
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number}is even.");
            }
            else
            {
                Console.WriteLine($"{number}is odd.");
            }
        }
    }
}