//                     Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите х для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z для первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z для второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int X = x2 - x1;
int Y = y2 - y1;
int Z = z2 - z1;

double length = Math.Sqrt(X * X + Y * Y + Z * Z);
Console.WriteLine($"Расстояние = {length}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}