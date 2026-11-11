using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random newNumber = new Random();
        int randomNumber = newNumber.Next(1, 100);

        Console.Write("Please enter a number to check:");
        int userNumber = int.Parse(Console.ReadLine());

        while (randomNumber != userNumber)
        {

            if (userNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }

            Console.Write("Please enter a number to check:");
            userNumber = int.Parse(Console.ReadLine());
        }
        {
            Console.WriteLine("Congratulations! You guessed it!");
        }
    }
}