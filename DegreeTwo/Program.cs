using System;

namespace DegreeTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int minRandomValue = 1;
            int maxRandomValue = 31;
            int randomValue = random.Next(minRandomValue, maxRandomValue);

            int degree = 1;
            int numberForDegree = 2;
            int multiplier = 2;

            while (numberForDegree < randomValue)
            {
                numberForDegree *= multiplier;
                degree++;
            }

            Console.WriteLine($"Дано случайное число {randomValue}, возводим число {multiplier} в степень {degree} и получаем {numberForDegree}");
        }
    }
}
