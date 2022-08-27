//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] ArrayInputAndOutput (int number)
{
    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,100);
    }

     for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }
    return arr;
}

int DiffBetweenMaxAndMin (int[] Array)
{
    int max = Array[0];
    int min = Array[0];
    for (int q = 1; q < Array.Length; q++)
    {
        if (Array[q] > max) max = Array[q];
        else if (Array[q] < min) min = Array[q];
    }
    int res = max - min;
    return res;
}

Console.WriteLine("Был задан массив чисел: ");
int[] ArrayNumbers = ArrayInputAndOutput(8);
int result = DiffBetweenMaxAndMin(ArrayNumbers);
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна = " + result);
