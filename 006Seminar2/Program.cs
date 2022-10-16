Random rnd = new Random();
int number = rnd.Next(10, 100); 

int firstDigit = number/10; 
int secondDigit = number%10;

if (firstDigit > secondDigit )
{
    Console.WriteLine($"{firstDigit} самое большое");
} 
else if (secondDigit > firstDigit)
{
    Console.WriteLine($"{secondDigit} самое большое");
}
else Console.WriteLine("Они равны чел");