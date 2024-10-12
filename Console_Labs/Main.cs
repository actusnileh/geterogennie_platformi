internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите номер лаб.работы (1-11): ");

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
            case "4":
                {
                    Lab4.Calculation();
                    break;
                }
            case "5":
                {
                    Lab5.Calculation();
                    break;
                }
            case "6":
                {
                    Lab6.Calculation();
                    break;
                }
            case "7":
                {
                    Lab7.Calculation();
                    break;
                }
            case "8":
                {
                    Lab8.Calculation();
                    break;
                }
            case "9":
                {
                    Lab9.Calculation();
                    break;
                }
            case "10":
                {
                    Lab10.Calculation();
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