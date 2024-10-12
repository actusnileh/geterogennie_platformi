public static class DiagonalCalculator
{
    public static int CalculateEvenColumnDiagonalSum(int[,] matrix)
    {
        int sum = 0;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int col = 0; col < cols; col += 2)
        {
            for (int row = 0; row < rows; row++)
            {
                if (row == col)
                {
                    sum += matrix[row, col];
                }
            }
        }

        return sum;
    }
}