using static MyLibrary;
public class Ex34
{
     public static  void Task34()
    {
        int[]array = CreateArray(8);
        Fill(array);
        string array_text = Print(array);
        int numbercount = count(array);
        Console.WriteLine(array_text);
        Console.WriteLine(numbercount);
    }
}
