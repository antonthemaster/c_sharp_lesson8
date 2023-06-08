Console.Write("Enter a length of array: ");
int arr_length = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter a wide of array: ");
int arr_wide = Convert.ToInt32(Console.ReadLine()); 

int [,] array = new int[arr_length, arr_wide];

for (int i = 0; i < arr_length; i++)
{
    for (int j = 0; j < arr_wide; j++)
    {
        array[i,j] = new Random().Next(1, 9);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
if (arr_length != arr_wide)
{
    Console.WriteLine("Impossible, reason is your bad input!");
}
else
{
    int [,] array2 = new int[arr_length, arr_wide];
    for (int i = 0; i < arr_length; i++)
{
        for (int j = 0; j < arr_wide; j++)
        {
            array2[i,j] = array[j, i];
            Console.Write(array2[i, j] + " ");
        }
    Console.WriteLine();
}
}
