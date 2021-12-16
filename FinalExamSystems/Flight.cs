using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  This Flight class applies the Information Expert pattern. This is because the Flight class aggregates all the seats in the Flight in the seats field, therefore because it has all the information of the seats, the method of getting available seats in Flight (GetAvailableSeats) is defined in the Flight class (information expert)
    /// </summary>
    public class Flight
    {
        private DateTime departureTime
        {
            get => default;
            set
            {
            }
        }

        private DateTime duration
        {
            get => default;
            set
            {
            }
        }

       
        private FinalExamSystems.Seat[] seats
        {
            get => default;
            set
            {
            }
        }

        private Route route
        {
            get => default;
            set
            {
            }
        }

        private FlightClass flightClass
        {
            get => default;
            set
            {
            }
        }

        private string flightNumber
        {
            get => default;
            set
            {
            }
        }

        private string status
        {
            get => default;
            set
            {
            }
        }
        /// <summary>
        ///  This method gets the seats that are available, it is in the Flight class as the Flight is the information expert with all the seat information
        /// </summary>
        private FinalExamSystems.Seat[] GetAvailableSeats()
        {
            return Array.FindAll(seats, seat => seat.Available);
        }

    }
}