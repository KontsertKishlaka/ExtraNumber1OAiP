namespace ExtraNumber1OAiP.Numbers;

public class ExtraNumber1
{
    public void StartProgram()
    {
        int[] userArray = InputUserArray();
        (int[] oddArray, int[] evenArray) = FillEvenAndOddArrays(userArray);
        CalculateAndPrintEvenSum(evenArray);
        CalculateAndPrintOddSum(oddArray);
    }

    private void CalculateAndPrintEvenSum(int[] evenArray)
    {
        int evenSum = 0;

        foreach (var number in evenArray)
            evenSum += number;

        Console.WriteLine($"Сумма чётных чисел равна: {evenSum}");
    }

    private void CalculateAndPrintOddSum(int[] oddArray)
    {
        int oddSum = 0;

        foreach (var number in oddArray)
            oddSum += number;

        Console.WriteLine($"Сумма нечётных чисел равна: {oddSum}\n");
    }

    private int[] InputUserArray()
    {
        Console.WriteLine("Введите количество элементов в массиве: ");
        int userArraySize = Convert.ToInt32(Console.ReadLine());

        int[] userArray = new int[userArraySize];

        Console.WriteLine("\nЗаполните массив: ");
        for (int i = 0; i < userArraySize; i++)
        {
            Console.Write($"{i}. ");
            userArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        return userArray;
    }

    private (int[], int[]) FillEvenAndOddArrays(int[] userArray)
    {
        int[] oddArray = new int[userArray.Length];
        int[] evenArray = new int[userArray.Length];

        for (int i = 0; i <= userArray.Length - 1; i++)
        {
            if (userArray[i] % 2 != 0)
                oddArray[i] = userArray[i];
            else
                evenArray[i] = userArray[i];
        }

        return (oddArray, evenArray);
    }
}