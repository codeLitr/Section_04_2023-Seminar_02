// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

System.Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//if(Math.Pow(firstNumber, 2) == secondNumber || Math.Pow(secondNumber, 2) == firstNumber)
// Данную строку можно сократить через булевую переменную (bool). 
// Когда вводится булевая перменная, то перед названием переменной ставится "is".
bool isSquare = Math.Pow(firstNumber, 2) == secondNumber || Math.Pow(secondNumber, 2) == firstNumber;
if(isSquare)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
