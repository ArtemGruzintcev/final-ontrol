//!  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//!  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//!  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
Console.Write("Введите количество элементов массива:\t");
int elementCount = Convert.ToInt32(Console.ReadLine());
string[] array = new string[elementCount];

enteringСharacters(array);
Print(array);
Print2(massResult(array));

void enteringСharacters(string[] array)
{
    for (int i = 0; i < elementCount; i++)
    {
        Console.Write("Введите элемент под №{0}:\r\n    ", i + 1);
        array[i] = Console.ReadLine()!;
    }
}
string[] massResult(string[] array)
{
    int lenghtNewArray = 0;
    for (int i = 0; i <= array.Length -1; i++)
    {
        if (array[i].Length <= 3) lenghtNewArray++;
    }
    string[] result = new string[lenghtNewArray];
    int index = 0;
    for (int i = 0; i <= array.Length -1; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];
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
    Console.WriteLine("Вывод масива с тремя и менне символами:");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}