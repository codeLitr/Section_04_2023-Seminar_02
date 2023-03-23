// Вычислить сумму от 2 ^ 0 до 2 ^ 10 (^ - степень).

// int n = 2;
// int sum = 0;

// for (int i = 0; i <= 10; i++)
// {
//     sum += (int)Math.Pow(n, i);
// }
// System.Console.WriteLine(sum);

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    int value = int.Parse(strValue);
    return value;
}

string[] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

int value = Prompt("Введите номер дня недели > ");
if(value == 6 || value == 7) 
{
    Console.WriteLine("Да");
} 
else
{
    Console.WriteLine("Нет");
}
