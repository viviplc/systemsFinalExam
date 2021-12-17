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

        public DateTime departureDate
        {
            get => default;
            set
            {
            }
        }

        public DateTime returnDate
        {
            get => default;
            set
            {
            }
        }

        public double totalPrice
        {
            get => default;
            set
            {
            }
        }

        public CreditCard paymentMehod
        {
            get => default;
            set
            {
            }
        }

        public ItineraryType type
        {
            get => default;
            set
            {
            }
        }

        public Airport origin
        {
            get => default;
            set
            {
            }
        }

        public Airport destination
        {
            get => default;
            set
            {
            }
        }

        public FinalExamSystems.Passenger[] passengers
        {
            get => default;
            set
            {
            }
        }

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