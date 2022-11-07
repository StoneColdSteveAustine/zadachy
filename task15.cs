Console.Write("Введи цифру дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

void CheckTheDay (int DayNumber) {
  if (DayNumber == 6 || DayNumber == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (DayNumber < 1 || DayNumber > 7) {
    Console.WriteLine("эта цифра не подходит");
  }
  else Console.WriteLine("это будний день");
}

CheckTheDay(DayNumber);
