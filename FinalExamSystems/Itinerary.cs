using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    public class Itinerary
    {
        private Customer customer;

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

    }
}