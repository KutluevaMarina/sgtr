// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*int[] CreateRandomArray (int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100,1000);
    }
    return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
   // Console.WriteLine();
}
void FillArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    Console.Write($"-> всего {array.Length} чисел, {count} из них чётные");
}
Console.Write("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray =CreateRandomArray(size);
ShowArray(newArray);
FillArray(newArray);*/



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*int[] CreateRandomArray (int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100,1000);
    }
    return newArray;
}
void ShowArray (int[] array)
{
    Console.Write("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
   // Console.WriteLine();
}
void FindSumArray (int[] array)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    Console.Write($"-> всего {array.Length} чисел, {count} из них нечётные");
}
Console.Write("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray =CreateRandomArray(size);
ShowArray(newArray);
FindSumArray(newArray);*/




