using static MyLibrary;
public class Ex34
{
     public static  void Task34()
    {
        int[]array = CreateArray(7);
        Fill(array);
        string array_text = Print(array);
        int number = Count(array);

        Console.WriteLine(array_text);
        Console.WriteLine(number);
    }
}
