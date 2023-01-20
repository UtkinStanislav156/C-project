// Напишите программу которая на вход принимает число и выдает, является ли число четным.
// 4-> да
// -3-> нет
// 7-> нет

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
{
    Console.Write($"{n} да");
}
if (n % 2 == -1)
{
    Console.Write($"{-n} нет");
}
if (n % 2 == 1)
{
    Console.Write($"{n} нет");
}