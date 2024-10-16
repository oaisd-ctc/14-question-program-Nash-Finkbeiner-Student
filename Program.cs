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
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years();
        AskNumberOfSiblings();
        DisplaySummmaryMessage();
    }
    public static void AskName()
    {
        Console.WriteLine("Whats your name?");
        name = Console.ReadLine();
    }
    public static void AskAge()
    {
        Console.WriteLine("Whats your age?");
        age = int.Parse(Console.ReadLine());
    }
    public static void AskEyeColor()
    {
        Console.WriteLine("Whats your eye color?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor()
    {
        Console.WriteLine("Whats your hair color?");
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize()
    {
        Console.WriteLine("Whats your shoe size?");
        shoeSize = int.Parse(Console.ReadLine());
    }
    public static void AskFavoriteColor()
    {
        Console.WriteLine("Whats your favorite color?");
        favColor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow()
    {
        Console.WriteLine("Whats your favorite tv show?");
        favShow = Console.ReadLine();
    }
    public static void AskFavoriteTeacher()
    {
        Console.WriteLine("Who's your favorite teacher?");
        favTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass()
    {
        Console.WriteLine("Whats your favorite class?");
        favClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday()
    {
        Console.WriteLine("Whats your favorite holiday?");
        favHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason()
    {
        Console.WriteLine("Whats your favorite season?");
        favSeason = Console.ReadLine();
    }
    public static void AskDreamJob()
    {
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
        havSibs = $"has haveSiblings sibling/siblings";
        
    }
    public static void DisplaySummmaryMessage()
    {
        Console.WriteLine("My friends name is " + name + ". " + name + " is " + age + " years old. " + name + "'s eye color is " + eyeColor + " and " + name + "'s hair color is " + hairColor + ". "
         + name + "'s  shoe size is " + shoeSize + " and thier favorite color is " + favColor + ".\n " + name + "'s favorite TV show is " + favShow + " and their favorite teacher is " + favTeacher + ". " 
         + name + "'s favorite class is " + favClass + " and their the holiday they like the most is " + favHoliday + ". " + name + "'s favorite season is " + favSeason + ". " + 
         name + "'s dream job is " + dreamJob + ".\n " + name + " will be " + age5 + " years old in 5 years. " + name + " " + havSibs + " .");
    }
}