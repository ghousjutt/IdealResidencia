//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdealResidencia
{
    using System;
    using System.Collections.Generic;
    
    public partial class Investor
    {
        public short InvestorID { get; set; }
        public string InvestorName { get; set; }
        public string InvestorEmail { get; set; }
        public string InvestorAddress { get; set; }
        public string InvestorPhoneOffice { get; set; }
        public string InvestorMobile { get; set; }
        public string InvestorMobileSecondary { get; set; }
        public string InvestorCNIC { get; set; }
        public string InvestorNTN { get; set; }
        public long AdvancePaid { get; set; }
        public Nullable<long> Balance { get; set; }
        public bool IsBalancePaid { get; set; }
        public System.DateTime BalancePaidDate { get; set; }
        public short NoOfPlotsBought { get; set; }
    }
}