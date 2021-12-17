using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// GoldPackage class implements Factory method design pattern
    /// ConcreteCreator class
    /// </summary>
    public class GoldPackage : CancellationInsurance
    {
        /// <summary>
        /// createInsurancePackage overriding method from base class
        /// gold insurance package provides 2 services
        /// </summary>
        public override void CreateInsurancePackage()
        {
            Package.Add(new HalfReturnCoverage());
            Package.Add(new ReprogramCoverage());
        }
    }
}