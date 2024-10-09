using SoftwareHierarchy;

public class Lab8
{
    public static void Calculation()
    {
        Software[] softwareList =
        [
            new OS("ArchLinux", "2024.10.01", OSType.Free),
            new OS("Windows 11", "24H2", OSType.Proprietary),
            new Application("Visual Studio Code", "2024"),
            new Application("Photoshop", "CC 2016"),
        ];

        string result = "";
        foreach (var software in softwareList)
        {
            result += software.Info();
            result += "\n\n";
        }

        WriteResult(result);
    }


    private static void WriteResult(string result)
    {
        using StreamWriter output = new("./Lab8/output.txt");

        output.WriteLine(result);
    }
}
