using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// The Seat class is a instance of an individual Seat in a flight
    /// </summary>
    public class Seat
    {
        /// <summary>
        /// The Available property is a boolean that represents if the seat is taken or available
        /// </summary>
        public bool Available { get; set; }

        /// <summary>
        /// The RowNumber property is a number representing the row of the seat
        /// </summary>
        public ushort RowNumber
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The Letter property is a letter representing the letter of the seat
        /// </summary>
        public string Letter
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The Ticket property is a association to the ticket that has been purchased for this seat
        /// </summary>
        public Ticket Ticket
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// The Flight property is a association to the Flight that this seat instance belongs to
        /// </summary>
        public Flight Flight
        {
            get => default;
            set
            {
            }
        }
    }
}