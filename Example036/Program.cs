//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19      [-4, -6, 89, 6] -> 0

void ArrayInputAndOutput (int number)
{
    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100,100);
    }

     for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }

    int count = 0;
    for (int q = 0; q < arr.Length; q++)
    {
        if (q % 2 == 1) count = count + arr[q];
    }
    Console.WriteLine("Сумма элементов на нечетных позициях равна = " + count);
}

Console.WriteLine("Был задан массив: ");
int number = new Random().Next(0,10);
ArrayInputAndOutput(number);