public class Lab3
{
    public static void Calculation(int iteration = 10)
    {
        string[] lines = File.ReadAllLines("./Lab3/input.txt");

        if (lines.Length != 1)
        {
            WriteError("Во входном файле должна быть одна строка!");
            return;
        }

        double x;
        try
        {
            x = Convert.ToDouble(lines[0]);
        }
        catch
        {
            WriteError("Ошибка преобразования строки из файла в число!");
            return;
        }

        double z = 1.0 / (1 * 3);

        for (int i = 0; i < iteration; i++)
        {
            double numerator = Math.Pow(x, i);
            double denominator = (i + 1) * (i + 3);
            if (i % 2 == 0)
            {
                z -= numerator / denominator;
            }
            else
            {
                z += numerator / denominator;
            }
        }
        WriteResult(z);
    }

    private static void WriteError(string error)
    {
        using StreamWriter output = new("./Lab3/output.txt");
        output.WriteLine($"ERROR: {error}");
        Console.WriteLine($"ERROR: {error}");
    }

    private static void WriteResult(double z)
    {
        using StreamWriter output = new("./Lab3/output.txt");

        string result = $"Z = {z}";

        output.WriteLine(result);
        Console.WriteLine(result);
    }
}