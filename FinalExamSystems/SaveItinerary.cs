using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// Implementing Pure Fabrication / facace desgin pattern
    /// Concrete PersistanceStorage class dedicated to handle the itinerary DB access and storage
    /// </summary>
    public class SaveItinerary : PersistanceStorage
    {
       /// <summary>
       /// method definition to save an itinerary on DB
       /// </summary>
       /// <param name="o">object to be replaced by an itinerary</param>
       /// <returns>insert return a bool as true if the transaction is successful, false in case of an error</returns>
        public override bool insert(object o)
        {
            //DB handle implementation - logic to save itinerary on DB
            return true;
        }

        /// <summary>
        /// method definition to update an itinerary on DB
        /// </summary>
        /// <param name="o">object to be replaced by an itinerary</param>
        /// <returns>update return a bool as true if the transaction is successful, false in case of an error</returns>
        public override bool update(object o)
        {
            //DB handle implementation - logic to update itinerary on DB
            return true;
        }
    }
}