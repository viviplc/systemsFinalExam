using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  User class represents a user of the airline reservation system
    /// </summary>
    public abstract class User
    {
        /// <summary>
        ///  Ip property represents a the ip of a user which would be used to get their location, mainly to provide Customers and Potential Customers with localized information
        /// </summary>
        public string Ip
        {
            get => default;
            set
            {
            }
        }
    }
}