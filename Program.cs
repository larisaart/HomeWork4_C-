// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
Degree(numberA, numberB);

void Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{numberA} в степени {numberB} = {result} ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

/*
int number = ReadInt("Введите число: ");
int len = NumLen(number);
Sum (number, len);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void Sum (int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма чисел в числе {number} = {sum}" );
}
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
Console.Write("Введите числа через запятую: ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ","; // дополнительня запятая для обозначения конца строки

string RemovingSpaces (string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ') 
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

void СheckNumber2 (int  series)
{
    if (series == '0'||series == '1'||series == '2'
    ||series == '3'||series == '4'||series == '5'||series == '6'
    ||series == '7'||series == '8'||series == '9'||series == ','
    ||series == '-')
    {
    }
        else 
        {
            Console.WriteLine($"Ошибка ввода. Вводи цифры.");
        }
}

int[] ArrayOfNumbers(string seriesNew)
{ 

    int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

    int j =0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
        if (i < seriesNew.Length-1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
    j++;
    }
    return arrayOfNumbers;
}

void PrintArry(int[] coll)
{
int count = coll.Length;
int index = 0;
Console.Write("[");
    while(index < count)
    {
        Console.Write(coll[index]);
        index++;
            if (index < count)
            {
                Console.Write(", ");
            }
    }
Console.Write("]");
} 

string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);
*/