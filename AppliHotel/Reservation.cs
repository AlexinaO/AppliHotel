using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliHotel
{
    class Reservation
    {
        public DateTime DateDebut { get; set}
        public int NbNuitees { get; set; }

        public Client Client { get; set; }
        public Chambre Chambre { get; set; }
    }
}
