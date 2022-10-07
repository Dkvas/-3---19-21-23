// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

using static System.Console;
Clear();
WriteLine("Вводим число: ");
int num1 = Convert.ToInt32(ReadLine());
int count = 0;
while (num1 > 0) 
{
    count = count * 10 + num1 % 10;
    num1 /= 10;
}
int num2 = count;
if(num1 == num2)
{
    WriteLine($"Число {num1} палиандром.");
}
else
{
    WriteLine($"Число {num1} НЕ палиандром.");
}