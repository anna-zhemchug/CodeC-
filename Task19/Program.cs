// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int a = num / 1000;
int b = num % 100;
if (a / 10 == num % 10 && a % 10 == b / 10)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}