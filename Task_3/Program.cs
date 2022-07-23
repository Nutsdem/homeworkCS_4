// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] getNewArray(int lenghtArr)
{
int[] array = new int[lenghtArr];

for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(int.MinValue, int.MaxValue);
}


return array;
}


foreach (int item in getNewArray(8))
{
Console.Write(item + " ");
}
