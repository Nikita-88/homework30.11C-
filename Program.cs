// Задайте одномерный массив из 10 целых чисел от 1 до 100.
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].


int [] array = {25, 2, 3, 64, 8, 5, 36, 4, 9, 53};
for (int i=0; i <array.Length; i++)
    if (array[i]>20 && array [i]<90)
        Console.WriteLine($"[{i}]={array[i]}");
// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int [] array = {2,4,3,7,8,9,10,12,13,15};
int count = 0;
for (int i=0; i<array.Length; i++)
    if (array[i] % 2 == 0)
    count++;

    Console.WriteLine(count);


// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = {2.2, 5.1,6.3,4.2};
double maxItem = array.Max(), minItem = array.Min();
Console.WriteLine($"Max {maxItem}");
Console.WriteLine($"Min {minItem}");
Console.WriteLine(Math.Abs (maxItem -minItem));

