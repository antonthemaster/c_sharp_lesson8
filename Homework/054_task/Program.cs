Console.Write("Enter a length of array: ");
int arr_length = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter a wide of array: ");
int arr_wide = Convert.ToInt32(Console.ReadLine()); 

int [,] array = new int[arr_length, arr_wide];
int new_array_length = arr_length * arr_wide;
int [] arr_2 = new int [new_array_length];
int index_counter = 0;


for (int i = 0; i < arr_length; i++)
{
    int [] cloud_array = new int [arr_wide];
    for (int j = 0; j < arr_wide; j++)
    {
        array[i,j] = new Random().Next(1, 9);
        Console.Write(array[i, j] + " ");
        cloud_array[j] = array[i , j];
    }
    
    Console.WriteLine();
    Array.Sort(cloud_array);
    Array.Reverse(cloud_array);


    for (int j = 0; j < arr_wide; j++)
    {
        arr_2[index_counter] = cloud_array[j];
        index_counter++;
    }
}

Console.WriteLine();
Console.WriteLine("------------");
Console.WriteLine();

index_counter = 0;

for (int i = 0; i < arr_length; i++)
{
    for (int j = 0; j < arr_wide; j++)
    {
        array[i,j] = arr_2[index_counter];
        Console.Write(array[i, j] + " ");
        index_counter++;
    }
    Console.WriteLine();
}
