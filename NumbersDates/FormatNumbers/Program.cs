﻿// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting numerical data in .NET

int[] quarters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
 //General format is {index[,alignment]:[format]}
 //Common types are N (Number), G (General), F (Fixed - point),
 //E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
 //C (Currency in local format)


// TODO: Add a number after the format to specify precision
Console.WriteLine($"{val1:D6}, {val2:N2}, {val1:F1}, {val1:G3} ");

// TODO: Formatting with alignment and spacing
 Console.WriteLine("Sales by Quarter:");
 Console.WriteLine($"{quarters[0]} {quarters[1]} {quarters[2]} {quarters[3]}");
 Console.WriteLine($"{sales[0]} {sales[1]} {sales[2]} {sales[3]}");
 Console.WriteLine("International Sales:");
 Console.WriteLine($"{intlMixPct[0]} {intlMixPct[1]} {intlMixPct[2]} {intlMixPct[3]}");