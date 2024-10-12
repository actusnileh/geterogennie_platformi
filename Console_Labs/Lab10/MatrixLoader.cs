public static class MatrixLoader
{
    public static int[,] LoadMatrix(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        int rowCount = lines.Length;
        int colCount = lines[0].Split(' ').Length;

        int[,] matrix = new int[rowCount, colCount];

        for (int i = 0; i < rowCount; i++)
        {
            var values = lines[i].Split(' ');
            for (int j = 0; j < colCount; j++)
            {
                matrix[i, j] = int.Parse(values[j]);
            }
        }

        return matrix;
    }
}