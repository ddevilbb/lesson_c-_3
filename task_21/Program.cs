// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.WriteLine("Программа, которая принимает на вход координаты двух точек " +
                  "и находит расстояние между ними в 3D пространстве.");

double[] InputCoordinates(string name)
{
    while (true)
    {
        try
        {
            Console.Write($"Введите координаты точки {name}: ");
            double[] point = Console.ReadLine()?.Split(' ').Take(3).Select(double.Parse).ToArray()!;
            if (point.Length != 3)
            {
                throw new Exception();
            }
            
            return point;
        }
        catch (Exception e)
        {
            Console.WriteLine("Допустимые значение: дюбые три числа разделённые пробелом");
        }
    }
}

double CalculateLength(double[] a, double[] b)
{
    return Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2));
}

string ArrayToString(double[] point)
{
    return String.Join(", ", point);
}


double[] a = InputCoordinates("A");
double[] b = InputCoordinates("B");
Console.WriteLine($"A({ArrayToString(a)}); B({ArrayToString(b)}) -> {CalculateLength(a, b):f2}");
