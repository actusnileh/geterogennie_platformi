using System.Diagnostics;

public class Lab9
{
    public static void Calculation()
    {

        Console.Title = "Лаб Работа №9";

        Human human = new("Николаев Николай Николаевич", 31);
        human.Plus(4);
        human.Minus(5);

        human.DrawObject();

        Console.WriteLine("\n\n");

        Car car = new("Toyota", "Camry", 120);

        car.Plus(10);
        car.Minus(30);

        car.DrawObject();
    }
}