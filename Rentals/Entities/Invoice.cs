﻿using System.Globalization;

namespace Rentals.Entities;

class Invoice
{
    public double BasicPayment { get; set; }
    public double Tax { get; set; }
    
    public Invoice (double rental, double tax)
    {
        BasicPayment = rental;
        Tax = tax;
    }

    public double TotalPayment
    {
        get { return BasicPayment + Tax; }
    }

    public override string ToString()
    {
        return $"Basic payment:{BasicPayment.ToString("F2")} \nTax:{Tax.ToString("F2")} \nTotal payment: {TotalPayment.ToString("F2")}";
    }
}
