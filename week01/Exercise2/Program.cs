using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);
        int lastdigit = percent % 10;
        int firstdigit = percent / 10;
        string letter = "";
        string sign = "";
        if (percent>=90 )
        {
           letter= "A";
        }
        else if (percent>=80)
        {
            letter= "B";
        }
        else if (percent>=70)
        {
            letter= "C";
        }
        else if (percent>=60)
        {
            letter= "D";
        }
        else
        {
            letter= "F";
        }

        if (lastdigit>=7 && firstdigit>=6)
        {
            sign = "+";
        }
        else if (lastdigit<3 && firstdigit>=6)
        {
            sign = "-";
        }
        if (lastdigit>=7 && firstdigit>=9 || percent == 100)
        {
            sign = "";
        }
        
            
        Console.WriteLine($"Your grade is: {letter}{sign}");  

        if (percent>=70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


    }
}