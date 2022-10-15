Console.WriteLine("Ввудите число чтобы получить его в квадрате");
string numberAStr = Console.ReadLine() ?? ""; 
string numberBStr = Console.ReadLine() ?? ""; 
int numberA = int.Parse(numberAStr); 
int numberB = int.Parse(numberBStr);
int kvadrat = numberA * numberA; 
if (kvadrat == numberB)
{
    Console.WriteLine($"Результат числа {numberA} равен { numberB}");
    
} else
{
    Console.WriteLine($"Результат числа {numberA} не равен { numberB}");
}

