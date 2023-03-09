// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

int InputNumber()
{
    while (true)
    {
        try
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);
            if (number < 1)
            {
                throw new Exception();
            }

            return number;
        }
        catch (Exception e)
        {
            Console.WriteLine("Допустимые значения: число от 1 до ∞");
        }
    }
}

void ThirdPowTable(int number)
{
    Console.Write($"{number} -> ");    
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{(i > 1 ? ", " : "") + Math.Pow(i, 3)}");
    }
}

int number = InputNumber();
ThirdPowTable(number);
