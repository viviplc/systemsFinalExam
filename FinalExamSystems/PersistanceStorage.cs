using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// Persistance Storage base class 
    /// Implementation of Pure Fabrication / Facade desgin pattern
    /// </summary>
    public abstract class PersistanceStorage
    {
        /// <summary>
        /// method for inserting on DB an object
        /// </summary>
        /// <param name="o"> Object to be defined and inserted on DB</param>
        /// <returns></returns>
        public abstract bool insert(Object o);

        /// <summary>
        /// method for updateing on DB and object
        /// </summary>
        /// <param name="o">Object to be defined and updated on DB</param>
        /// <returns></returns>
        public abstract bool update(Object o);

    }
}