Console.WriteLine("Ввудите число чтобы получить его в квадрате");
string numberStr = Console.ReadLine() ?? ""; 
int number = int.Parse(numberStr); 
int result = number * number; 
Console.WriteLine($"Результат числа {number} равен { result}");