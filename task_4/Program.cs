// Возведите число А в натуральную степень B используя цикл


Console.WriteLine("Введите число A: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень, в которую хотите возвести число A: ");
int numberDegree = int.Parse(Console.ReadLine() ?? "0");
int newNumber = 1;

int degree = 1;

while(degree <= numberDegree)

{
    newNumber = newNumber * number;
    degree++;
}
 
Console.WriteLine($"Число {number} в степени {numberDegree} равно {newNumber}");








































/*Console.WriteLine("Введите число A: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите степень, в которую хотите возвести число A: ");
int numberDegree = int.Parse(Console.ReadLine() ?? "0");

for (int degree = 1; degree <= numberDegree; degree++)
{
    Console.WriteLine(Math.Pow(number, degree));
}
*/
