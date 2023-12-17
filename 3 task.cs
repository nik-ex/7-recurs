// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int arraySize = ReadNumber("Введите размер массива: ");
int firstNumber = ReadNumber("Введите начальное число массива: ");
int lastNumber = ReadNumber("Введите конечное число массива: ");
int[] array = NewRandomArray(arraySize, firstNumber, lastNumber);
Print(array);
Console.WriteLine();
Array.Reverse(array);
Print(array);

int ReadNumber(string userText)
{
    Console.Write(userText);
    int numberUser = Convert.ToInt32(Console.ReadLine());
    return numberUser;
}

int[] NewRandomArray(int arrSize, int arrStart, int arrEnd)
{
    Random rnd = new Random();
    int[] newArr = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        newArr[i] = rnd.Next(arrStart, arrEnd);
    }
    return newArr;
}

void Print(int[] array, int current = 0)
{
    if (current == array.Length) return;
    else
    {
        Console.Write(" " + array[current++]);
        Print(array, current);
    }
}
