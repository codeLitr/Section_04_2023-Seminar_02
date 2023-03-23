// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

//Console.Clear(); //Очистит консоль после инициации программы.
Random rnd = new Random(); // Можно эту часть включить сразу в след строку:
// int number = new Random().Next(10, 99); 
// НО если Random необходимо использовать несколько раз в программе, то лучше делать 
// в раздельных строках.
int number = rnd.Next(10, 99); //Если необходимо, чтобы диапазон включал 99, то 
// диапазон надо указать до 100.

int firstDigit = number / 10;
int lastDigit = number % 10;
// Данная часть - первый вариант решения:
// int maxDigit;

// if (firstDigit > lastDigit)
// {
//     maxDigit = firstDigit;
// }
// else
// {
//     maxDigit = lastDigit;
// }

//Данная часть - второй вариант решения:
int maxDigit = Math.Max(firstDigit, lastDigit);//Математическая функция, которая
// позволяет определить наибольшее число.
System.Console.WriteLine(number);
System.Console.WriteLine(maxDigit);