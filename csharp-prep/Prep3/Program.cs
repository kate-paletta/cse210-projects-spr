using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);

        Console.Write($"The magic number is: {magicNum}");
    }
}