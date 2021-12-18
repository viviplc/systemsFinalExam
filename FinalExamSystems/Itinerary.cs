using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// Itinerary class implements the observer design pattern allowing to keep tracking on its timeout property
    /// </summary>
    public class Itinerary
    {
        private Customer customer;
        private bool timeout;

        /// <summary>
        ///  DepartureDate property is Date and Time of Departure of Customer for trip
        /// </summary>
        public DateTime DepartureDate
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  ReturnDate property is Date and Time of Return of Customer for trip
        /// </summary>
        public DateTime ReturnDate
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  TotalPrice property is total cost of the itinerary
        /// </summary>
        public double TotalPrice
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  PaymentMethod property payment method of the itinerary
        /// </summary>
        public CreditCard PaymentMethod
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Type property for type of the itinerary
        /// </summary>
        public ItineraryType Type
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Origin property for the origin Airport
        /// </summary>
        public Airport Origin
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Destination property for the destination Airport
        /// </summary>
        public Airport Destination
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Passengers property for all the passengers in the itinerary 
        /// </summary>
        public FinalExamSystems.Passenger[] Passengers
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Customer property for the Customer creating the itinerary 
        /// </summary>
        public Customer Customer
        {
            get => customer; set => customer = value;
        }

        /// <summary>
        /// Observer pattern implementation
        /// Timeout property send the notification when its value is updated
        /// </summary>
        public bool Timeout {
            get { return timeout; }
            set 
            {
                if (timeout != value)
                {
                    timeout = value;
                    //calls the method to notify customer interested
                    Notify();
                }

            }
        }

        /// <summary>
        /// Observer pattern implementation
        /// Notify method notify the customer who is interested on the itinerary on reservation process about any change
        /// </summary>
        public void Notify()
        {
            customer.Update(this);
        }

    }
}