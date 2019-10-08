<Query Kind="Statements" />

var lstNames = new List<string> { "A", "B", "A" };

if (lstNames.Distinct().Count() != lstNames.Count())
{
    Console.WriteLine("List contains duplicate values.");
}