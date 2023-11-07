using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSDK.Model.TicketingCompany;

namespace TravelSDK.Interface
{
    public interface ITicketingCompanyData
    {
        TicketingCompany[] GetAll();
        TicketingCompany? Get(string name);
    }
}
