public class Lab2
{
    public static void Calculation()
    {
        string[] lines = File.ReadAllLines("./Lab2/input.txt");

        if (lines.Length < 5)
        {
            WriteError();
            return;
        }

        double[] values = new double[5];
        for (int i = 0; i < 5; i++)
        {
            if (!double.TryParse(lines[i], out values[i]) || values[i] < 0 || values[i] > 100000)
            {
                WriteError();
                return;
            }
        }

        double a1 = values[0], a2 = values[1], a3 = values[2], a4 = values[3], a5 = values[4];
        double s = Math.Sqrt(a1 - Math.Sqrt(a2 - a3));

        double denominatorK = a2 - a3;
        if (denominatorK == 0)
        {
            WriteError();
            return;
        }

        double innerK = a4 - Math.Sqrt(a5 - a1);
        double k = Math.Sqrt(innerK / denominatorK);

        WriteResult(s, k);
    }

    private static void WriteError()
    {
        using StreamWriter output = new("./Lab2/output.txt");
        output.WriteLine("ERROR");
        Console.WriteLine("ERROR");
    }

    private static void WriteResult(double s, double k)
    {
        using StreamWriter output = new("./Lab2/output.txt");

        string result = $"S = {Math.Round(s, 4)}\nK = {Math.Round(k, 4)}";

        output.WriteLine(result);
        Console.WriteLine(result);
    }
}