using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    public class Seat
    {
        private bool available;

        public bool Available { get => available; set => available = value; }

        private ushort rowNumber
        {
            get => default;
            set
            {
            }
        }

        private string letter
        {
            get => default;
            set
            {
            }
        }

        private Ticket ticket
        {
            get => default;
            set
            {
            }
        }

        private Flight Flight
        {
            get => default;
            set
            {
            }
        }

    }
}