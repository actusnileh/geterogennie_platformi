public class Lab5
{
    public static void Calculation(int q = 10, int z = 5)
    {
        string inputFile = "./Lab5/input.txt";
        int rows, cols;

        try
        {
            using StreamReader reader = new(inputFile);
            var dimensions = reader.ReadLine().Split(' ');
            rows = int.Parse(dimensions[0]);
            cols = int.Parse(dimensions[1]);
        }
        catch (Exception ex)
        {
            WriteError("Ошибка чтения файла: " + ex.Message);
            return;
        }

        Random rand = new();
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(-103, 104);
            }
        }

        double[] rowAverages = new double[rows];
        for (int i = 0; i < rows; i++)
        {
            rowAverages[i] = Enumerable.Range(0, cols)
                                        .Select(j => matrix[i, j])
                                        .Where(x => x % 2 == 0)
                                        .DefaultIfEmpty(0)
                                        .Average();
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = matrix[i, j] < rowAverages[i] ? q : z;
            }
        }

        try
        {
            using StreamWriter writer = new("./Lab5/output.txt");
            writer.WriteLine("Модифицированная матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    writer.Write(matrix[i, j] + "\t");
                }
                writer.WriteLine();
            }

            writer.WriteLine("\nСреднее арифметическое четных элементов для каждой строки:");
            foreach (var avg in rowAverages)
            {
                writer.WriteLine(avg);
            }
        }
        catch (Exception ex)
        {
            WriteError("Ошибка записи в файл: " + ex.Message);
        }
    }

    private static void WriteError(string error)
    {
        using StreamWriter output = new("./Lab5/output.txt");
        output.WriteLine($"ERROR: {error}");
        Console.WriteLine($"ERROR: {error}");
    }

}
