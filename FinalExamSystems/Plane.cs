using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    ///  Plane class is for a specific plane instance in the fleet of Planes available for an Airline under its Brands
    /// </summary>
    public class Plane
    {
        /// <summary>
        ///  Type property is type of Plane
        /// </summary>
        public PlaneType Type
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Id property is the specific id for the Plane instance
        /// </summary>
        public string Id
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        ///  Available property is a boolean of whether the Plane is available or not
        /// </summary>
        public bool Available
        {
            get => default;
            set
            {
            }
        }
    }
}