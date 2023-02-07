// Задача 21: Напишите программу, которая принимает
// на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Enter X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter Z2: ");
int z2 = int.Parse(Console.ReadLine()!);
double x3 = Math.Pow(x2 - x1, 2);
double y3 = Math.Pow(y2 - y1, 2);
double z3 = Math.Pow(z2 - z1, 2);
double distance = Math.Sqrt(x3 + y3 + z3);
Console.WriteLine($"The distance between two poits is {distance}");
