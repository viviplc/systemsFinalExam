using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  ProvisionServices class is the services that would be used by Employees of the Airline
    /// </summary>
    public class ProvisionServices : Service
    {
        /// <summary>
        /// AddPlaneToAirline method adds a new plane to the Airline and returns the new plane
        /// </summary>
        /// <returns>Returns a new Plane that was created</returns>
        public Plane AddPlaneToAirline()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// AddFlightClass method adds a new flight class to the Airline and returns the new flight class
        /// </summary>
        /// <returns>Returns the new Plane that was created</returns>
        public FlightClass AddFlightClass()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// ScheduleFlight method creates a new Flight instance and returns the new flight
        /// </summary>
        /// <returns>Returns the new Flight that was created</returns>
        public Flight ScheduleFlight()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// UpdateFlight method updates an existing Flight instance
        /// </summary>
        /// <returns>Returns the Flight that was updated</returns>
        public Flight UpdateFlight()
        {
            throw new System.NotImplementedException();
        }
    }
}