// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 1000);
}

void PrintArray(int[] array)
{
     Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

int EvenNumbers(int[] array)
{
    int quan = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            quan ++;
    return quan;
}

int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
int quantity = EvenNumbers(myArray);

Console.WriteLine($"Количество четных чисел в массиве {quantity}");
*/

//__________________________________________________________________________________________________________________________________________________________________

// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

/*
int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(1,10);
        }
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

int SumNumbers(int[] array)
{
int sum = 0;
for (int i = 1; i < array.Length; i += 2)
    sum = sum + array[i];
    return sum;
}

int size = InputNum("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
int sumTotal = SumNumbers(myArray);

 Console.WriteLine($"сумма элементов cтоящих на нечётных позициях = {sumTotal}");
 */

//____________________________________________________________________________________________________________________________________________________________

// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


double MaxNumber(double[] array)                                                                                                            
{                                                        
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}                                                                         

double MinNumber(double[] array)
{
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.WriteLine("Введите размер массива  ");
int size =int.Parse(Console.ReadLine()!); ;
double[] myArray = new double[size];
FillArray(myArray);
PrintArray(myArray);
double max = MaxNumber(myArray);
double min = MinNumber(myArray);

Console.WriteLine($"{max} - {min} = {max - min}");

