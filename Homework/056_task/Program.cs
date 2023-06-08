Console.Write("Enter a length of array: ");
int arr_length = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Enter a wide of array: ");
int arr_wide = Convert.ToInt32(Console.ReadLine()); 

int [,] array = new int[arr_length, arr_wide];
int [] arr_2 = new int [arr_length];
int index_counter = 0;


for (int i = 0; i < arr_length; i++)
{
    int cloud_sum = 0;
    for (int j = 0; j < arr_wide; j++)
    {
        array[i,j] = new Random().Next(1, 9);
        Console.Write(array[i, j] + " ");
        cloud_sum += array[i, j];
    }
    Console.WriteLine();
    arr_2[index_counter] = cloud_sum;
    index_counter++;
}


int min_value = arr_2.Min();
int min_index = Array.IndexOf(arr_2, min_value);

Console.WriteLine($"The most small sum on this row: {min_index + 1}");
