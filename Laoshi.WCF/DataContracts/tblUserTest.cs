namespace Laoshi.WCF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    

     
    public partial class tblUserTest
    {
        public int Id { get; set; }

        public int? LoginId { get; set; }

        public string TestTitle { get; set; }

        public int? TestType { get; set; }

        public int? TestCategory { get; set; }

        public TimeSpan? TimeToComplete { get; set; }

        public int? MaxAttempts { get; set; }

        public DateTime? AvailabilityFrom { get; set; }

        public DateTime? AvailabilityTo { get; set; }

        public int? QuestionsToDisplay { get; set; }

        public decimal? PassPercentage { get; set; }

        public string TestPassword { get; set; }

        public string TestLink { get; set; }

        public bool? IsRandomDisplay { get; set; }

        public bool? IsNegativeMarking { get; set; }

        public bool? IsSendCertificate { get; set; }

        public bool? IsSendEmail { get; set; }

        public bool? IsPrint { get; set; }

        public bool? IsPasswordProtected { get; set; }

        public bool? IsTestByLink { get; set; }

        public virtual UserLogin tblLogin { get; set; }
    }
}
