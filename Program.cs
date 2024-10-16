using System;

public class Program{
    public static string name;
    public static int age;
    public static string eyeColor;
    public static string hairColor;
    public static int shoeSize;
    public static string favColor;
    public static string favShow;
    public static string favTeacher;
    public static string favClass;
    public static string favHoliday;
    public static string favSeason;
    public static string dreamJob;
    public static string havSibs;
    public static int age5;


    public static void Main(string[] args)
    {
        Console.WriteLine("Whats your name?");
        name = Console.ReadLine();

        Console.WriteLine("Whats your age?");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine("Whats your eye color?");
        eyeColor = Console.ReadLine();

        Console.WriteLine("Whats your hair color?");
        hairColor = Console.ReadLine();

        Console.WriteLine("Whats your shoe size?");
        shoeSize = int.Parse(Console.ReadLine());

        Console.WriteLine("Whats your favorite color?");
        favColor = Console.ReadLine();

        Console.WriteLine("Whats your favorite tv show?");
        favShow = Console.ReadLine();

        Console.WriteLine("Who's your favorite teacher?");
        favTeacher = Console.ReadLine();

        Console.WriteLine("Whats your favorite class?");
        favClass = Console.ReadLine();

        Console.WriteLine("Whats your favorite holiday?");
        favHoliday = Console.ReadLine();

        Console.WriteLine("Whats your favorite season?");
        favSeason = Console.ReadLine();

        Console.WriteLine("Whats your dream job?");
        dreamJob = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years()
    {
        age5 = age + 5;
    }
    public static void AskNumberOfSiblings()
    {
        Console.WriteLine("How many siblings do you have?");
        int haveSiblings = int.Parse(Console.ReadLine());
        havSibs = "";
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
    }
    public static void DisplaySummmaryMessage()
    {
        Console.WriteLine("My friends name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + " and " + name + "'s hair color is " + hairColor + ". "
         + name + "'s  shoe size is " + shoeSize + " and thier favorite color is " + favColor + ".\n " + name + "'s favorite TV show is " + favShow + " and thier favorite teacher is " + favTeacher + ". " 
         + name + "'s favorite class is " + favClass + " and thier the holiday they like the most is " + favHoliday + ". " + name + "'s favorite season is " + favSeason + ". " + 
         name + "'s dream job is " + dreamJob + ".\n " + name + " will be " + age5 + " years old in 5 years. " + name + " " + havSibs + " .");
    }
}