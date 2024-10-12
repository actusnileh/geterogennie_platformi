public class Human : ICalculate, IVisual
{
    public Human(string pFIO, int pAge)
    {
        FIO = pFIO;
        Age = pAge;
    }
    private string FIO;
    private int Age;

    public string Name
    {
        get
        {
            return FIO + " : " + Age.ToString();
        }
        set
        {
            FIO = value;
        }
    }

    public void Plus(int pPlus)
    {
        Age += pPlus;
    }

    public void Minus(int pMinus)
    {
        Age -= pMinus;
    }

    public void DrawObject()
    {
        Console.WriteLine(
            "   0   \n" +
            " ----- \n" +
            "   |   \n" +
            "  / \\ \n"
        );
        Console.WriteLine(Name);
    }
}

public class Car : ICalculate, IVisual
{
    public Car(string pManufacturer, string pModel, int pVelocity)
    {
        Manufacturer = pManufacturer;
        Model = pModel;
        Velocity = pVelocity;
    }
    private string Manufacturer;
    private string Model;
    private int Velocity;

    public string Name
    {
        get
        {
            return Manufacturer + " - " + Model + " : " + Velocity.ToString() + "km/h";
        }
        set
        {
            Model = value;
        }
    }

    public void DrawObject()
    {
        Console.WriteLine(
            "      --------      \n" +
            "     /        \\     \n" +
            " ----         ------   \n" +
            "|                   |  \n" +
            " -----(@)------(@)--    \n"
            );
        Console.WriteLine(Name);
    }

    public void Plus(int pPlus)
    {
        Velocity += pPlus;
    }

    public void Minus(int pMinus)
    {
        Velocity -= pMinus;
    }
}