using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }   
        public Double Price { get; set; }

        public Product (int id, String name, Double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
