using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CF.Store
{
    public class Product
    {
        [ForeignKey("Sale")]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual Sale Sale { get; set; }
    }
}
