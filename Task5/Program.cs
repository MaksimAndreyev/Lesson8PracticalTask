Console.WriteLine("Введите количесвто строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
int i = 0;
int j = 0;
int rightUpCorner = columns-1;
int rightDownCorner = rows-1;
int leftUpCorner = 0;
int leftDownCorner = 0;
int n = 1;
int maxNumber = columns * rows;
while (true)
{
    while (j <= rightUpCorner)
    {
        array[i, j] = n;
        j++;
        n++;
    }
    if (n > maxNumber) break;
    j--;
    i++;
    rightUpCorner--;
    while (i <= rightDownCorner)
    {
        array[i, j] = n;
        i++;
        n++;
    }
    if (n > maxNumber) break;
    i--;
    j--;
    rightDownCorner--;
    while (j >= leftDownCorner)
    {
        array[i, j] = n;
        j--;
        n++;
    }
    if (n > maxNumber) break;
    j++;
    i--;
    leftDownCorner++;
    while (i > leftUpCorner)
    {
        array[i, j] = n;
        i--;
        n++;
    }
    if (n > maxNumber) break;
    i++;
    j++;
    leftUpCorner++;
}
for (int k = 0; k < array.GetLength(0); k++)
{
    for (int m = 0; m < array.GetLength(1); m++)
    {
        if (array[k, m] < 10) Console.Write(0);
        Console.Write(array[k, m] + " ");
    }
    Console.WriteLine();
}