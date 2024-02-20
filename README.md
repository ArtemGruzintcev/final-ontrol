# Итоговая контрольная работа по основному блоку

**Задача:**

*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами..*

**Примеры:**

- [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

- [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

- [“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм решения задачи:

1. Делаем запрос на ввод количеста элементов в массиве. `(Запроса нет в блок схеме)`

```C#
Console.Write("Введите количество элементов массива:");
```

2. Создание переменной `elementCount` для полученния данных о количестве элементов. `(Переменной нет в блок схеме)`

```C#
int elementCount = Convert.ToInt32(Console.ReadLine());
```

3. Создание массива `array` с количеством строк `elementCount`.

```C#
string[] array = new string[elemantCount];
```

4. Создание метода `enteringСharacters` для ввода символов в массив `array`. `(Метода нет в блок схеме)`

```C#
void enteringСharacters(string[] array)
{
    for (int i = 0; i < elementCount; i++)
    {
        Console.Write("Введите элемент под №{0}:\r\n    ", i + 1);
        array[i] = Console.ReadLine()!;
    }
}
```

5. Создане метода `Print` для вывода массива. `(Метода нет в блок схеме)`

```C#
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
```

6. Создание метода `massResult` которое вначале считает количество элементов массива с тремя и менее символами `lenNewArray`. Затем создает массив нужной размерностью `result` и внесет данные из введенного массива в результат метода.


```C#
string[] massResult(string[] array)
{
    int lenNewArray = 0;
    for (int i = 0; i <= array.Length -1; i++)
    {
        if (array[i].Length <= 3) lenNewArray++;
    }
    string[] result = new string[lenNewArray];
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
```

7. Создание метода `Print2`и передачи в него метода `massResult` для вывода масива с тремя и менне символами.

```C#
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
```