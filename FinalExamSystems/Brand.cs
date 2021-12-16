using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// Brand class define a brand for and airline, allows to link different planes to an airline
    /// </summary>
    public class Brand
    {
        private string name;

        /// <summary>
        /// Name property provides a mame for the airline brand 
        /// </summary>
        public string Name
        {
            get => name; set => name = value;
        }

        /// <summary>
        /// Planes property link all the planes created under the brand name
        /// </summary>
        public FinalExamSystems.Plane[] Planes
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// Flights property keeps the tracking on all the flights scheduled for a brand 
        /// </summary>
        public FinalExamSystems.Flight[] Flights
        {
            get => default;
            set
            {
            }
        }

    }
}