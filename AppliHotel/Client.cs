using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliHotel
{
    public class Client
    {
        public string NomClient { get; set; }
        public string Prenomclient { get; set; }

        public list<Reservation> Reservations { get; set; }
    }
}
