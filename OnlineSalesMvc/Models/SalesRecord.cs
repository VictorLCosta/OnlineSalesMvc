using OnlineSalesMvc.Models.Enums;
using System;

namespace OnlineSalesMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public double Amount { get; private set; }
        public Seller Seller { get; private set; }
        public SaleStatus Status { get; private set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, Seller seller, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
            Status = status;
        }
    }
}
