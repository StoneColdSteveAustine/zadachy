Console.Write("Введите трёхзначное число : ");
int Number = Convert.ToInt32(Console.ReadLine());
int SecondDigit = (Number % 100)/10;
Console.WriteLine (SecondDigit);
