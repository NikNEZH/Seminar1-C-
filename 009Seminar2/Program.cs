// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

int Get(string message)
{
    Console.WriteLine(message);
    string numberAStr = Console.ReadLine();
    int numberA = Convert.ToInt32(numberAStr);
    return numberA;
}

int numberA = Get("Введите первое число:");

int resultOne = numberA % 7;
int resultTwo = numberA % 23;

if (resultOne == 0 && resultTwo ==0)
{
    Console.WriteLine($"{numberA} кратно 7 and 23");
}
else
{
    Console.WriteLine($"{numberA} не кратно ");
}