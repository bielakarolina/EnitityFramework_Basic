using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Customer
    {
        [Key]
        public String CompanyName { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "Money")]
        public decimal Unitprice { get; set; }

    }
}
