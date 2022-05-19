// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine() ?? "0");

int lastDigit = number % 10;
if(lastDigit % 2 == 0)
{
    Console.WriteLine("Введенное Вами число заканчивается на чётную цифру и его можно возвести в куб");
    Console.WriteLine(Math.Pow(number,3));
}
else
{
    Console.WriteLine("Введенное Вами число не заканчивается на чётную цифру, поэтому возводить его в куб не будем");
}

