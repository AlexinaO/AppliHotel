using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliHotel
{
    class Hotel
    {
        public string NomHotel { get; set; }
        public string AdresseHotel { get; set; }

        public List<Chambre> Chambres { get; set; }
    }
}
