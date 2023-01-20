// Написать программу которая на вход принимает число (n), ф на выходе показывает все четные числа от 1 до n.

Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n; i+=2)
{
    Console.WriteLine($"{i}" );
}
