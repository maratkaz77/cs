﻿// участники: Dzheb, arslanovmarat, lrdnv
// Почувствуй себя интерном
//  0. Вывести квадрат числа
//  1. По двум заданным числам проверять является ли первое квадратом второго
//  2. Даны два числа. Показать большее и меньшее число
//  3. По заданному номеру дня недели вывести его название
//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y=f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//  0. Вывести квадрат числа
double n = 9;
Console.WriteLine(Math.Pow(n, 2));
//  2. Даны два числа. Показать большее и меньшее число
int m = 5;
n = 10;
if (m > n)
{
  Console.WriteLine($"Большее число: {m}");
  Console.WriteLine($"Меньшее число: {n}");
}
else
{
  Console.WriteLine($"Большее число: {n}");
  Console.WriteLine($"Меньшее число: {m}");
}

// 4. Найти максимальное из трех чисел
int[] arr = { 8, 6, 9 };

int maxn = arr[0];
for (int i = 0; i < arr.Length; i++)
{
  if (maxn < arr[i])
  {
    maxn = arr[i];
  }

}
Console.WriteLine($"Максимум из трёх: {maxn}");
//  6. Выяснить является ли число чётным
int num = 8;
// if (IsEven(num))
// {
Console.WriteLine($"Число {num} чётное {IsEven(num)}");

// }
// else
// {
//   Console.WriteLine($"{IsEven(num)}");
// }

Boolean IsEven(int num)
{
  Boolean even = false;
  if (num % 2 == 0) even = true;
  return even;
}

//  8. Показать четные числа от 1 до N

for (int i = 1; i <= 10; i++)
{
  if (i % 2 == 0)
    Console.WriteLine(i);
}
//10. Показать вторую цифру трёхзначного числа
int n10 = 778;
Console.WriteLine(Num2(n10));
int Num2(int n)
{
  int a = n / 100;
  int s = n - a * 100;
  int b = s / 10;
  return b;
}
// 12. Удалить вторую цифру трёхзначного числа
int n12 = 123;
Console.WriteLine(Exc2(n12));
int Exc2(int n)
{
  int a = n / 100;
  int s = n - a * 100;
  //int b = s / 10;
  return a * 10 + s % 10;
}

// // 14. Найти третью цифру числа или сообщить, что её нет
// int n12 = 123;
// Console.WriteLine(Exc2(n12));
// int Exc2(int n)
// {
//   int a = n / 100;
//   int s = n - a * 100;
//   //int b = s / 10;
//   return a * 10 + s % 10;
// }
