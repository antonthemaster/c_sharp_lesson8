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

int[] sorted_array = new int [arr_length * arr_wide];
int index = 0;

for (int i = 0; i < arr_length; i++)
{
    for (int j = 0; j < arr_wide; j++)
    {
        sorted_array[index] = array[i,j];
        index++;
    }
}
Array.Sort(sorted_array);
Console.WriteLine(String.Join(" ", sorted_array));
int count = 1;
for (int i = 0; i < arr_length * arr_wide; i++)
{
    if(i + 1 != arr_length * arr_wide)
    {
        if (sorted_array[i] == sorted_array[i+1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Quantity of '{sorted_array[i]}' equal to {count}'");
            count = 1;
        }
    }
    else
    {
        Console.WriteLine($"Quantity of '{sorted_array[i]}' equal to {count}'");
    }
}


