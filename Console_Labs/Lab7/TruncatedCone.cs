public class TruncatedCone
{
    private double r1; // Большой радиус
    private double r2; // Малый радиус
    private double height;

    public TruncatedCone()
    {
        r1 = 1;
        r2 = 1;
        height = 1;
    }

    public TruncatedCone(double r1, double r2, double height)
    {
        this.r1 = r1;
        this.r2 = r2;
        this.height = height;
    }

    public TruncatedCone(double radius, double height)
    {
        r1 = radius;
        r2 = radius;
        this.height = height;
    }

    public void InputData()
    {
        Console.WriteLine("Введите большой радиус:");
        r1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите малый радиус:");
        r2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту:");
        height = Convert.ToDouble(Console.ReadLine());
    }

    public void InputData(double r1, double r2, double height)
    {
        this.r1 = r1;
        this.r2 = r2;
        this.height = height;
    }

    public double CalculateVolume()
    {
        return (1.0 / 3) * Math.PI * height * (r1 * r1 + r1 * r2 + r2 * r2);
    }

    public double CalculateSurfaceArea()
    {
        double slantHeight = Math.Sqrt(Math.Pow(r1 - r2, 2) + height * height);
        return Math.PI * (r1 + r2) * slantHeight + Math.PI * (r1 * r1 + r2 * r2);
    }

    public string PrintInfo()
    {
        string result = "Усеченный конус:\n";

        result += $"Большой радиус: {r1}\n";
        result += $"Малый радиус: {r2}\n";
        result += $"Высота: {height}\n";
        result += $"Объем: {CalculateVolume()}\n";
        result += $"Площадь поверхности: {CalculateSurfaceArea()}\n";

        return result;
    }
}