Console.WriteLine("Ввудите 3-x значное число чтобы получить его последнию цифру");
string numberSTR = Console.ReadLine() ?? ""; 
int newNumber = int.Parse(numberSTR );
int result = newNumber % 10;
if (newNumber > 99 && newNumber < 1000) 
{
    
    Console.WriteLine($"Последня цифра 3-х значного числа {result}");
} 
else if (newNumber > -99 && newNumber < -1000)
{
    Console.WriteLine("Что то не то");
}
