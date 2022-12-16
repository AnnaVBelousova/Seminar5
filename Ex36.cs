// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
using static MyLibrary;
public class Ex36
{
     public static  void Task36()
    {
        int[]array = CreateArray(8);
        Fill(array);
        string array_text = Print(array);
        int numbercount = number(array);
        Console.WriteLine(array_text);
        Console.WriteLine(numbercount);
    }
}