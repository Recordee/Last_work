﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] array = {"Hello","2","world",":-)"};

string MySortArray(string[] array)
{
    string[] resultArray = new string[0];
    for(int i =0; i < array.Length;i++)
        {
            if (array[i].Length <= 3)
            {
                resultArray = resultArray.Append($"'{array[i]}'").ToArray();
            }
        }
    return String.Join(", ",resultArray);
}

string r = MySortArray(array);
Console.WriteLine($"[{r}]");
