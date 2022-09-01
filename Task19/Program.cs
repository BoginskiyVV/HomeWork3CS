// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
bool number = int.TryParse(Console.ReadLine(), out int N);

bool IsValidate(bool number)
{
    if (number != true)
    {
        Console.WriteLine("Некорректное число");
        return false;
    }
    if (N < -9999 && N > -99999)
    {
        int minus = N * -1;
        return true;