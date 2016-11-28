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
    public class Sale
    {
        [ForeignKey("Product")]
        public int ID { get; set; }
        public string SaleName { get; set; }
        public int SaleSum { get; set; }

        public virtual Product Product { get; set; }
    }
}
