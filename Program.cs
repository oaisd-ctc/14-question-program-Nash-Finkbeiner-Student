using System;

public class Program{

    public static void Main(string[] args)
    {
        Console.WriteLine("Whats your name?");
        string name = Console.ReadLine();

        Console.WriteLine("Whats your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Whats your eye color?");
        string eyeColor = Console.ReadLine();

        Console.WriteLine("Whats your hair color?");
        string hairColor = Console.ReadLine();

        Console.WriteLine("Whats your shoe size?");
        int shoeSize = int.Parse(Console.ReadLine());

        Console.WriteLine("Whats your favorite color?");
        string favColor = Console.ReadLine();

        Console.WriteLine("Whats your favorite tv show?");
        string favShow = Console.ReadLine();

        Console.WriteLine("Who's your favorite teacher?");
        string favTeacher = Console.ReadLine();

        Console.WriteLine("Whats your favorite class?");
        string favClass = Console.ReadLine();

        Console.WriteLine("Whats your favorite holiday?");
        string favHoliday = Console.ReadLine();

        Console.WriteLine("Whats your favorite season?");
        string favSeason = Console.ReadLine();

        Console.WriteLine("Whats your dream job?");
        string dreamJob = Console.ReadLine();

        Console.WriteLine("How many siblings do you have?");
        int haveSiblings = int.Parse(Console.ReadLine());
        string havSibs = "";
        if(haveSiblings = 1)
        {
            havSibs = " does have a sibling";
        }
        if else(haveSiblings > 1)
        {
            havSibs = " does have siblings";
        }
        else
        {
            havSibs = " doesn't have any siblings";
        }
       

        int age5 = age + 5;

        Console.WriteLine("My friends name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + " and " + name + "'s hair color is " + hairColor + ". "
         + name + "'s  shoe size is " + shoeSize + " and thier favorite color is " + favColor + ".\n " + name + "'s favorite TV show is " + favShow + " and thier favorite teacher is " + favTeacher + ". " 
         + name + "'s favorite class is " + favClass + " and thier the holiday they like the most is " + favHoliday + ". " + name + "'s favorite season is " + favSeason + ". " + 
         name + "'s dream job is " + dreamJob + ".\n " + name + " will be " + age5 + " years old in 5 years. " + name + " " + havSibs + " .");
    }
}