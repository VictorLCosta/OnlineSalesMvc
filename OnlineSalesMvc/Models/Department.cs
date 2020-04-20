using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSalesMvc.Models
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
