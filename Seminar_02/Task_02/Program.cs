// Напишите программу, которая выводит случайное трёхзначное число и удаляет 
//вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int digit = new Random().Next(100, 1000);
int firstDigit = digit / 100 * 10;
int thirdDigit = digit % 10;
int result = firstDigit + thirdDigit;

System.Console.WriteLine(digit);
System.Console.WriteLine(result);