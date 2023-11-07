using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSDK.Interface;
using TravelSDK.Model.TicketingCompany;

namespace TravelSDK.Service
{
    /// <summary>
    /// Service to fetch the Ticketing company details
    /// </summary>
    public class TicketingCompanyService : ITicketingCompanyData
    {
        private readonly List<TicketingCompany> mData = new List<TicketingCompany>();

        public TicketingCompanyService() 
        {
            mData.Add(new TicketingCompany() { Id = 1, Name = "The Flight Service" });
            mData.Add(new TicketingCompany() { Id = 2, Name = "The Car Service" });
            mData.Add(new TicketingCompany() { Id = 3, Name = "The Train Service" });
        }

        /// <summary>
        /// Retrieves Ticketing company by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TicketingCompany? Get(string name) => mData.FirstOrDefault(i => i.Name == name);

        /// <summary>
        /// Retrieves all Ticketing Companies
        /// </summary>
        /// <returns></returns>
        public TicketingCompany[] GetAll()
        {
            return mData.ToArray();
        }
    }
}
