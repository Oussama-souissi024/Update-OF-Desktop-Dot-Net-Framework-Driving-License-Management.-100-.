using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };

        public clsDrivers DriverInfo;
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClass { set; get; }
        public clsLicenseClasses LicenseClassIfo;
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enIssueReason IssueReason { set; get; }
        public string IssueReasonText
        {
            get
            {
                return GetIssueReasonText(this.IssueReason);
            }
        }
        public clsDetainedLicenses DetainedInfo { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsDetained
        {
            get { return clsDetainedLicenses.IsLicenseDetained(this.LicenseID); }
        }

        public clsLicenses()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClass = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = 0;
            this.IsActive = false;
            this.IssueReason = 0;
            this.CreatedByUserID = -1;

        }

        public clsLicenses(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
            DateTime IssueDate, DateTime ExpirationDate, string Notes,
            decimal PaidFees, bool IsActive, enIssueReason IssueReason, int CreatedByUserID)

        {
            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.DriverID = DriverID;
            this.LicenseClass = LicenseClass;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = clsDrivers.FindByDriverID(this.DriverID);
            this.LicenseClassIfo = clsLicenseClasses.Find(this.LicenseClass);
            this.DetainedInfo = clsDetainedLicenses.FindByLicenseID(this.LicenseID);

        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return clsLicensesDataAccess.IsLicenseExist(LicenseID);
        }

        public static bool IsExpired(int LicenseID)
        {
            return clsLicensesDataAccess.IsExpired(LicenseID);
        }

        public static clsLicenses Find(int LicenceID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClass = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.Now, expirationDate = DateTime.Now;
            string notes = "";
            decimal paidFees = 0;
            bool isActive = false;
            int issueReason = 1;
            clsLicenses.enIssueReason IssueReason = (enIssueReason)issueReason;



            if (clsLicensesDataAccess.GetLicenseInfoByID(LicenceID, ref ApplicationID, ref DriverID, ref LicenseClass, ref issueDate, ref expirationDate,
                                                        ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))

                return new clsLicenses(LicenceID, ApplicationID, DriverID, LicenseClass, issueDate, expirationDate,
                                                        notes, paidFees, isActive, IssueReason, createdByUserID);
            else
                return null;
        }

        public static string GetLicenceDriverNameByLicenseID(int licenseID)
        {
            return clsLicensesDataAccess.GetLicenceDriverNameByLicenseID(licenseID);
        }

        public static int GetDriverIDByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.GetDriverIDByLicenseID(LicenseID);
        }

        public static string GetLicenseDriverNationalNoByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverNationalNoByLicenseID(LicenseID);
        }

        public static string GetLicenseDriverGendorByLicenceID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverGendorByLicenceID(LicenseID);
        }

        public static DateTime GetLicenseDriverDateOfBirthByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverDateOfBirthByLicenseID(LicenseID);
        }

        public static string GetLicenseDriverImagePathByLicenseID(int LicenseID)
        {
            return clsLicensesDataAccess.GetLicenseDriverImagePathByLicenseID(LicenseID);
        }

        public static bool IsDriverIDHaveThisLicense(int DriverID, int LicenseClass)
        {
            return clsLicensesDataAccess.IsDriverIDHaveThisLicense(DriverID, LicenseClass);
        }

        public static DataTable GetDriverLicenses(int DriverID)
        {
            return clsLicensesDataAccess.GetDriverLicenses(DriverID);
        }

        public static string GetIssueReasonText(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }

        private bool _AddNewLicense()
        {
            //call DataAccess Layer 

            this.LicenseID = clsLicensesDataAccess.AddNewLicense(this.ApplicationID, this.DriverID, this.LicenseClass,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);


            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            //call DataAccess Layer 

            return clsLicensesDataAccess.UpdateLicense(this.ApplicationID, this.LicenseID, this.DriverID, this.LicenseClass,
               this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
               this.IsActive, (byte)this.IssueReason, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicense();

            }

            return false;
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {

            return clsLicensesDataAccess.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);

        }

        public static bool ReleaseDetainedLicense(int ReleasedByUserID, int PersonID, int DetainID, ref int ApplicationID)
        {

            //First Create Applicaiton 
            clsApplications Application = new clsApplications();

            Application.ApplicationPersonID = PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplications.enApplicationType.ReleaseDetainedDrivingLicsense;
            Application.ApplicationStatus = clsApplications.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationTypes.Find((int)clsApplications.enApplicationType.ReleaseDetainedDrivingLicsense).Fees;
            Application.CreatedByUserID = ReleasedByUserID;

            if (Application.Save() == -1)
            {
                return false;
            }

            ApplicationID = Application.ApplicationID;


            return clsDetainedLicenses.ReleaseDetainedLicense(ReleasedByUserID, DetainID, Application.ApplicationID);

        }

        public bool DeactivateCurrentLicense()
        {
            return (clsLicensesDataAccess.DeactivateLicense(this.LicenseID));
        }

        public clsLicenses RenewLicense(string Notes, int CreatedByUserID)
        {

            //First Create Applicaiton 
            clsApplications Application = new clsApplications();

            Application.ApplicationPersonID = this.DriverInfo.PersonID;
            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (int)clsApplications.enApplicationType.RenewDrivingLicense;
            Application.ApplicationStatus = clsApplications.enApplicationStatus.Completed;
            Application.LastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationTypes.Find((int)clsApplications.enApplicationType.RenewDrivingLicense).Fees;
            Application.CreatedByUserID = CreatedByUserID;

            if (Application.Save() == -1)
            {
                return null;
            }


            clsLicenses NewLicense = new clsLicenses();

            NewLicense.ApplicationID = Application.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClass = this.LicenseClass;
            NewLicense.IssueDate = DateTime.Now;

            int DefaultValidityLength = this.LicenseClassIfo.DefaultValidityLength;

            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassIfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsLicenses.enIssueReason.Renew;
            NewLicense.CreatedByUserID = CreatedByUserID;

            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;
        }

		public clsLicenses Replace(enIssueReason IssueReason, int CreatedByUserID)
		{


			//First Create Applicaiton 
			clsApplications Application = new clsApplications();

			Application.ApplicationPersonID = this.DriverInfo.PersonID;
			Application.ApplicationDate = DateTime.Now;

			Application.ApplicationTypeID = (IssueReason == enIssueReason.DamagedReplacement) ?
				(int)clsApplications.enApplicationType.ReplaceDamagedDrivingLicense :
				(int)clsApplications.enApplicationType.ReplaceLostDrivingLicense;

			Application.ApplicationStatus = clsApplications.enApplicationStatus.Completed;
			Application.LastStatusDate = DateTime.Now;
			Application.PaidFees = clsApplicationTypes.Find(Application.ApplicationTypeID).Fees;
			Application.CreatedByUserID = CreatedByUserID;

			if (Application.Save() == -1)
			{
				return null;
			}

			clsLicenses NewLicense = new clsLicenses();

			NewLicense.ApplicationID = Application.ApplicationID;
			NewLicense.DriverID = this.DriverID;
			NewLicense.LicenseClass = this.LicenseClass;
			NewLicense.IssueDate = DateTime.Now;
			NewLicense.ExpirationDate = this.ExpirationDate;
			NewLicense.Notes = this.Notes;
			NewLicense.PaidFees = 0;// no fees for the license because it's a replacement.
			NewLicense.IsActive = true;
			NewLicense.IssueReason = IssueReason;
			NewLicense.CreatedByUserID = CreatedByUserID;



			if (!NewLicense.Save())
			{
				return null;
			}

			//we need to deactivate the old License.
			DeactivateCurrentLicense();

			return NewLicense;
		}

	}
}
