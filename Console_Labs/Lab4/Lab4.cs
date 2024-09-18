
public class Lab4
{
    public static void Calculation()
    {
        string[] lines = File.ReadAllLines("./Lab4/input.txt");
        int N;
        try
        {
            N = Convert.ToInt32(lines[0]);
        }
        catch
        {
            WriteError("Ошибка преобразования строки из файла в число!");
            return;
        }

        int[] numbers = GenerateRandomArray(N);

        using StreamWriter input = new("./Lab4/input.txt");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                input.Write(N);
                input.Write("\n");
            }
            input.Write($"{numbers[i]}, ");
        }

        int max_5 = int.MinValue;
        int min_3 = int.MaxValue;
        int sum_10 = 0;

        foreach (int number in numbers)
        {
            if (number % 5 == 0)
            {
                max_5 = Math.Max(max_5, number);
            }
            if (number % 3 == 0)
            {
                min_3 = Math.Min(min_3, number);
            }
            if (number % 10 == 0)
            {
                sum_10 += number;
            }
        }
        if (min_3 == int.MaxValue)
        {
            min_3 = 0;
        }
        WriteResult(max_5, min_3, sum_10);
    }

    private static int[] GenerateRandomArray(int elements)
    {
        int[] numbers = new int[elements];
        for (int i = 0; i < elements; i++)
        {
            numbers[i] = new Random().Next(-100000, 100000);
        }
        return numbers;

    }

    private static void WriteError(string error)
    {
        using StreamWriter output = new("./Lab4/output.txt");
        output.WriteLine($"ERROR: {error}");
        Console.WriteLine($"ERROR: {error}");
    }

    private static void WriteResult(double max_5, double min_3, double sum_10)
    {
        using StreamWriter output = new("./Lab4/output.txt");

        string result = $"Макс. кратных 5 = {max_5}\nМин. кратных 3 = {min_3}\nСумма делящихся на 10 = {sum_10}";

        output.WriteLine(result);
        Console.WriteLine(result);
    }
}