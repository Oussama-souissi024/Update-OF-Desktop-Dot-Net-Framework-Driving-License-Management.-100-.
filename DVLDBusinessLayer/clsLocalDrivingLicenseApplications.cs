using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLDBusinessLayer.clsApplications;

namespace DVLDBusinessLayer
{
    public class clsLocalDrivingLicenseApplications : clsApplications
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { set; get; }
        public int LicenseClassID { set; get; }
        public clsLicenseClasses LicenseClassInfo;
        public string PersonFullName
        {
            get
            {
                return clsPeople.GetFullNameByPersonID(ApplicationPersonID);
            }

        }

        public clsLocalDrivingLicenseApplications()

        {
            this.LocalDrivingLicenseApplicationID = -1;
            this.LicenseClassID = -1;


            Mode = enMode.AddNew;

        }

        private clsLocalDrivingLicenseApplications(int LocalDrivingLicenseApplicationID, int ApplicationID, int ApplicationPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enApplicationStatus ApplicationStatus, DateTime LastStatusDate,
             decimal PaidFees, int CreatedByUserID, int LicenseClassID)

        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationID; ;
            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = (int)ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.LicenseClassID = LicenseClassID;
            this.LicenseClassInfo = clsLicenseClasses.Find(LicenseClassID);
            Mode = enMode.Update;
        }

        public static DataTable GetAllLocalDrivingLicenseApplication()
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetAllLocalDrivingLicenseApplication();
        }

        private int _AddNewLocalDrivingLicenseApplications()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalDrivingLicenseApplicationsDataAccess.AddNewLocalDrivingLicenseApplications( this.ApplicationID, this.LicenseClassID);
            return this.LocalDrivingLicenseApplicationID;
        }

        public int Save()
        {
            return _AddNewLocalDrivingLicenseApplications();
        }


        public static bool DeleteLocalDrivingLicenseAppliation(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.DeleteLocalDrivingLicenseAppliation(LocalDrivingLicenseApplicationID);
        }

        public static string GetLicenseClasNameByID (int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetLicenseClasNameByID( LocalDrivingLicenseApplicationID );
        }

        public static int GetApplicationIDByLDApplicationID (int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.GetApplicationIDByLDApplicationID(LocalDrivingLicenseApplicationID);
        }

        public static bool CanceledLocalDrivingApplicationByID(int LocalDrivingLicenseApplicationID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.CanceledLocalDrivingApplicationByID(LocalDrivingLicenseApplicationID);
        }

        public static clsLocalDrivingLicenseApplications FindByLocalDrivingAppLicenseID(int LocalDrivingLicenseApplicationID)
        {
            // 
            int ApplicationID = -1, LicenseClassID = -1;

            bool IsFound = clsLocalDrivingLicenseApplicationsDataAccess.GetLocalDrivingLicenseApplicationInfoByID
                (LocalDrivingLicenseApplicationID, ref ApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application
                clsApplications Application = clsApplications.FindBaseApplication(ApplicationID);

                //we return new object of that person with the right data
                return new clsLocalDrivingLicenseApplications(
                    LocalDrivingLicenseApplicationID, Application.ApplicationID,
                    Application.ApplicationPersonID,
                                     Application.ApplicationDate, Application.ApplicationTypeID,
                                    (enApplicationStatus)Application.ApplicationStatus, Application.LastStatusDate,
                                     Application.PaidFees, Application.CreatedByUserID, LicenseClassID);
            }
            else
                return null;
        }

        public bool DoesPassTestType(clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsDataAccess.DoesPassTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool DoesPassPreviousTest(clsTestTypes.enTestType CurrentTestType)
        {

            switch (CurrentTestType)
            {
                case clsTestTypes.enTestType.VisionTest:
                    //in this case no required prvious test to pass.
                    return true;

                case clsTestTypes.enTestType.WrittenTest:
                    //Written Test, you cannot sechdule it before person passes the vision test.
                    //we check if pass visiontest 1.

                    return this.DoesPassTestType(clsTestTypes.enTestType.VisionTest);


                case clsTestTypes.enTestType.StreetTest:

                    //Street Test, you cannot sechdule it before person passes the written test.
                    //we check if pass Written 2.
                    return this.DoesPassTestType(clsTestTypes.enTestType.WrittenTest);

                default:
                    return false;
            }
        }

        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsDataAccess.DoesPassTestType(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool DoesAttendTestType(clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsDataAccess.DoesAttendTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public byte TotalTrialsPerTest(clsTestTypes.enTestType TestTypeID)
        {
            return clsLocalDrivingLicenseApplicationsDataAccess.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsDataAccess.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool AttendedTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsDataAccess.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public bool AttendedTest(clsTestTypes.enTestType TestTypeID)

        {
            return clsLocalDrivingLicenseApplicationsDataAccess.TotalTrialsPerTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID) > 0;
        }

        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, clsTestTypes.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationsDataAccess.IsThereAnActiveScheduledTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public bool IsThereAnActiveScheduledTest(clsTestTypes.enTestType TestTypeID)

        {

            return clsLocalDrivingLicenseApplicationsDataAccess.IsThereAnActiveScheduledTest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public clsTest GetLastTestPerTestType(clsTestTypes.enTestType TestTypeID)
        {
            return clsTest.FindLastTestPerPersonAndLicenseClass(this.ApplicationPersonID, this.LicenseClassID, TestTypeID);
        }

        public byte GetPassedTestCount()
        {
            return clsTest.GetPassedTestCount(this.LocalDrivingLicenseApplicationID);
        }

        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTest.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public bool PassedAllTests()
        {
            return clsTest.PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }

        public static bool PassedAllTests(int LocalDrivingLicenseApplicationID)
        {
            //if total passed test less than 3 it will return false otherwise will return true
            return clsTest.PassedAllTests(LocalDrivingLicenseApplicationID);
        }

        public int IssueLicenseForTheFirtTime(string Notes, int CreatedByUserID)
        {
            int DriverID = -1;

            clsDrivers Driver = clsDrivers.FindByPersonID(this.ApplicationPersonID);

            if (Driver == null)
            {
                //we check if the driver already there for this person.
                Driver = new clsDrivers();

                Driver.PersonID = this.ApplicationPersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                if (Driver.Save())
                {
                    DriverID = Driver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = Driver.DriverID;
            }
            //now we diver is there, so we add new licesnse

            clsLicenses License = new clsLicenses();
            License.ApplicationID = this.ApplicationID;
            License.DriverID = DriverID;
            License.LicenseClass = this.LicenseClassID;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = DateTime.Now.AddYears(this.LicenseClassInfo.DefaultValidityLength);
            License.Notes = Notes;
            License.PaidFees = this.LicenseClassInfo.ClassFees;
            License.IsActive = true;
            License.IssueReason = clsLicenses.enIssueReason.FirstTime;
            License.CreatedByUserID = CreatedByUserID;

            if (License.Save())
            {
                //now we should set the application status to complete.
                this.SetComplete();

                return License.LicenseID;
            }

            else
                return -1;
        }

        public bool IsLicenseIssued()
        {
            return (GetActiveLicenseID() != -1);
        }

        public int GetActiveLicenseID()
        {//this will get the license id that belongs to this application
            return clsLicenses.GetActiveLicenseIDByPersonID(this.ApplicationPersonID, this.LicenseClassID);
        }
    }   
}
