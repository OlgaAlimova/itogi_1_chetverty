// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Введите длину массива: ");
int count = Convert.ToInt32(Console.ReadLine());
string[] array = new string[count];
string[] creatyStringArray = CreatyStringArray(array);
PrintArray(creatyStringArray);
string[] creatyNewArray = CreatyNewStringArray(creatyStringArray);
PrintArray(creatyNewArray);

string[] CreatyNewStringArray(string[] arr)
{
    string[] newArr = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[i] = arr[i];
        }
    }
    return newArr;
}

string[] CreatyStringArray(string[] arr)
{
    for (int i = 0; i < count; i++)
    {

        Console.WriteLine($"Введите слово {i + 1}");
        string? text = Console.ReadLine();
        link:
        if (String.IsNullOrEmpty(text))
        {
            Console.WriteLine("Введите корректное значение");
            text = Console.ReadLine();
            goto link;
            
        }
        arr[i] = text;

    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}