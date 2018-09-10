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

    public class Auth
    {

        public string[] ServiceCode { get; set; }
        public string[] ProviderID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int[] MaxUnits { get; set; }
        public int[] RemainingUnits { get; set; }
        public string MemberID { get; set; }
        public string AuthID { get; set; }

        public Auth()
        {
            ServiceCode = new string[] { "" };
            ProviderID = new string[] { "" };

            StartDate = Convert.ToDateTime(null);
            EndDate = Convert.ToDateTime(null);

            MaxUnits = new int[] { 0 };
            RemainingUnits = new int[] { 0 };

            MemberID = "";

            AuthID = "";

        }

    }

    public class Claim
    {
        public string ServiceCode { get; set; }
        public string ServiceCodeDescription { get; set; }
        public int Units { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ServiceProvider { get; set; }
        public string PlaceOfService { get; set; }
        public string MemberID { get; set; }
        public string AssociatedAuthID { get; set; }
        public string ClaimID { get; set; }

        public Claim()
        {
            ServiceCode = "";
            ServiceCodeDescription = "";
            Units = 0;

            StartDate = Convert.ToDateTime(null);
            EndDate = Convert.ToDateTime(null);

            ServiceProvider = "";
            PlaceOfService = "";
            MemberID = "";
            AssociatedAuthID = "";
            ClaimID = "";

        }

    }
}