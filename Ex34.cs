using static MyLibrary;
public class Ex34
{
     public static  void Task28()
    {
        int[]array = CreateArray(7);
        Fill(array);
        int numbercount = count(array);

        Console.WriteLine(numbercount);
    }
}
