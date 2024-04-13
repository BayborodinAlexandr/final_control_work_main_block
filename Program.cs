// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Вводим массив строк
Console.WriteLine("Введите элементы массива через запятую:");
string input = Console.ReadLine();
string[] originalArray = input.Split(',');

// Формирование нового массива
string[] newArray = FilterStrings(originalArray);

// Вывод старого массива в требуемом формате
Console.Write("[");
for (int i = 0; i < originalArray.Length; i++)
{
    Console.Write("\"" + originalArray[i].Trim() + "\"");
    if (i < originalArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write("] → [");
// Вывод нового массива в требуемом формате
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write("\"" + newArray[i].Trim() + "\"");
    if (i < newArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");

static string[] FilterStrings(string[] array)
{
    //Подсчет количества элементов старого массива с числом символов менее или равным 3
    int count = 0;
    foreach (string str in array)
    {
        if (str.Trim().Length <= 3)
        {
            count++;
        }
    }

    // Создание нового массива
    string[] result = new string[count];
    int index = 0;

    // Заполнение нового массива элементами старого массива с числом символов менее или равным 3
    foreach (string str in array)
    {
        if (str.Trim().Length <= 3)
        {
            result[index] = str.Trim();
            index++;
        }
    }

    return result;
}