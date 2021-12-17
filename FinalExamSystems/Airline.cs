using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// This is the Airline class, which belongs to an individual airline and manages the Brands (which have the Flights and Planes), Employees and the cancellation policies 
    ///  This Airline class applies the Singleton pattern. Because this is an Airline Reservation System, that is meant for a single airline, we decided to apply to singleton pattern to the airline class, meaning there will only be one instance of the Airline class.
    /// </summary>
    public class Airline
    {
        /// <summary>
        ///  This is the public field that will contain the single instance of the airline class
        /// </summary>
        private static Airline airlineInstance;

        /// <summary>
        ///  This is the constructor for the Airline class which cannot be instantiated directly as it is protected
        /// </summary>
        protected Airline()
        {
        }

        /// <summary>
        ///  This method returns the singleton instance of the Airline class, if it does not exist it instantiates an instance (this happens only once) and returns the instance.
        /// </summary>
        public static Airline GetAirlineInstance()
        {
            if (airlineInstance == null)
            {
                airlineInstance = new Airline();
            }
            return airlineInstance;
        }

        /// <summary>
        ///  This method returns the singleton instance of the Airline class, if it does not exist it instantiates an instance (this happens only once)
        /// </summary>
        public string Name
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property contains all the Brands in the current Airline Instance
        /// </summary>
        public FinalExamSystems.Brand[] Brands
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property contains the CancellationPolicy that the Airline is following
        /// </summary>
        public CancellationPolicy CancellationPolicy
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property contains all the Employees in the current Airline Instance
        /// </summary>
        public FinalExamSystems.Employee[] Employees
        {
            get => default;
            set
            {
            }
        }
    }
}