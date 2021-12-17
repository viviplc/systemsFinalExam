using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// EmeraldPackage class implements Factory method design pattern
    /// ConcreteCreator class
    /// </summary>
    public class EmeraldPackage : CancellationInsurance
    {
        /// <summary>
        /// createInsurancePackage overriding method from base class
        /// emerald insurance package provides 3 services
        /// </summary>
        public override void CreateInsurancePackage()
        {
            Package.Add(new FullReturnCoverage());
            Package.Add(new ReprogramCoverage());
            Package.Add(new AdditionalFeesCoverage());
        }
    }
}