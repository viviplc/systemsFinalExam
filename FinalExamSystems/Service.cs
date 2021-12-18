using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  Service class represents the abstract class for the services Users (Employees, Customers, Potential Customers) can use
    /// </summary>
    public abstract class Service
    {
        private string idService;

        /// <summary>
        ///  IdService property represents the id of the Service
        /// </summary>
        public string IdService { get => idService; set => idService = value; }
    }
}