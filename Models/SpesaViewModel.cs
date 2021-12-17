using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgettoSpesa.Models
{
    public class SpesaViewModel
    {
     [Required]
        public long id { get; set; }
        public string prodotto { get; set; }
        public int quantita { get; set; }
        public decimal prezzo { get; set; }
    }
}
