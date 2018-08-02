using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AppliHotel
{
    public class Chambre
    {
        public string NumeroChambre { get; set; }
        public int NbLits { get; set; }
        public double PrixNuitee { get; set; }

        public List<Reservation> Reservations { get; set; }
        public Hotel Hotel { get; set; }
    }
}
