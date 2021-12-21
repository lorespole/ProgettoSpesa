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
        public long Id { get; set; }
        public string Prodotto { get; set; }
        public int Quantita { get; set; }
        public decimal Prezzo { get; set; }
    }
}
