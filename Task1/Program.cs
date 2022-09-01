void FillArray(int[,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); i++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


Console.WriteLine("Введите количесвто строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
FillArray(array);
for (int i=0; i<array.GetLength(0); i++)
{
    array[i] = SortArray(array[i]);
    
}