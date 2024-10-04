
namespace ExtraNumber1OAiP.Numbers;

public class ExtraNumber2
{
    public void StartProgram()
    {
        int[] userArray = InputUserArray();
        FindAndPrintPeaks(userArray);
    }

    private int[] InputUserArray()
    {
        Console.WriteLine("Введите элементы массива, разделяя их пробелами:");
        string? input = Console.ReadLine();
        string[] userArrayString = input?.Split(' ');
        int[] userArray = new int[userArrayString.Length];

        for (int i = 0; i < userArrayString.Length; i++)
            userArray[i] = Convert.ToInt32(userArrayString[i]);

        return userArray;
    }

    private void FindAndPrintPeaks(int[] array)
    {
        Console.WriteLine("Пиковые элементы:\n");

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0 && array[i] > array[i + 1])
            {
                Console.WriteLine($"Элемент {array[i]} с индексом {i} - это НАЧАЛЬНЫЙ пик.");
            }
            else if (i == array.Length - 1 && array[i] > array[i - 1])
            {
                Console.WriteLine($"Элемент {array[i]} с индексом {i} - это КОНЕЧНЫЙ пик.");
            }
            else if (i > 0 && i < array.Length - 1 && array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                Console.WriteLine($"Элемент {array[i]} с индексом {i} является пиком.");
            }
        }
    }
}