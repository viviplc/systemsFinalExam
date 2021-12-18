using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  Ticket class represents a ticket of a passenger
    /// </summary>
    public class Ticket
    {
        /// <summary>
        ///  Price property represents the cost of the ticket
        /// </summary>
        public double Price
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Passenger property represents the passenger who owns this ticket
        /// </summary>
        public Passenger Passenger
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Status property represents the status of the ticket
        /// </summary>
        public TicketStatus Status
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Type property represents the type of the ticket
        /// </summary>
        public TicketType Type
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Insurance property represents the insurance that was purchased with the ticket
        /// </summary>
        public CancellationInsurance Insurance
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Seat property represents the seat of the passenger booked in the ticket
        /// </summary>
        public Seat Seat
        {
            get => default;
            set
            {
            }
        }
    }
}