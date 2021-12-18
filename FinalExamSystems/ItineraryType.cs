using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  ItineraryType class represents a type of Itinerary
    /// </summary>
    public class ItineraryType
    {
        private string description;

        /// <summary>
        ///  Description property represents the description of the type of itinerary
        /// </summary>
        public string Description { get => description; set => description = value; }
    }
}