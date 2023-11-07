using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSDK.Model.Ticket;

namespace TravelSDK.Interface
{
    public interface IReservation
    {
        Ticket Reserve(ReservationRequest request); 
    }
}
