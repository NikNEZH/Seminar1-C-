// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return numberA;
}

int numberA = Get("Введите первое число:");
int numberB = Get("Введите второе число:");

int result= numberA * numberA;


if (result == numberB )
{
    Console.WriteLine($"{numberB} является квадратом числа { numberA}");
}
else
{
    Console.WriteLine($"{numberB} не является квадратом числа { numberA} ");
}