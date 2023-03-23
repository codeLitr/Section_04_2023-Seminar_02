// Дано натуральное n. вычислить: 1 + 1/2 + 1/3 + 1/4 + ... + 1/n.

System.Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
float sum = 0; // Число с плавающей точкой одинарной точности, можно еще 
//использовать double.
for (int i = 1; i <= n; i++)
{
    sum += (float)1 / (float)i; //(float) указывается для перевода типа данных 
    // из int в float.
    System.Console.WriteLine((float)1 / (float)i);
}
System.Console.WriteLine(sum);
