using System;

class Program
{
    public static void Main(string[] args)
    {
        string firstname;
        int age;
        
        Console.WriteLine ("Enter first name:");
        firstname = Console.ReadLine();
        Console.WriteLine ("Enter age:");
        age = Convert.ToInt32(Console.ReadLine());
        if (age == 1)
        {
            Console.WriteLine ("Your first name is " + firstname + " and you are " + age + " year old.");
        }
        else 
        {
            Console.WriteLine ("Your first name is " + firstname + " and you are " + age + " years old.");
        }
        Console.WriteLine("\nFinished.");
    }
}