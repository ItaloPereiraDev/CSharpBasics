// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using ExercicioPolimorfismo.Entities;
List<Employee> employees = new List<Employee>();
Console.WriteLine("Enter the number of employees:");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data:");
    Console.WriteLine("Outsourced (y/n)?");
    char outsourced = char.Parse(Console.ReadLine());
    Console.WriteLine("Employee name:");
    string empName = Console.ReadLine();
    Console.WriteLine("Employee hours:");
    int empHours = int.Parse(Console.ReadLine());
    Console.WriteLine("Value per hour:");
    double empValuePerHour = double.Parse(Console.ReadLine());
    if (outsourced == 'y')
    {
        Console.WriteLine("Additional charge:");
        int addCharge = int.Parse(Console.ReadLine());
        employees.Add(new OutsourcedEmployee(empName, empHours, empValuePerHour, addCharge));
    }
    else
    {
        employees.Add(new Employee(empName, empHours, empValuePerHour));
    }
}
Console.WriteLine("Payments:");
foreach (Employee emp in employees)
{
    Console.WriteLine($"{emp.Name}: {emp.Payment().ToString("F2")}");
}

