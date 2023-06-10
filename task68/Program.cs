// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Ackkerman(int n, int m)
{
if (n == 0)
{
return m + 1;
}
else if (m == 0)
{
return Ackkerman (n - 1, 1);
}
return Ackkerman(n - 1, Ackkerman (n, m - 1));
}

System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackkerman(n, m));