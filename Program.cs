/*
 * Author:Fatima Oronia
 * Course:COMP-003A
 * Purpose:Assignment 5
 */







using System;

class Program
{
    static void Main(string[] args)
    {
        PrintSeparator();
        Console.WriteLine("Triangle");
        Console.WriteLine("Enter a single character:");
        char inputCharacter = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter a positive whole number:");
        int size = Convert.ToInt32(Console.ReadLine());
        IsoscelesTriangleBuilder(inputCharacter, size);
        PrintSeparator();
        Console.WriteLine("Favorite Characters");
        CharacterInfo("Spider-Man", 1962);
        CharacterInfo("Batman", 1939);
        CharacterInfo("Superman", 1938);
        CharacterInfo("Wonder Woman", 1941);
        CharacterInfo("Iron Man", 1963);
    }

    /// <summary>
    /// Outputs 50 asterisks to the console.
    /// </summary>
    static void PrintSeparator()
    {
        Console.WriteLine(new string('*', 50));
    }

    /// <summary>
    /// Outputs a separator followed by the provided string.
    /// </summary>
    /// <param name="separator">The separator string.</param>
    static void PrintSeparator(string separator)
    {
        Console.WriteLine(new string('-', 50));
        Console.WriteLine(separator);
    }

    /// <summary>
    /// Builds an isosceles triangle using the provided character and size.
    /// </summary>
    /// <param name="inputCharacter">The character to build the triangle with.</param>
    /// <param name="size">The size of the triangle.</param>
    static void IsoscelesTriangleBuilder(char inputCharacter, int size)
    {
        Console.WriteLine("Building triangle:");
        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine(new string(inputCharacter, i));
        }
        for (int i = size - 1; i >= 1; i--)
        {
            Console.WriteLine(new string(inputCharacter, i));
        }
    }

    /// <summary>
    /// Calculates the age based on the provided year.
    /// </summary>
    /// <param name="year">The year of birth.</param>
    /// <returns>The calculated age.</returns>
    static int AgeCalculator(int year)
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - year;
    }

    /// <summary>
    /// Outputs the name and age of a character based on the provided birth year.
    /// </summary>
    /// <param name="name">The name of the character.</param>
    /// <param name="birthYear">The birth year or year of first appearance.</param>
    static void CharacterInfo(string name, int birthYear)
    {
        int age = AgeCalculator(birthYear);
        Console.WriteLine($"{name} is {age} years old.");
    }
}

