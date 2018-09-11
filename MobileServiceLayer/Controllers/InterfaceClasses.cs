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
        public string MOD1 { get; set; }
        public string MOD2 { get; set; }
        public string MOD3 { get; set; }
        public string MOD4 { get; set; }
        public string MOD5 { get; set; }
        public int Units { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ServiceProvider { get; set; }
        public string PlaceOfService { get; set; }
        public string MemberID { get; set; }
        public string AssociatedAuthID { get; set; }
        public string ClaimID { get; set; }
        public string DIAG1 { get; set; }
        public string DIAG2 { get; set; }
        public string DIAG3 { get; set; }
        public string DIAG4 { get; set; }
        public string DIAG5 { get; set; }
        public string DIAG6 { get; set; }
        public string DIAG7 { get; set; }
        public string DIAG8 { get; set; }
        public double ChargedAmt { get; set; }
        public double PaidAmt { get; set; }
        public double CopayAmt { get; set; }



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

            DIAG1 = "";
            DIAG2 = "";
            DIAG3 = "";
            DIAG4 = "";
            DIAG5 = "";
            DIAG6 = "";
            DIAG7 = "";
            DIAG8 = "";

            MOD1 = "";
            MOD2 = "";
            MOD3 = "";
            MOD4 = "";
            MOD5 = "";

            ChargedAmt = 0.0;
            PaidAmt = 0.0;
            CopayAmt = 0.0;


        }

    }
}