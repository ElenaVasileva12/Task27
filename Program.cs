// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num)
{
    int digit=0;
    int i=0;
    while (i<num)
    {
        digit=digit+num%10;
        num=num/10;
        i++;
    }
    return digit;
}


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumDigit(number));