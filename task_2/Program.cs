// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число n:");
int number = int.Parse(Console.ReadLine() ?? "0");
int n = 0;
for (int num = 1; num <= number; num++)
{
    n++;
    Console.WriteLine($"Куб числа {n} равен {Math.Pow(num,3)}");
}