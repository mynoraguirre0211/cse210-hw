using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Please enter your grade percentage:");
        int grade = int.Parse(Console.ReadLine());

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        
            if (grade <= 93)
            {
                letter += "-";
            }
        }
        else if (grade >= 80)
        {
            letter = "B";
            if (grade >= 87)
            {
                letter += "+";
            }
            else if (grade <= 83)
            {
                letter += "-";
            }
        }
        else if (grade >= 70)
        {
            letter = "C";
            if (grade >= 77)
            {
                letter += "+";
            }
            else if (grade <= 73)
            {
                letter += "-";
            }
        }
        else if (grade >= 60)
        {
            letter = "D";
            if (grade >= 67)
            {
                letter += "+";
            }
            else if (grade <= 63)
            {
                letter += "-";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

            if (grade >= 70)
            {
                Console.WriteLine("You passed the course.");
            }
            else 
            {
                Console.WriteLine("You did not pass the course. Good luck next time!");
            }
    }
}