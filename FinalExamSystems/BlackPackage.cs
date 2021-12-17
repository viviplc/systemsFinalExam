using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalExamSystems
{
    /// <summary>
    /// BlackPackage class implements Factory method design pattern
    /// ConcreteCreator class
    /// </summary>
    public class BlackPackage : CancellationInsurance
    {
        /// <summary>
        /// createInsurancePackage overriding method from base class
        /// black insurance package provides 2 services
        /// </summary>
        public override void CreateInsurancePackage()
        {
            Package.Add(new FullReturnCoverage());
            Package.Add(new ReprogramCoverage());
        }
    }
}