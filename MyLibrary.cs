
    
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
        array[index] = new Random().Next();
        
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
   int index = 0;
   for (int i = 0; i > length; i++)
   {
     if (array[index]%2 == 0)
     count = count+1;
   }
     return count;
 }
}