using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// Observer pattern implementation
    /// Customer Interface
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// update method to be implemented
        /// </summary>
        /// <param name="itinerary"></param>
        public void Update(Itinerary itinerary);
    }
}