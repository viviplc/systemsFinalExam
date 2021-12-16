using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// CustomerServices inherits from Service 
    /// </summary>
    public class CustomerServices : Service
    {
        public CustomerServices()
        {
        }


        /// <summary>
        /// Search Fligth method looks for a flight using the parameters defined
        /// </summary>
        /// <param name="origin">Origin parameter is mandatory</param>
        /// <param name="destination">Destination parameter is mandatory</param>
        /// <param name="departureDate">Departure Date parameter is optional</param>
        /// <param name="returnDate">Return Date is optional</param>
        /// <returns>Returns a list of flights which accomplish criteria</returns>
        public List<Flight> searchFlight(string origin, string destination,DateTime departureDate,DateTime returnDate)
        {
            List<Flight> flights = new List<Flight>();
            //logic to fullfill the flights available following the search criteria
            return flights;
        }

        public void ReserveTicket()
        {
            throw new System.NotImplementedException();
        }

        public void PurchaseTicket()
        {
            throw new System.NotImplementedException();
        }

        public void CancelTicket()
        {
            throw new System.NotImplementedException();
        }
    }
}