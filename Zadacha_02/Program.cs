/* Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на 
строчные. */

using System;
public class Zadacha_02
{
    public static void Main(string[] args)
    {
        string input = "AbCdEfGhIjK";
        string result = input.ToLower();
        Console.WriteLine(result);
    }
}