using ExtraNumber1OAiP.Numbers;

namespace ExtraNumber1OAiP;

public class Program
{
    private const short NUMBER_COUNT = 2;

    public static void Main(string[] args)
    {
        ShowNumberIndex(1);

        ExtraNumber1 number1 = new();
        number1.StartProgram();

        Console.WriteLine("Нажмите ENTER, чтобы продолжить.");
        Console.ReadLine();
        ShowNumberIndex(2);

        ExtraNumber2 number2 = new();
        number2.StartProgram();
    }

    private static void ShowNumberIndex(short numberIndex)
    {
        if (numberIndex > NUMBER_COUNT)
            return;

        Console.Clear();
        Console.WriteLine($"ЗАДАНИЕ №{numberIndex}.\n");
    }           
}