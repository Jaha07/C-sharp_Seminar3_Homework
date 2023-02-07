// Задача 19: Напишите программу, которая принимает
// на вход пятизначное число и проверяет, является ли
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.WriteLine("Enter your number: ");
int number = int.Parse(Console.ReadLine()!);
int a = number / 10000;
int b = number / 1000 % 10;
int c = number / 10 % 10;
int d = number % 10;
if (a == d && b == c)
{
    Console.WriteLine($"Your number {number} is polymdrom");
}
else
{
    Console.WriteLine($"Your number {number} is not polyndrom");
}