// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Через строку решать нельзя.

Console.Clear();
Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

int InputNumber()
{
    while (true)
    {
        try
        {
            Console.Write("Введите пятизначное число: ");
            int number = int.Parse(Console.ReadLine()!);
            if (number is < 10000 or > 99999)
            {
                throw new Exception("Допустимые значения: любое пятизначное число");
            }

            return number;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}

bool IsPalindrome(int number)
{
    return number / 10000 == number % 10
           && number / 1000 % 10 == number / 10 % 10;
}


int number = InputNumber();
Console.WriteLine("{0} -> {1}",number,IsPalindrome(number) ? "Да" : "Нет");
