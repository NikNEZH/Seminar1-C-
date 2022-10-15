// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


Console.WriteLine("Ввудите число чтобы получить день недели");
string numberAStr = Console.ReadLine() ?? ""; 
int dayNumber = int.Parse(numberAStr); 
 
if (dayNumber == 1){Console.WriteLine("Это понедельник братан");}  
if (dayNumber == 2){Console.WriteLine("Это вторник братан");} 
if (dayNumber == 3){Console.WriteLine("Это среда братан");} 
if (dayNumber == 4){Console.WriteLine("Это четверг братан");} 
if (dayNumber == 5){Console.WriteLine("Это пятница братан");} 
if (dayNumber == 6){Console.WriteLine("Это суббота братан");} 
if (dayNumber == 7){Console.WriteLine("Это воскресенье братан");} 
else
{
    Console.WriteLine("Это не та цфра мужик");
}