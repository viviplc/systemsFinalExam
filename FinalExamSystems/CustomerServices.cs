using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// Class use PersistanceStorage derived classes to storage on DB any change linked to any Customer Service provided 
    /// -- Implementing Pure Fabrication/Facade Design pattern
    /// CustomerServices inherits from Service 
    /// </summary>
    public class CustomerServices : Service
    {
        /// <summary>
        /// Instance of save Itinerary Persisntance Storage derived class
        /// -- Implementing Pure FAbrication/Facade Design Pattern
        /// </summary>
        private SaveItinerary persistance = new SaveItinerary();
        /// <summary>
        /// Constructor CustomerServices
        /// </summary>
        public CustomerServices()
        {
        }

        /// <summary>
        /// SaveItinerary property
        /// </summary>
        public SaveItinerary SaveItinerary
        {
            get => persistance; set => persistance = (SaveItinerary)value;
        }

        /// <summary>
        /// IPaymentServiceAdapter property
        /// </summary>
        public IPaymentServiceAdapter IPaymentServiceAdapter
        {
            get => default;
            set
            {
            }
        }



        /// <summary>
        /// Search Fligth method looks for a flight using the parameters defined
        /// </summary>
        /// <param name="origin">Origin parameter is mandatory</param>
        /// <param name="destination">Destination parameter is mandatory</param>
        /// <param name="departureDate">Departure Date parameter is optional</param>
        /// <param name="returnDate">Return Date is optional</param>
        /// <returns>Returns a list of flights which accomplish criteria</returns>
        public List<Flight> searchFlight(string origin, string destination, DateTime departureDate, DateTime returnDate)
        {
            List<Flight> flights = new List<Flight>();
            //logic to fullfill the flights available following the search criteria
            return flights;
        }

        /// <summary>
        /// Reserve ticket method save the ticket for the customer under the itinerary instance on the reservation
        /// </summary>
        public void ReserveTicket()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Reserve ticket method save the ticket for the customer under the itinerary instance on the itineraryhistoric
        /// </summary>
        public void PurchaseTicket()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Cancel ticket method dettach the ticket from the itinerary selected by customer
        /// </summary>
        public void CancelTicket()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// SaveCustomerItinerary save on DB the itineary linked to a customer
        /// Pure Fabrication / Facade desgin pattern implementation
        /// </summary>
        /// <param name="itinerary"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool saveCustomerItinerary(Itinerary itinerary, Customer customer)
        {
            //link the customer to itinerary
            itinerary.Customer = customer;
            //calling the method to save it on DB
            return persistance.insert(itinerary);

        }
    }

}