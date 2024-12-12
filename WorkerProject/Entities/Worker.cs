using System;

using WorkerProject.Entities.Enums;

namespace WorkerProject.Entities;

// classe e construtor primario
//class Worker (string name, WorkerLevel level, double baseSalary, Department department)
//{
//    public string Name { get; set; } = name;
//    public WorkerLevel Level { get; set; } = level;
//    public double BaseSalary { get; set; } = baseSalary;
//    public Department Department { get; set; } = department;
//    public List<HourContract> Contracts { get; set; } = new List<HourContract>();

    // classe
    class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }
    public Department Department { get; set; }
    public List<HourContract> Contracts { get; set; } = new List<HourContract>();

    // construtor vazio
    public Worker()
    {
    }

    // construtor
    public Worker(string name, WorkerLevel level, double baseSalary, Department department)
    {

        Name = name;
        Level = level;
        BaseSalary = baseSalary;
        Department = department;

    }


    // metodos
    public void AddContract(HourContract contract) // adiciona contrato
    {

        Contracts.Add(contract);

    }
    public void RemoveContract(HourContract contract) // remove contrato
    {

        Contracts.Remove(contract);
    }

    public double Income(int year, int month) // calcula o salario no ano
    {
        double sum = BaseSalary;
        foreach (HourContract contract in Contracts)
        {
            if (contract.Date.Year == year && contract.Date.Month == month)
            {
                sum += contract.TotalValue();
            }
        }
        return sum;

    }
}

