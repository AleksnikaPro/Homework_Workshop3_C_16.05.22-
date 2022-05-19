// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число A: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень, в которую хотите возвести число A: ");
int numberDegree = int.Parse(Console.ReadLine() ?? "0");

for (int degree = 1; degree <= numberDegree; degree++)
{
    Console.WriteLine(Math.Pow(number, degree));
}
