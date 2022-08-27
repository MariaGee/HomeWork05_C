///Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] ArrayInput (int number)
{
    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

void ArrayOutput(int[] Arr)
{
    for (int j = 0; j < Arr.Length; j++)
    {
        Console.Write(Arr[j] + " ");
    }
}

int EvenNumbers (int[] Array)
{
    int count = 0;
    for (int q = 0; q < Array.Length; q++)
    {
        if (Array[q] % 2 == 0) count++;
    }
    return count;
}

int[] ArrayNumbers = ArrayInput(6);
Console.WriteLine("Был задан массив чисел: ");
ArrayOutput(ArrayNumbers);
Console.WriteLine("Количество четных элементов в массиве = " + EvenNumbers(ArrayNumbers));


