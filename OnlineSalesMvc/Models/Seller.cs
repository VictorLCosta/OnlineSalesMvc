﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineSalesMvc.Models
{
    public class Seller
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public double BaseSalary { get; private set; }
        public Department Department { get; private set; }
        public ICollection<SalesRecord> Sales { get; private set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr) 
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr) 
        {
            Sales.Add(sr);
        }

        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sales.Where(s => s.Date >= initial && s.Date <= final).Sum(s => s.Amount);
        }
    }
}