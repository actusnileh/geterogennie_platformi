public class Lab7
{
    public static void Calculation()
    {
#if DEBUG
        Console.WriteLine("Режим DEBUG");

        TruncatedCone cone = new();
        cone.InputData();

        Console.WriteLine(cone.PrintInfo());
#else
        Console.WriteLine("Режим RELEASE");
        string[] lines = File.ReadAllLines("./Lab7/input.txt");

        if (lines.Length < 3)
        {
            WriteError("Недостаточно данных в файле.");
            return;
        }

        double r1 = double.Parse(lines[0]);
        double r2 = double.Parse(lines[1]);
        double height = double.Parse(lines[2]);
        
        TruncatedCone cone = new();

        cone.InputData(r1, r2, height);

        WriteResult(cone.PrintInfo());
#endif

    }


    private static void WriteError(string error)
    {
        using StreamWriter output = new("./Lab7/output.txt");
        output.WriteLine($"ERROR: {error}");
        Console.WriteLine($"ERROR: {error}");
    }
    private static void WriteResult(string result)
    {
        using StreamWriter output = new("./Lab7/output.txt");

        output.WriteLine(result);
    }
}
