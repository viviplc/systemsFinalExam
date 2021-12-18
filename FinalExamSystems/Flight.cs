using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// This is the Flight class which is an instance of a Plane that is taking a Route from one Airport to another Airport
    ///  This Flight class applies the Information Expert pattern. This is because the Flight class aggregates all the seats in the Flight in the seats field, therefore because it has all the information of the seats, the method of getting available seats in Flight (GetAvailableSeats) is defined in the Flight class (information expert)
    /// </summary>
    public class Flight
    {
        /// <summary>
        ///  This property defines the departure time of the flight
        /// </summary>
        public DateTime DepartureTime
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property defines the total duration of the flight
        /// </summary>
        public DateTime Duration
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property contains all the Seats of the Flight
        /// </summary>
        public FinalExamSystems.Seat[] Seats
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property defines the Route of the flight 
        /// </summary>
        public Route Route
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property defines the class of Flight
        /// </summary>
        public FlightClass FlightClass
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property defines the flight number of the current instance
        /// </summary>
        public string FlightNumber
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This property defines the status that the flight is currently in
        /// </summary>
        public string Status
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  This method gets the seats that are available, it is in the Flight class as the Flight is the information expert with all the seat information
        /// </summary>
        public FinalExamSystems.Seat[] GetAvailableSeats()
        {
            return Array.FindAll(Seats, seat => seat.Available);
        }
    }
}