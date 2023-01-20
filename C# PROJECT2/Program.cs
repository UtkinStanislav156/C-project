// Написать программу которая принимает на вход три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22


Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
if (num2 < num3)
{
  Console.WriteLine("num3 максимальное число");  
}
if (num1 > num2)
if (num1 > num3)
{
 Console.WriteLine("num1 максимальное число");   
}
if (num1 > num2)
if (num1 < num3)
{
 Console.WriteLine("num3 максимальное число");   
}
{
    
}    
