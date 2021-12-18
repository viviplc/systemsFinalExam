using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  Route class represents a route from an origin Airport to the destination Airport
    /// </summary>
    public class Route
    {
        /// <summary>
        ///  Origin property is the origin Airport 
        /// </summary>
        public Airport Origin
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Destination property is the Destination Airport 
        /// </summary>
        public Airport Destination
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Flights property is the list of Flights taking this Route
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