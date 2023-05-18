using System;

class Employee
{
    public int Id { get; set; }
    public string Emri { get; set; } = string.Empty;
    public string Pozita { get; set; } = string.Empty;
    public double Rroga { get; set; }

    public virtual double CalculateBonus(double rroga)
    {
        return 50000;
    }
}

class Zhvillues : Employee
{
    public override double CalculateBonus(double rroga)
    {
        double perqindja = rroga * 0.2;
        double bonusiFix = 50000;

        return Math.Max(bonusiFix, perqindja);
    }
}

class Menaxher : Employee
{
    public override double CalculateBonus(double rroga)
    {
        double perqindja = rroga * 0.25;
        double bonusiFix = 50000;

        return Math.Max(bonusiFix, perqindja);
    }
}

class Admin : Employee
{
    public override double CalculateBonus(double rroga)
    {
        return 50000;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Shkruani te dhenat e puntorit:");

        Console.Write("Emri: ");
        string? emri = Console.ReadLine();

        Console.Write("Pozita (Zhvillues/Menaxher/Admin): ");
        string? pozita = Console.ReadLine();

        Console.Write("Rroga: ");
        string? rrogaInput = Console.ReadLine();
        double rroga;

        if (!double.TryParse(rrogaInput, out rroga))
        {
            Console.WriteLine("Vlera e rroges eshte invalide!");
            return;
        }

        Employee employee;

        if (pozita?.ToLower() == "zhvillues")
        {
            employee = new Zhvillues();
        }
        else if (pozita?.ToLower() == "menaxher")
        {
            employee = new Menaxher();
        }
        else if (pozita?.ToLower() == "admin")
        {
            employee = new Admin();
        }
        else
        {
            Console.WriteLine("Pozita eshte invalide!");
            return;
        }

        employee.Id = 1;
        employee.Emri = emri;
        employee.Pozita = pozita;
        employee.Rroga = rroga;

        Console.WriteLine();

        Console.WriteLine($"Puntori: {employee.Emri} ({employee.Pozita})");
        Console.WriteLine($"Rroga: {employee.Rroga:C}");
        Console.WriteLine($"Bonus: {employee.CalculateBonus(employee.Rroga):C}");

        Console.ReadLine();
    }
}
