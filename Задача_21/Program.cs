// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты X, Y и Z для точки A и точки B, программа посчитает растояние между ними");
Console.WriteLine("Введите координаты Ax");
double ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Ay");
double ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Az");
double az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Bx");
double bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты By");
double by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Bz");
double bz = Convert.ToInt32(Console.ReadLine());

double Distance = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
Console.WriteLine($"Длина отрезка AB {Distance}");











