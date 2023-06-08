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

int [] buffer = new int [arr_wide];

for (int j = 0; j < arr_wide; j++)
    {
        buffer[j] =  array[arr_length - 1, j];
        array[arr_length - 1, j] = array[0, j];
        array[0, j] = buffer[j];
    }
Console.WriteLine();
Console.WriteLine();
for (int i = 0; i < arr_length; i++)
{
    for (int j = 0; j < arr_wide; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
