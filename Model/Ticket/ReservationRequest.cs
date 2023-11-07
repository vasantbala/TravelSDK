using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSDK.Model.Agency;
using TravelSDK.Model.TicketingCompany;

namespace TravelSDK.Model.Ticket
{
    public class ReservationRequest
    {
        public Guid Id { get; set; }
        public TravelAgency Agency { get; set; }
        public TicketingCompany.TicketingCompany TicketingCompany { get; set; }
        public Passenger[] Passengers { get; set; }
        public Place Destination { get; set; }
        public Place Origin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
