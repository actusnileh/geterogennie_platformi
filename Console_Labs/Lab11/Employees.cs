public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public decimal Tax { get; set; }
    public string Skill { get; set; }
    public string Email { get; set; }

    public decimal SalaryAfterTax => Salary - Tax;
}

