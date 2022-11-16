using System;

// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
class Program
{
    public static void Main(string[] args)
    {
        int enterNumber = 8;

        int[] array = new int[enterNumber];

        for (int i = 0; i < enterNumber; i++)
        {
            array[i] = new Random().Next(100, 999);

        }

        //Вариант вывода вне цикла:
        Console.WriteLine($"[{String.Join(", ", array)}]");


        int sum = 0;

        foreach (int i in array)
        {
            if (i % 2 == 0)
                sum++;
        }

        Console.WriteLine($"Количество четных чисел составляет: {sum}");
    }
}


*/

/*
// 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


void MainArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];

    }

    //Вариант вывода вне цикла:
    Console.WriteLine(sum);


}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

    Console.WriteLine($"[{String.Join(", ", array)}]");
}

int[] array = new int[9];
FillArrayRandomNumbers(array);
MainArray(array);

*/



// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

double[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива. Введите вещественное число");
        array[i] = Convert.ToDouble(Console.ReadLine());



    }
    Console.WriteLine($"[{String.Join("; ", array)}]");

    Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {array.Max() - array.Min()}");


    return array;

}

CreateArray();

*/