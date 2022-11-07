Console.Write("Введите число : ");
int Number = Convert.ToInt32(Console.ReadLine());
int n = Number;
int Count = 0;
if (Number<100) Console.WriteLine("Третьего числа нет");

else
{
while (n != 0) 
{
    n /= 10;
    Count++;
}

double Digit =(Number%(Math.Pow(10,Count-2)))/(Math.Pow(10,Count-3));
int ThirdDigit = (int)Digit;
Console.WriteLine(ThirdDigit);
}
