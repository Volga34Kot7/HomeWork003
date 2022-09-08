// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Numbers(int number)
{
    while (number > 99999 || number <= 9999)
    {
        Console.WriteLine("Ввели не верное число: ");
        Console.Write("Ввести пятизначное число: ");
        number = Convert.ToInt32(Console.ReadLine());
    }
    int num1 = number % 10;
    int num2 = number / 10 % 10;
    int num4 = number / 1000 % 10;
    int num5 = number / 10000 % 10;
    if (num1 == num5)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else Console.WriteLine("Число не является палиндромом");
    }
    else Console.WriteLine("Число не является палиндромом");

}
Console.Write("Ввести пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Numbers(number);