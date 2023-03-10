// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

String[] ChangeArray(String[] oldArray, String[] newArray)
{
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3)
            newArray[i] = oldArray[i];
    }
    return newArray;
}


void PrintArray(String[] a)
{
    for (int k = 0; k < a.Length; k++)
    {
        System.Console.Write($"{a[k]} ");
    }
}


String[] s = { "123", "asdf", "er", "3421", "qwe" };
String[] s2 = new String[s.Length];


ChangeArray(s, s2);
PrintArray(s2);