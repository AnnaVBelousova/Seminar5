
    
public static class MyLibrary
// Метод создания массива
{
 public static int[] CreateArray(int count)
 {
    return new int[count];
 }

 // Метод заполнения массива
 
  public static void Fill(int[]array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
       // Next() - заполнение случайными неотрицательными числами
        array[index] = new Random().Next(0,100);
        
        index ++; 
    }
} 
// Печать массива
 public static string Print(int[]array)
{
    return String.Join(' ', array);
} 
// Определение количества четных чисел в массиве
   public static int count(int[]array)
   {
   int count = 0;
   int length = array.Length;
   
   for (int i = 0; i < length; i++)
   {
     if (array[i]%2 == 0)
     count = count+1;
     
   }
     return count;
 }
 // Определение суммы  чисел, стоящих на нечетных позициях
 public static int number(int[]array)
   {
   int summa = 0;
   int length = array.Length;
   
   for (int i = 0; i < length; i++)
   {
     if (i %2 != 0)
     summa = summa+array[i];
     
   }
     return summa;
 }
}