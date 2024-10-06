public class Lab6
{
    public static void Calculation()
    {
        double x1, y1, x2, y2;

#if DEBUG
        Console.WriteLine("Режим DEBUG");
        x1 = double.Parse(Console.ReadLine() ?? "0");
        y1 = double.Parse(Console.ReadLine() ?? "0");
        x2 = double.Parse(Console.ReadLine() ?? "0");
        y2 = double.Parse(Console.ReadLine() ?? "0");
        
        Segment segment = new(x1, y1, x2, y2);

        Console.WriteLine(segment.PrintInfo());
#else
        Console.WriteLine("Режим RELEASE");
        string[] lines = File.ReadAllLines("./Lab6/input.txt");

        if (lines.Length < 4)
        {
            WriteError("Недостаточно данных в файле.");
            return;
        }

        x1 = double.Parse(lines[0]);
        y1 = double.Parse(lines[1]);
        x2 = double.Parse(lines[2]);
        y2 = double.Parse(lines[3]);

        Segment segment = new(x1, y1, x2, y2);

        WriteResult(segment.PrintInfo());
#endif

    }

    private static void WriteError(string error)
    {
        using StreamWriter output = new("./Lab6/output.txt");
        output.WriteLine($"ERROR: {error}");
        Console.WriteLine($"ERROR: {error}");
    }

    private static void WriteResult(string result)
    {
        using StreamWriter output = new("./Lab6/output.txt");

        output.WriteLine(result);
    }
}