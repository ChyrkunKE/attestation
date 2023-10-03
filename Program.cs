// Написать программу, 
// которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма.
//   При решении не рекомендуется пользоваться коллекциями, \
//   лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



void CreateArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}

int CountElementsInNewArray (string[] arr)
{
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            n++;
    }
    return n;
}

string [] Result (string[] arr, int n)  
{
 string[] resultArray = new string[n];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArray[j] = arr[i];
            j++;
        }
    }
    return resultArray;
}


Console.WriteLine("Сколько элементов массива вы хотите ввести:");
int l = Convert.ToInt32(Console.ReadLine());
string[] array = new string[l];
CreateArray(array);
Console.WriteLine();
PrintArray(array);
int num = CountElementsInNewArray(array);
string [] newArray = Result (array, num);
Console.WriteLine();
PrintArray(newArray);
