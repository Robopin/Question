int GetMassive(int length)
{
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} число массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
return array;
}



// int[] array = new int[5];
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"Введите {i} число массива");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
//int[] arr = GetMassive(5);
PrintArray(array);