int[,] array = new int[4, 4];
int i = 0;
int j = 0;
int rightUpCorner = 3;
int rightDownCorner = 3;
int leftUpCorner = 0;
int leftDownCorner = 0;
int n =1;
while (true)
{
    while(j<=rightUpCorner)
    {
        array[i, j] = n;
        j++;
        n++;
    }
    if (n>16) break;
    j--;
    i++;
    rightUpCorner--;
    while(i<=rightDownCorner)
    {
        array[i, j] = n;
        i++;
        n++;
    }
    if (n>16) break;
    i--;
    j--;
    rightDownCorner--;
    while(j>=leftDownCorner)
    {
        array[i, j] = n;
        j--;
        n++;
    }
    if (n>16) break;
    j++;
    i--;
    leftDownCorner++;
    while(i>leftUpCorner)
    {
        array[i, j] = n;
        i--;
        n++;
    }
    if (n>16) break;
    i++;
    j++;
    leftUpCorner++;
}
for(int k=0; k<array.GetLength(0); k++)
{
    for (int m=0; m<array.GetLength(1); m++)
    {
        if (array[k, m] < 10) Console.Write(0);
        Console.Write(array[k, m]+" ");
    }
    Console.WriteLine();
}