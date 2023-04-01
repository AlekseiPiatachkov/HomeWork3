
/* Задача 23
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите целое число ");
int x = int.Parse(Console.ReadLine());

Console.Write($" {x} -> ");
for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
        int b = i * i * i;
        Console.Write(b);
        break;
    }
    int result = i * i * i;
    Console.Write(result + ", ");
}