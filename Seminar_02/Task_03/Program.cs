// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число не кратно числу 
// первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

System.Console.Write("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if(firstDigit % secondDigit == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"Не кратно, остаток {firstDigit % secondDigit}");
}
