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


Console.WriteLine("Введите количество строк 1 матрицы:");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1 матрицы:");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк 2 матрицы:");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы:");
int columns2 = Convert.ToInt32(Console.ReadLine());
if (columns1 != rows2)
{
    Console.WriteLine("Произведение выполнить невозможно.");
    return;
}
int[,] array1 = new int[rows1, columns1];
int[,] array2 = new int[rows2, columns2];
FillArray(array1);
FillArray(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] multipliedArray = new int[rows1, columns2];
for (int i=0; i<multipliedArray.GetLength(0); i++)
{
    for (int j=0; j<multipliedArray.GetLength(1); j++)
    {
        for (int k=0; k<columns1; k++)
        {
            multipliedArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
Console.WriteLine("Результат перемножения матриц:");
PrintArray(multipliedArray);