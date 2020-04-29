using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineSalesMvc.Models;


namespace OnlineSalesMvc.Services
{
    public class SellerService
    {
        private readonly OnlineSalesMvcContext _context;

        public SellerService(OnlineSalesMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj) 
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
