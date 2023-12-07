/* Задайте произвольную строку. Выясните, является ли она палиндромом. */

using System;
public class Zadacha_03
{
public static void Main(string[] args)
    {
        string input = "Хоп Хей";
        string result = ReverseWords(input);
        Console.WriteLine(result);
    }
public static string ReverseWords(string str)
    {
        string[] words = str.Split(' ');
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}