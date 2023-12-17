// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

int firstNumber = ReadNumber("Введите начальное число: ");
int lastNumber = ReadNumber("Введите конечное число: ");
SumNumber(firstNumber, lastNumber);

int ReadNumber(string userText)
{
    Console.Write(userText);
    int numberUser = Convert.ToInt32(Console.ReadLine());
    return numberUser;
}

void SumNumber(int numStart, int numEnd)
{
   if (numStart > numEnd) return;
    {
        Console.Write(numStart + " ");
        numStart++;
        SumNumber(numStart++, numEnd);
    }
} 
