/*
Задача. Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

// подсчет количества строк в массиве, длина которых меньше либо равна 3 символа
int NumberOfStringsLessOrEqual3Symbols(string[] arrayOfStrings)
{
    int count = 0;
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        if (arrayOfStrings[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

// выбор из массива строк, длина которых меньше либо равна 3 символа
// и заполнение ими другого массива
string[] ArrayOfStringsLessOrEqual3Symbols(string[] arrayOfStrings, int length)
{
    string[] arrayOfStringsOf3Symbols = new string[length];
    int j = 0;
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        if (arrayOfStrings[i].Length <= 3)
        {
            arrayOfStringsOf3Symbols[j] = arrayOfStrings[i];
            j++;
        }
    }
    return arrayOfStringsOf3Symbols;
}

// печать массива
void PrintArray(string[] arrayOf3Symbols)
{
    Console.Write($"[");
    if (arrayOf3Symbols.Length != 0)
    {
        for (int i = 0; i < arrayOf3Symbols.Length; i++)
        {
            Console.Write($"'{arrayOf3Symbols[i]}'");
            if (i < arrayOf3Symbols.Length - 1)
            {
                Console.Write($", ");
            }
        }
    }
    Console.Write($"]");
}

// создание рандомного массива строк
// (для проверки решения)
string[] ArrayOfRandomStrings()
{
    string str = "0123456789abcdefghijklmnopqrstuvwxyz()-=+:";
    int length = new Random().Next(0, 11); // длина массива от 0 до 10 строк
    string[] randomArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        int stringSize = new Random().Next(0, 11); // длина строк в массиве от 0 до 10 символов
        string randomString = "";
        for (int j = 0; j < stringSize; j++)
        {
            int count = new Random().Next(0, 42);
            randomString = randomString + str[count];
        }
        randomArray[i] = randomString;
    }
    return randomArray;
}

// проверка на то, что длина строк в итоговом массиве меньше либо равна 3 символа
bool CheckingFinalArray(string[] arrayOfStrings)
{
    bool lessOrEqual3Symbols = true;
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        if (arrayOfStrings[i].Length <= 3)
        {
            lessOrEqual3Symbols = true;
        }
        else
        {
            lessOrEqual3Symbols = false;
        }
    }
    return lessOrEqual3Symbols;
}

// ввод массива строк из консоли
string[] InteringArrayOfStrings()
{
    Console.Write("Введите количество строк в массиве: ");
    int length;
    while (!int.TryParse(Console.ReadLine(), out length) || length < 0)
    {
        Console.Write("Введите количество строк в массиве в виде целого положительного числа или ноля: ");
    }
    string[] arrayOfStrings = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите строку с индексом {i}: ");
        arrayOfStrings[i] = Console.ReadLine();
    }
    return arrayOfStrings;
}

Console.WriteLine("Если хотите задать массив с консоли, то введите '+'");
string answer = Console.ReadLine();
if (answer == "+")
{
    // массив, заданный с консоли
    string[] arr0 = InteringArrayOfStrings();
    int n0 = NumberOfStringsLessOrEqual3Symbols(arr0);
    PrintArray(arr0);
    Console.Write($"   ->   ");
    string[] arrayOfStrings0 = ArrayOfStringsLessOrEqual3Symbols(arr0, n0);
    PrintArray(arrayOfStrings0);
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine();
}
else
{
    // проверка Примера 1
    Console.WriteLine();
    Console.WriteLine("Пример 1:");
    string[] arr = { "hello", "2", "world", ":-)" };
    int n = NumberOfStringsLessOrEqual3Symbols(arr);
    PrintArray(arr);
    Console.Write($"   ->   ");
    string[] arrayOfStrings = ArrayOfStringsLessOrEqual3Symbols(arr, n);
    PrintArray(arrayOfStrings);
    Console.Write($"   ->   ");
    bool checking = CheckingFinalArray(arrayOfStrings);
    Console.WriteLine(checking);
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine();

    // проверка Примера 2
    Console.WriteLine("Пример 2:");
    string[] arr2 = { "1234", "1567", "-2", "computer science" };
    int n2 = NumberOfStringsLessOrEqual3Symbols(arr2);
    PrintArray(arr2);
    Console.Write($"   ->   ");
    string[] arrayOfStrings2 = ArrayOfStringsLessOrEqual3Symbols(arr2, n2);
    PrintArray(arrayOfStrings2);
    Console.Write($"   ->   ");
    bool checking2 = CheckingFinalArray(arrayOfStrings2);
    Console.WriteLine(checking2);
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine();

    // проверка Примера 3
    Console.WriteLine("Пример 3:");
    string[] arr3 = { "Russia", "Denmark", "Kazan" };
    int n3 = NumberOfStringsLessOrEqual3Symbols(arr3);
    PrintArray(arr3);
    Console.Write($"   ->   ");
    string[] arrayOfStrings3 = ArrayOfStringsLessOrEqual3Symbols(arr3, n3);
    PrintArray(arrayOfStrings3);
    Console.Write($"   ->   ");
    bool checking3 = CheckingFinalArray(arrayOfStrings3);
    Console.WriteLine(checking3);
    Console.WriteLine("--------------------------------------------------------------------------------");
    Console.WriteLine();

    // проверка рандомных массивов
    Console.WriteLine("Рамдомные массивы:");
    for (int i = 0; i < 5; i++)
    {
        string[] arr4 = ArrayOfRandomStrings();
        int n4 = NumberOfStringsLessOrEqual3Symbols(arr4);
        PrintArray(arr4);
        Console.Write($"   ->   ");
        string[] arrayOfStrings4 = ArrayOfStringsLessOrEqual3Symbols(arr4, n4);
        PrintArray(arrayOfStrings4);
        Console.Write($"   ->   ");
        bool checking4 = CheckingFinalArray(arrayOfStrings4);
        Console.WriteLine(checking4);
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine();
    }
}
