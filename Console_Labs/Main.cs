internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите номер лаб.работы: ");

        string choice = Console.ReadLine() ?? string.Empty;

        switch (choice)
        {
            case "1":
                {
                    Lab1.Student_Information();
                    Lab1.Calculation();
                    break;
                }

            case "2":
                {
                    Lab2.Calculation();
                    break;
                }
            case "3":
                {
                    Lab3.Calculation();
                    break;
                }
            default:
                {
                    Console.WriteLine("Такой лаб.работы нет.");
                    break;
                }
        }
    }
}