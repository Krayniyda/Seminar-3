Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и на выходе показывает является ли пятизначное число палиндромом.");
Console.Write("Введите пятизначное число :");
int n = 0;
while (n < 10000 || n > 99999)
{
    n = Convert.ToInt32(Console.ReadLine());    
}
if ((n / 10000 == n % 10) && ((n / 1000 - (n / 10000) * 10) == ((n % 100) - n % 10) / 10))
    Console.WriteLine("Это палиндром.");
else
    Console.WriteLine("Это не палиндром. ");

    