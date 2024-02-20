//!  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//!  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//!  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите количество строк:");
int countLine = Convert.ToInt32(Console.ReadLine());
string[] array = new string[countLine];
massLine(array);
Print(array);
Print2(massResult(array));

void massLine(string[] array)
{
    for (int i = 0; i < countLine; i++)
    {
        Console.Write("Введите строку №{0}:\r\n    ", i + 1);
        array[i] = Console.ReadLine()!;
    }
}
string[] massResult(string[] array)
{
    int lenNewArray = 0;
    for (int i = 0; i <= array.Length -1; i++)
    {
        if (array[i].Length <= 3) lenNewArray++;
    }
    string[] result = new string[countLine];
    int index = 0;
    for (int i = 0; i <= array.Length -1; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            index++;
        }
    }
    return result;
}
void Print(string[] array)
{
    Console.WriteLine("Вывод массива: ");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
void Print2(string[] array)
{
    Console.WriteLine("Вывод масива длина строк которых меньше либо равна 3: ");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}