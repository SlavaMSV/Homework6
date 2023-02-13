/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */



int[] InitArray(int dimension)
{
    int[] result = new int[dimension];
    for (int i = 0; i < result.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива № {i}:");
        while(true)
        {
            if(int.TryParse(Console.ReadLine(), out result[i]))
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
                Console.WriteLine($"Введите элемент массива № {i}:");
            }
        }
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.WriteLine("Массив целых чисел:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void GetPositiveQuantity(int[]arr)
{
    int count = 0;
    for (int i=0; i<arr.Length; i++)
    {
        if(arr[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество положительных элементов массива: {count}");
}
Random rnd = new Random();
int dimension = rnd.Next(1, 10);
Console.WriteLine($"Количество элементов массива: {dimension}");
int[] arr= InitArray(dimension);
PrintArray(arr);
GetPositiveQuantity(arr);


