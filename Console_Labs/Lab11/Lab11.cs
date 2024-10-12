public class Lab11
{
    public static void Calculation()
    {
        static List<Employee> LoadEmployees(string filePath)
        {
            var employees = new List<Employee>();

            var lines = File.ReadAllLines(filePath).Skip(1);
            foreach (var line in lines)
            {
                var parts = line.Split(',');

                var employee = new Employee
                {
                    ID = int.Parse(parts[0]),
                    Name = parts[1],
                    Salary = decimal.Parse(parts[2]),
                    Tax = decimal.Parse(parts[3]),
                    Skill = parts[4],
                    Email = parts[5]
                };

                employees.Add(employee);
            }

            return employees;
        }
        var employees = LoadEmployees("./Lab11/employees.txt");

        var result = new System.Text.StringBuilder();

        result.AppendLine("1. Сотрудник с минимальной зарплатой и минимальной зарплатой после налогов");

        var minSalaryEmployee = employees.OrderBy(e => e.Salary).First();
        var minAfterTaxEmployee = employees.OrderBy(e => e.SalaryAfterTax).First();

        result.AppendLine($"Сотрудник с минимальной зарплатой: {minSalaryEmployee.Name} ({minSalaryEmployee.Salary} руб.)");
        result.AppendLine($"Сотрудник с минимальной зарплатой после налогов: {minAfterTaxEmployee.Name} ({minAfterTaxEmployee.SalaryAfterTax} руб.)");

        result.AppendLine("2. Количество сотрудников без навыков (Skill)");
        int noSkillCount = employees.Count(e => string.IsNullOrWhiteSpace(e.Skill));
        result.AppendLine($"Количество сотрудников без навыков: {noSkillCount}");

        result.AppendLine("3. Средняя зарплата для сотрудников с e-mail и без");
        var avgSalaryWithEmail = employees.Where(e => !string.IsNullOrWhiteSpace(e.Email)).Average(e => e.Salary);
        var avgSalaryWithoutEmail = employees.Where(e => string.IsNullOrWhiteSpace(e.Email)).Average(e => e.Salary);

        result.AppendLine($"Средняя зарплата с e-mail: {avgSalaryWithEmail:F2} руб.");
        result.AppendLine($"Средняя зарплата без e-mail: {avgSalaryWithoutEmail:F2} руб.");

        result.AppendLine("4. Сумма налога по всей выборке");
        decimal totalTax = employees.Sum(e => e.Tax);
        result.AppendLine($"Сумма налога по всей выборке: {totalTax} руб.");

#if DEBUG
        Console.WriteLine(result.ToString());
#else
        WriteResult(result.ToString());
#endif
    }

    private static void WriteResult(string result)
    {
        using StreamWriter output = new("./Lab11/output.txt");

        output.WriteLine(result);
    }
}