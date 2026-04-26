using System;

//1
Console.WriteLine("\nПлоща трикутника за координатами");
Console.Write("x1 = "); double x1 = double.Parse(Console.ReadLine()!);
Console.Write("y1 = "); double y1 = double.Parse(Console.ReadLine()!);
Console.Write("x2 = "); double x2 = double.Parse(Console.ReadLine()!);
Console.Write("y2 = "); double y2 = double.Parse(Console.ReadLine()!);
Console.Write("x3 = "); double x3 = double.Parse(Console.ReadLine()!);
Console.Write("y3 = "); double y3 = double.Parse(Console.ReadLine()!);

double area = Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0;
Console.WriteLine($"Результат: Площа трикутника = {area}");

//3
Console.WriteLine("\nКратність суми цифр числу А");
Console.Write("Введіть двозначне число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введіть число A: ");
int A = int.Parse(Console.ReadLine()!);

int firstDigit = number / 10;
int secondDigit = number % 10;
int sumOfDigits = firstDigit + secondDigit;

if (sumOfDigits % A == 0)
    Console.WriteLine($"Результат: Так, сума цифр ({sumOfDigits}) кратна {A}");
else
    Console.WriteLine($"Результат: Ні, сума цифр ({sumOfDigits}) не кратна {A}");


//3
Console.WriteLine("\n--- Завдання 3.12: Перевірка графічної області ---");
Console.Write("x = "); float xCoord = float.Parse(Console.ReadLine()!);
Console.Write("y = "); float yCoord = float.Parse(Console.ReadLine()!);

if (Math.Abs(xCoord) < 40 && Math.Abs(yCoord) < 40)
    Console.WriteLine("Результат: Так (точка всередині)");
else if (Math.Abs(xCoord) == 40 || Math.Abs(yCoord) == 40)
    Console.WriteLine("Результат: На межі");
else
    Console.WriteLine("Результат: Ні (точка поза межами)");


//4
Console.WriteLine("\nРозклад лікаря");
Console.Write("Введіть номер дня тижня (1-7): ");
int day = int.Parse(Console.ReadLine()!);

string schedule = day switch
{
    1 => "08:00 - 13:00 (Терапевт)",
    2 => "14:00 - 19:00 (Хірург)",
    3 => "08:00 - 13:00 (Окуліст)",
    4 => "Методичний день (прийому немає)",
    5 => "09:00 - 15:00 (Невропатолог)",
    6 => "Черговий лікар (10:00 - 14:00)",
    7 => "Вихідний",
    _ => "Помилка: такого дня не існує"
};
Console.WriteLine($"Графік: {schedule}");
//5
Console.WriteLine("\n Квадрат частки двох чисел");
Console.Write("Введіть перше ціле число (ділене): ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введіть друге ціле число (дільник): ");
int num2 = int.Parse(Console.ReadLine()!);
if (num2 != 0)
{
    double rez5 = CalculateSquareOfDivision(num1, num2);
    Console.WriteLine($"Результат: ({num1} / {num2})^2 = {rez5}");
}
else
{
    Console.WriteLine("Помилка: ділення на нуль!");
}
d
static double CalculateSquareOfDivision(int a, int b)
{
    double division = (double)a / b; 
    return Math.Pow(division, 2); 
}
// 6
Console.WriteLine("\n Обчислення математичного виразу");
Console.Write("n (ціле) = "); int n = int.Parse(Console.ReadLine()!);
Console.Write("m (ціле) = "); int m = int.Parse(Console.ReadLine()!);

double mathResult = (m - n) * (double)(n + 1) / (n + m + 1) - Math.Pow(n, 2) + 5;
Console.WriteLine($"Результат виразу: {mathResult}");
