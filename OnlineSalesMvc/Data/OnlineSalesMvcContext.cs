using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineSalesMvc.Models;

namespace OnlineSalesMvc.Data
{
    public class OnlineSalesMvcContext : DbContext
    {
        public OnlineSalesMvcContext (DbContextOptions<OnlineSalesMvcContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineSalesMvc.Models.Department> Department { get; set; }
    }
}
