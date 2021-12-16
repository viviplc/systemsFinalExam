using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  This Airline class applies the Singleton pattern. Because this is an Airline Reservation System, that is meant for a single airline, we decided to apply to singleton pattern to the airline class, meaning there will only be one instance of the Airline class.
    /// </summary>
    public class Airline
    {
        /// <summary>
        ///  This is the private field that will contain the single instance of the airline class
        /// </summary>
        static Airline airlineInstance;

        /// <summary>
        ///  This is the constructor for the Airline class which cannot be instantiated directly as it is protected
        /// </summary>
        protected Airline()
        {
        }

        /// <summary>
        ///  This method returns the singleton instance of the Airline class, if it does not exist it instantiates an instance (this happens only once)
        /// </summary>
        public static Airline AirlineInstance()
        {
            if (airlineInstance == null)
            {
                airlineInstance = new Airline();
            }
            return airlineInstance;
        }
        private string name
        {
            get => default;
            set
            {
            }
        }

        private FinalExamSystems.Brand[] brands
        {
            get => default;
            set
            {
            }
        }

        private CancellationPolicy cancellationPolicy
        {
            get => default;
            set
            {
            }
        }

        private FinalExamSystems.Employee[] employees
        {
            get => default;
            set
            {
            }
        }
    }
}