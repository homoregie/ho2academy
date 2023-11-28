using FibonacciGen.Services;
using System.Runtime.CompilerServices;

//Display character to separate header and output body
void DisplaySectionSeperator()
{
    Console.WriteLine(new string('=', 40));
}

//Create instance of fibonacci generator 
var generator = new FibonacciGenerator();

//Generate 15 numbers
Console.WriteLine("Output of 15 fibonacci numbers");
DisplaySectionSeperator();
foreach (var digit in generator.Generate(30))
{
    Console.WriteLine(digit);
}

DisplaySectionSeperator();
Console.WriteLine("Program completed successfully");

