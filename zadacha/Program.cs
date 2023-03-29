// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//  либо задать на старте выполнения алгоритма. При решении не рекомндуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами. 
// Примеры: ["hello", "2", "word", ":-"] -> ["2", ":-"]
//  ["1234", "1567", "-2", "computer science"] -> ["-2"] 
// ["Russia", "Denmark", "Kazan"] -> []

int length = size();
string[] array = new string[length];
string[] arr = getArray(length);
PrintResult(filterArray(arr));

int size() {
    System.Console.WriteLine("Введите колличество элементов");
    int arrLength = int.Parse(Console.ReadLine());
    return arrLength;
}

string[] getArray(int length)
{
    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine("Введите элемент массива");
        string result = System.Console.ReadLine();
        array[i] = result;
    }
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    return array;
}

// Метод поиска элементов массива которые <= limit(3) увеличиваем sum при поиске 
string[] filterArray(string[] array)
{
    int limit = 3;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit)
        {
            sum++;
        }
    }

    string[] tempArray = new string[sum];

    for (int i = 0, t = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limit)
        {
            tempArray[t] = array[i];
            t++;
        }
    }
    return tempArray;
}
void PrintResult(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
