public class Segment
{
    private double X1, X2, Y1, Y2;

    public Segment(double x1, double y1, double x2, double y2)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }
    public double GetLength()
    {
        return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
    }
    public double DistanceFromStart()
    {
        return Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
    }
    public double DistanceFromEnd()
    {
        return Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
    }
    public string PrintInfo()
    {
        string result;
        result = $"Отрезок: начало ({X1}, {Y1}), конец ({X2}, {Y2})\n";
        result += $"Длина отрезка: {GetLength()}\n";
        result += $"Расстояние начала отрезка от начала координат: {DistanceFromStart()}\n";
        result += $"Расстояние конца отрезка от начала координат: {DistanceFromEnd()}\n";

        return result;
    }
}