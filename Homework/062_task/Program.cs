int[,] matrix = new int[4, 4];
int value = 1;
int rowStart = 0;
int rowEnd = matrix.GetLength(0) - 1;
int colStart = 0;
int colEnd = matrix.GetLength(1) - 1;

while (value <= 4 * 4)
{
    for (int i = colStart; i <= colEnd; i++)
        matrix[rowStart, i] = value++;
    rowStart++;

    for (int i = rowStart; i <= rowEnd; i++)
        matrix[i, colEnd] = value++;
    colEnd--;

    for (int i = colEnd; i >= colStart; i--)
        matrix[rowEnd, i] = value++;
    rowEnd--;

    for (int i = rowEnd; i >= rowStart; i--)
        matrix[i, colStart] = value++;
    colStart++;
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (matrix[i,j] < 10)
        {
           Console.Write("0" + matrix[i, j] + " "); 
        }
        else
        {
            Console.Write(matrix[i, j] + " ");
        }
    }
    Console.WriteLine();
}
