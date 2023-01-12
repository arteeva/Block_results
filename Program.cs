// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Для удобства проверки введу здесь предложенные массивы в удобном для copy/paste виде:
// "Hello", "2", "world", ":-)" 
// "1234", "1567", "-2", "computer science" 
// "Russia", "Denmark", "Kazan" 

string[] array = new string[] {"Hello", "2", "world", ":-)"};

int lengthNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lengthNewArray++;
}

string[] newArray = new string[lengthNewArray];
int index = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[index] = array[i];
        index++;
    }
}

PrintArray(array);
Console.Write("->");
PrintArray(newArray);


void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}