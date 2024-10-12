
public class Lab10
{
    public static void Calculation()
    {
        var matrix1 = MatrixLoader.LoadMatrix("./Lab10/matrix1.txt");
        var matrix2 = MatrixLoader.LoadMatrix("./Lab10/matrix2.txt");

        int sum1 = DiagonalCalculator.CalculateEvenColumnDiagonalSum(matrix1);
        int sum2 = DiagonalCalculator.CalculateEvenColumnDiagonalSum(matrix2);

        Console.WriteLine($"Сумма диагональных элементов четных столбцов первой матрицы: {sum1}");
        Console.WriteLine($"Сумма диагональных элементов четных столбцов второй матрицы: {sum2}");

        WriteResult($"Сумма диагональных элементов четных столбцов первой матрицы: {sum1}\nСумма диагональных элементов четных столбцов второй матрицы: {sum2}");
    }
    private static void WriteResult(string result)
    {
        using StreamWriter output = new("./Lab10/output.txt");

        output.WriteLine(result);
    }
}