using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  ServicesHistory class represents the history of the services provided to a User
    /// </summary>
    public class ServicesHistory
    {
        private DateTime dateRegister;
        private string idRegister;

        /// <summary>
        ///  User property represents the user that used a Service
        /// </summary>
        public User User
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Service property represents the actual service 
        /// </summary>
        public Service Service
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  DateRegister property represents the date and time the service was done
        /// </summary>
        public DateTime DateRegister { get => dateRegister; set => dateRegister = value; }

        /// <summary>
        ///  IdRegister property represents the Id in the Register
        /// </summary>
        public string IdRegister { get => idRegister; set => idRegister = value; }
    }
}