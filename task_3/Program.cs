// Найти сумму чисел от 1 до А

Console.WriteLine("Введите число A:");
int number = int.Parse(Console.ReadLine() ?? "0");
int sum = 0;
for (int num = 1; num <= number; num++)
{
    sum = sum + num;
}
Console.WriteLine($"Cумма чисел от 1 до {number} равна {sum} ");
