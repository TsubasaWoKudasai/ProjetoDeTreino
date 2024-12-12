using System;
using WorkerProject.Entities.Enums;
using WorkerProject.Entities;

namespace WorkerProject;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter department's name : ");
        string deptName = Console.ReadLine();
        Console.WriteLine("Enter worker data : ");
        Console.Write("Name : ");
        string name = Console.ReadLine();
        Console.Write("Level ( junior / MidLevel / Senior ) : ");
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base Salary : ");
        double baseSalary = double.Parse(Console.ReadLine());

        Department dept = new Department(deptName);
        Worker worker = new Worker(name, level, baseSalary, dept);

        Console.Write("How many contracts to this worker? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter #{i} contract data : ");
            Console.Write("Date (DD/MM/YYYY) : ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value per hour: ");
            double valuePerHour = double.Parse(Console.ReadLine());
            Console.Write("Duration (hours) : ");
            int hours = int.Parse(Console.ReadLine());
            HourContract contract = new HourContract(date, valuePerHour, hours);
            worker.AddContract(contract);
        }

        Console.WriteLine();
        Console.Write("Enter Year and month to calculate income (MM/YYYY) : ");
        string monthAndYear = Console.ReadLine();
        int month = int.Parse(monthAndYear.Substring(0, 2));
        int year = int.Parse(monthAndYear.Substring(3));
        Console.WriteLine($"Name : {worker.Name}");
        Console.WriteLine($"Department {worker.Department}");
        Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");

    }
}