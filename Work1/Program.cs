/* Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53

AB = √((xb - xa)2 + (yb - ya)2)
AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
*/


Console.Write("Введите первую координату x: ");
int xa = int.Parse(Console.ReadLine());

Console.Write("Введите первую координату y: ");
int ya = int.Parse(Console.ReadLine());

Console.Write("Введите первую координату z: ");
int za = int.Parse(Console.ReadLine());

Console.Write("Введите вторую координату x: ");
int xb = int.Parse(Console.ReadLine());

Console.Write("Введите вторую координату y: ");
int yb = int.Parse(Console.ReadLine());

Console.Write("Введите вторую координату z: ");
int zb = int.Parse(Console.ReadLine());

double result = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
 
Console.Write($"Координаты -> {result}");
