using System;
using System.Collections.Generic;

Console.Write("Enter a string: ");
string? input = Console.ReadLine();
Console.Write("Enter a String to reverse: ");
string? inputReverse = Console.ReadLine();

if (input == null)
{
    Console.WriteLine("No input provided to check Palindrome.");
    return;
}
if (inputReverse == null)
{
    Console.WriteLine("No input provided to reverse String.");
    return;
}
Console.WriteLine($"\nInput Palindrome: {input}");
bool result = IsPalindrome(input);

if (result)
    Console.WriteLine("Output: Palindrome ");
else
    Console.WriteLine("Output: Not a Palindrome ");

//To Reverse the string
List<char> resultReverse = Reverse(inputReverse);
foreach (char ch in resultReverse)
{
    Console.Write(ch);
}

static bool IsPalindrome(string strToMatched)
{
    Stack<char> stack = new Stack<char>();
    foreach (char ch in strToMatched)
    {
        stack.Push(ch);
    }

    foreach (char ch in strToMatched)
    {
        if (ch != stack.Pop())
        {
            return false;
        }
    }
    return true;
}
static List<char> Reverse(string strToReversed)
{
    Stack<char> stack = new Stack<char>();
    List<char> reverseStr = new List<char>();

    foreach (char ch in strToReversed)
    {
        stack.Push(ch);
    }
    while (stack.Count > 0)
    {
        reverseStr.Add(stack.Pop());
    }
    return reverseStr;
}