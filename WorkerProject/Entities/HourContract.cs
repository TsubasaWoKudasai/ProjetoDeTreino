﻿using System;

namespace WorkerProject.Entities;

// construtor primario :
// class HourContract (DateTime date, double valuePerHour, int hours)
//{
//    public DateTime Date { get; set; } = date;
//    public double ValuePerHour { get; set; } = valuePerHour;
//    public int Hours { get; set; } = hours;
//}

// classe :
class HourContract
{
    public DateTime Date { get; set; }
    public double ValuePerHour { get; set; }
    public int Hours { get; set; }


    // construtores :
    public HourContract()
    {
    }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
        Date = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }

    public double TotalValue()
    {
        return Hours * ValuePerHour;
    }
}


