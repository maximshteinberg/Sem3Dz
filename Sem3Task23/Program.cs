// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.Write("Введите число N: ");
// int n1 = Convert.ToInt32(Console.ReadLine());

// int index=1;
// while (index <= n1 ) 
// {
//     double result = Math.Pow(index,3);
//     System.Console.WriteLine($"Куб числа {index} = {result}");
//     index++;

// }





int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


void GetResult(int n1)
{
    int index = 1;
    while (index <= n1)
    {
        double result = Math.Pow(index, 3);
        System.Console.WriteLine($"Куб числа {index} = {result}");
        index++;

    }
}


int N = GetNumber("Введите число N: ");
GetResult(N);