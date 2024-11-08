using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hi");
        Console.Write("How many times do you want to eat?:");
        int loopcounter = Convert.ToInt32(Console.ReadLine());

        if (loopcounter <= 0)
        {
            Console.WriteLine("sorry,please enter a value above 0");
        }
        else //>= 1
        {
            for (int i = 0; i < loopcounter; i++)
            {
                Console.WriteLine("Hi");
            }
        }
    }
}