/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.WriteLine("Введите координату х точки А: ");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y точки А: ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z точки А: ");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату х точки B: ");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
int zb = int.Parse(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance:f2}");