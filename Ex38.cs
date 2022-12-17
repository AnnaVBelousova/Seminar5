// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
using static MyLibrary;
public class Ex38
{
     public static  void Task38()
    {
        double[]ar = CreateArraydouble(8);
        Fillarraydouble(ar);
        string array_text = Printarraydouble(ar);

        double min = minimum(ar);
        double max = maximum(ar);
        double difference = dif(max, min);
        Console.WriteLine(array_text);
        Console.WriteLine("Min:  " + min);
        Console.WriteLine("Max:  " + max);

        Console.WriteLine("Difference:  " + difference);
       
        
    }
}