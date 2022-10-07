// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;
Clear();
WriteLine("Вводим координаты первой точки: ");
int x1 = Convert.ToInt32(ReadLine());
int y1 = Convert.ToInt32(ReadLine());
int z1 = Convert.ToInt32(ReadLine());
WriteLine("Вводим координаты второй точки: ");
int x2 = Convert.ToInt32(ReadLine());
int y2 = Convert.ToInt32(ReadLine());
int z2 = Convert.ToInt32(ReadLine());
double L = Math.Sqrt( Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
WriteLine($"Расстояние между точками в трёхмерном пространстве:{L}");