using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSDK.Model.Agency;

namespace TravelSDK.Interface
{
    internal interface ITravelAgencyData
    {
        TravelAgency[] GetAll();
        TravelAgency? Get(string agencyName);
    }
}
