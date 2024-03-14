using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDBusinessLayer
{
    public class clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enum enApplicationType
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enMode Mode = enMode.AddNew;
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public int ApplicationID { set; get; }
        public int ApplicationPersonID { set; get; }
        public string ApplicantFullName
        {
            get
            {
                return clsPeople.GetFullNameByPersonID(ApplicationPersonID);
            }
        }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public clsApplicationTypes ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { set; get; }
        public string StatusText
        {
            get
            {

                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }
            }

        }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUsers CreatedByUserInfo;


        public clsApplications()

        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }

        private clsApplications(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID)

        {
            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationTypes.Find(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUsers.GetUserInfoByUserID(CreatedByUserID);
            Mode = enMode.Update;
        }

        private int _AddNewApplication()
        {
            this.ApplicationID = clsApplicationsDataAccess.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID,
                                                         (int)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
            return (this.ApplicationID);
        }

        public int Save()
        {
            return _AddNewApplication();
        }

        public static DataTable GetAllApplication()
        {
            return clsApplicationsDataAccess.GetAllApplication();
        }

        //public static DataTable GetAllApplicationsOrderByIndex(int Index)
        //{
        //    //enComboxItems is a public enum type,
        //    //which was declared in the clsApplicationsDataAcsess class,
        //    //we used this type in this class which is already inherited from clsPeopleDateAcsess
        //    clsApplicationsDataAccess.enComboboxItems selectedEnumItem = (clsApplicationsDataAccess.enComboboxItems)Index;
        //    return clsApplicationsDataAccess.GetAllApplicationsOrderByIndex(selectedEnumItem);
        //}

        //Overloading of GetAllApplicationsOrderByIndex Find person with text and selectedindex
        //public static DataTable GetAllApplicationsOrderByIndex(int Index, string FindWithText)
        //{

        //    clsApplicationsDataAccess.enComboboxItems selectedEnumItem = (clsApplicationsDataAccess.enComboboxItems)Index;
        //    return clsApplicationsDataAccess.GetAllApplicationsOrderByIndex(selectedEnumItem, FindWithText);
        //}

        public static clsApplications FindApplicationByID(int  ApplicationID)
        {

            int ApplicationPersonID = -1, ApplicationTypeID = -1, ApplicationStatus = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;

            if (clsApplicationsDataAccess.GetApplicationInfoByID(ApplicationID, ref ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
                                                      ref LastStatusDate, ref PaidFees, ref CreatedByUserID))
                return new clsApplications(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID,(enApplicationStatus)ApplicationStatus,
                                                       LastStatusDate, PaidFees, CreatedByUserID);
            else return null;
        }

        public static clsApplications FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now; int ApplicationTypeID = -1;
            int ApplicationStatus = 1; DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0; int CreatedByUserID = -1;

            bool IsFound = clsApplicationsDataAccess.GetApplicationInfoByID
                                (
                                    ApplicationID, ref ApplicantPersonID,
                                    ref ApplicationDate, ref ApplicationTypeID,
                                    ref ApplicationStatus, ref LastStatusDate,
                                    ref PaidFees, ref CreatedByUserID
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsApplications(ApplicationID, ApplicantPersonID,
                                     ApplicationDate, ApplicationTypeID,
                                    (enApplicationStatus)ApplicationStatus, LastStatusDate,
                                     PaidFees, CreatedByUserID);
            else
                return null;
        }

        public bool SetComplete()

        {
            return clsApplicationsDataAccess.UpdateStatus(ApplicationID, 3);
        }

    }
}
