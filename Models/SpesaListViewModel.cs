using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ProgettoSpesa.Models
{
    public class SpesaListViewModel
    {
        public List<SpesaListViewModel> SpesaLista { get; private set; }
        public SpesaListViewModel()
        {
            this.SpesaLista = new List<SpesaListViewModel>();
        }
    }
}
