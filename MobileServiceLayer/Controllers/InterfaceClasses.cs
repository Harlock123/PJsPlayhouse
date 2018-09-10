using System;
using System.Collections.Generic;

namespace MobileServiceLayer.Controllers
{

    public class CareGap
    {
        public string CareGapType { get; set; }
        public string CareGapDescription { get; set; }
        public DateTime CareGapOpenedDate { get; set; }
        public DateTime CareGapClosedDate { get; set; }
        public string CareGapReason { get; set; }
        public string CareGapRational { get; set; }
        
        public CareGap()
        {
        }

        public CareGap(string CGT, string CGD, DateTime CGOD, DateTime CGCD, string CGR, string CGRAT)
        {
            CareGapType = CGT;
            CareGapDescription = CGD;
            CareGapOpenedDate = CGOD;
            CareGapClosedDate = CGCD;
            CareGapReason = CGR;
            CareGapRational = CGRAT;
        }

    }
}