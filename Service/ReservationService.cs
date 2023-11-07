using System;
using TravelSDK.Interface;
using TravelSDK.Model.Ticket;

namespace TravelSDK.Service
{
    /// <summary>
    /// Service to Reserve a Travel ticket
    /// </summary>
    public class ReservationService : IReservation
    {
        public ReservationService() { }

        /// <summary>
        /// Reserves a ticket
        /// </summary>
        /// <param name="request">Reservation information</param>
        /// <returns></returns>
        public Ticket Reserve(ReservationRequest request)
        {
            var ticket = new Ticket()
            {
                Id = request.Id,
                Agency = request.Agency,
                TicketingCompany = request.TicketingCompany,
                BookingConfirmationNumber = Guid.NewGuid().ToString(),
                Destination = request.Destination,
                EndDate = request.EndDate,
                Origin = request.Origin,
                Passengers = request.Passengers,
                StartDate= request.StartDate
            };

            return ticket;
        }
    }
}
