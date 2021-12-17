using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// CancellationInsurance class implements the Factory Method design pattern
    /// Creator class definition
    /// </summary>
    public abstract class CancellationInsurance
    {
        private double price;
        private string packageName;
        private List<InsuranceService> package;

        /// <summary>
        /// Price property
        /// </summary>
        public double Price { get => price; set => price = value; }
        /// <summary>
        /// Package NAme property
        /// </summary>
        public string PackageName { get => packageName; set => packageName = value; }
        /// <summary>
        /// Insurance Service List as package property
        /// </summary>
        public List<InsuranceService> Package { get => package; set => package = value; }

        /// <summary>
        ///  Abstract Factory Method allowing the subclasses to define it
        /// </summary>
        public abstract void CreateInsurancePackage();

    }
}