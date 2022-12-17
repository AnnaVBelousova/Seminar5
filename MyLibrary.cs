
    
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
 // для вещественных чисел
 //создание массива
 

 public static double[] CreateArraydouble(int count)
 {
    return new double[count];
 }


 // Метод заполнения массива
 
  public static void Fillarraydouble(double[]array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
       // Next() - заполнение случайными неотрицательными числами
        array[index] =  new Random().NextDouble()*1000;
        
        index ++; 
    }
} 
// Печать массива
 public static string Printarraydouble(double[]array)
{
    return String.Join(' ', array);
} 


// найти минимум 2 

public static double minimum(double[]array)
{
  
  int length = array.Length;
  
  double min = array[0]; //It is important!
  double next = 0;
  double current = 0;

  for (int i = 0; i < length-1; i++)
{
   current = array[i];
   next = array[i+1];

 

   {
    if (min> array[i+1])

    min = array[i+1];
   }
   
}
return min;
}



//найти мах
public static double maximum(double[]array)

{
  
  int length = array.Length;
  
  double max = array[0]; //It is important!
  double next = 0;
  double current = 0;

  for (int i = 0; i < length-1; i++)
{
   current = array[i];
   next = array[i+1];

 

   {
    if (max< array[i+1])

    max = array[i+1];
   }
   
}
return max;
}


// разница между мин и мах
public static double dif (double max, double min)
{
double difference = max - min;
return difference;
}
   
}