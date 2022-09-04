void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
}


Console.WriteLine("Введите количесвто строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int temporary;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int l = 0; l < array.GetLength(1); l++)
    {
        for (int j = l + 1; j < array.GetLength(1); j++)
        {
            if (array[i, l] < array[i, j])
            {
                temporary = array[i, l];
                array[i, l] = array[i, j];
                array[i, j] = temporary;
            }
        }
    }
}
PrintArray(array);