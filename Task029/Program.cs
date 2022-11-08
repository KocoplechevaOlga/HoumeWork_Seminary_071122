// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// Например: 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] FillArray(int l, int min, int max)
{
    int[] array = new int[l];
    Random rnd  = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);

    } 
    return array;
}
void PrintArray(int[] arr)
{
    int j = 0;
    for (j = 0; j < (arr.Length-1); j++)
    {
        Console.Write(arr[j] + ", ");
    }
    Console.Write(arr[j]);
}
Console.WriteLine("Введите размер массива:");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное ограничение массива:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное ограничение массива:");
int b = Convert.ToInt32(Console.ReadLine())+1;
int [] res = FillArray(length, a, b);
Console.Write("[");
PrintArray(res);
Console.Write("]");