using System;

class Program
{
    static void Main(string []args)
    {
        Console.Write("Input number of dices: ");
        int numberOfDices = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of faces: ");
        int numberOfFaces = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("--------------------");

        Random rnd = new Random();
        int total = 0;

        for (int i = 1; i <= numberOfDices;)
        {
            int dice = rnd.Next(0, numberOfFaces);
            if (dice > 0)
            {
                Console.WriteLine("Dice " + i + ": " + dice);
                i++;
                total += dice;
            }
        }

        Console.WriteLine("--------------------");
        Console.WriteLine("Total: " + total);

        Console.ReadLine();
    }
}