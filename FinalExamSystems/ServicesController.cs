using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// Service Controller base class for applying Controller design pattern
    /// </summary>
    public abstract class ServicesController
    {
        /// <summary>
        /// CollectUserData method signature to be implemented
        /// </summary>
        public abstract void CollectUserData();

        /// <summary>
        /// LinkServiceToUser method signature to be implemented
        /// </summary>
        public abstract void LinkServiceToUser();
    }
}