// Показать таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число n:");
int number = int.Parse(Console.ReadLine() ?? "0");
for (int num = 1; num <= number; num++)
{
    Console.WriteLine(Math.Pow(num,2));
}
