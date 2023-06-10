// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n1 = 1;
void RoadFromN(int number, int n1)
{
if (n1 > number)
{
return;
}
RoadFromN(number, n1 + 1);
System.Console.Write($"{n1} ");

}

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadFromN(number, n1);