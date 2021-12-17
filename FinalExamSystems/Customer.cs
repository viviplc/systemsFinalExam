using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  Customer class implements the Observer design pattern, keeping tracking on the timeout over a reservation
    /// </summary>
    public class Customer : User, ICustomer
    {

        /// <summary>
        /// FirsName property
        /// </summary>
        public String FirstName
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Last Name property
        /// </summary>
        public String LastName
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Birthdate property
        /// </summary>
        public DateTime Birthdate
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Gender property
        /// </summary>
        public String Gender
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Phone property
        /// </summary>
        public ushort Phone
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Email property
        /// </summary>
        public string Email
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Password Property
        /// </summary>
        public string Password
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// PaymentMEthods property
        /// </summary>
        public FinalExamSystems.CreditCard[] PaymentMethods
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// ItineraryHistoric property
        /// </summary>
        public FinalExamSystems.Itinerary[] ItineraryHistoric
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Reservation property
        /// </summary>
        public Itinerary Reservation
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Method to update the information on the customer about the timeout of the reservation set to 15 minutes
        /// </summary>
        /// <param name="itinerary">Itinerary saves the last status of the timeout</param>
        public void Update(Itinerary itinerary)
        {
            //logic to handle the change of status of the reservation unavailable, update the view.
            Console.WriteLine("Customer notified");
        }
    }
}