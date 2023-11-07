using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSDK.Interface;
using TravelSDK.Model.Agency;

namespace TravelSDK.Service
{
    /// <summary>
    /// Service to retrieve Travel Agency details
    /// </summary>
    public class TravelAgencyService : ITravelAgencyData
    {
        private readonly List<TravelAgency> mData = new List<TravelAgency>();

        public TravelAgencyService()
        {
            mData.Add(new TravelAgency() { Id = 1, Name = "Dallas Book Co." });
            mData.Add(new TravelAgency() { Id = 2, Name = "Austin Book Co." });
            mData.Add(new TravelAgency() { Id = 3, Name = "Houston Book Co." });
        }

        /// <summary>
        /// Retreives Travel Agency by name
        /// </summary>
        /// <param name="agencyName"></param>
        /// <returns></returns>
        public TravelAgency? Get(string agencyName)
        {
            return mData.FirstOrDefault(i => i.Name == agencyName);
        }


        //Retreives all Travel Agencies
        public TravelAgency[] GetAll()
        {
            return mData.ToArray();
        }
    }
}
