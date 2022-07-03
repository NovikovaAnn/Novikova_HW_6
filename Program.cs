//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
Console.Write(array[i] + " ");
}

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int[] Array1 = new int[n];
Console.WriteLine("Заполните массив");

for (int i = 0; i < n; i++)
{
    Array1[i] = Convert.ToInt32(Console.ReadLine());
    if (Array1[i] > 0)
    {
        sum = sum + 1;
    }

}
ShowArray (Array1);
Console.Write($" --> вы ввели {sum} положительных чисел");
*/
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());

void IntersectionPoint (int B1, int K1, int B2, int K2)
{
    if (k1 == k2 && b1 != B2)
    {
        Console.WriteLine ("Прямые не пересекаются");
    }
    else if (k1 == k2 && b1 == B2)
     {
        Console.WriteLine ("Прямые совпадают");
    }
    else
    {int x = (b2 - b1) / (k1 - k2);
    int y = x * k1 + b1;
    Console.WriteLine ($"Точка пересечения прямых = ({x}; {y})");
    }
}
IntersectionPoint (b1, k1, b2, k2);