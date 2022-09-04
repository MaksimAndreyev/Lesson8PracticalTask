void FillArray(int[,,] array)
{
    for (int k=0; k<array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                array[k, i, j] = new Random().Next(10, 100);
            }
        }
    }
}


void PrintArray(int[,,] array)
{
    for (int j = 0; j < array.GetLength(2); j++)
    {
        for (int k=0; k<array.GetLength(0); k++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.Write(array[k, i, j]);
                Console.Write($"({k},{i},{j}) ");
            }
            Console.WriteLine();
        }
    }
}


Console.WriteLine("Введите количесвто строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину массива:");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[depth, rows, columns];
FillArray(array);
PrintArray(array);
Console.WriteLine();