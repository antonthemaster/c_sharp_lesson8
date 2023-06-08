int [,] array = new int[2, 2];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(1, 9);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int [,] array2 = new int[2, 2];
for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array2[i,j] = new Random().Next(1, 9);
        Console.Write(array2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int [,] res = new int[2, 2];
for (var i = 0; i < 2; i++)
{
    for (var j = 0; j < 2; j++)
    {
        res[i, j] = 0;
        for (var k = 0; k < 2; k++)
        {
            res[i, j] += array[i, k] * array2[k, j];
        }
    }
}

for (int i = 0; i < array2.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        Console.Write(res[i, j] + " ");
    }
    Console.WriteLine();
}
