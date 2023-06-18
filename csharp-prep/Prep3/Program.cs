using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);

        // Console.Write($"The magic number is: {magicNum}");
        int userNum = -1;
        int guessNum = 0;

        while (magicNum != userNum)
        {
            Console.Write("What is your guess? ");
            userNum = int.Parse(Console.ReadLine());
            guessNum++;

            if (magicNum > userNum)
            {
                Console.WriteLine("Higher");
            }
            else if (userNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! the magic number was {magicNum}");
                Console.Write($"You guessed {guessNum} time(s)");
            }
        }
    }
}