// // Задача 21

// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// // между ними в 3D пространстве.

// // A (3,6,8); B (2,1,-7), -> 15.84

// // A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string str)
{
    System.Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());
}


double Square(int x, int y)
{
    return Math.Pow((y - x), 2);
}


int X1 = InputNumber("Введите координату X1: ");
int Y1 = InputNumber("Введите координату Y1: ");
int Z1 = InputNumber("Введите координату Z1: ");

int X2 = InputNumber("Введите координату X2: ");
int Y2 = InputNumber("Введите координату Y2: ");
int Z2 = InputNumber("Введите координату Z2: ");

System.Console.WriteLine(Math.Round(Math.Pow((Square(X1, X2) + Square(Y1, Y2) + Square(Z1, Z2)), 0.5), 2));


// // System.Console.WriteLine(Math.Round(Math.Pow(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2),0.5),2));
