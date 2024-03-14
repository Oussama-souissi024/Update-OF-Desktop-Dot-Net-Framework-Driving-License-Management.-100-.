using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsDetainedLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }

        public decimal FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUsers CreatedByUserInfo { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public clsUsers ReleasedByUserInfo { set; get; }
        public int ReleaseApplicationID { set; get; }

        public clsDetainedLicenses()

        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = 0;
            this.ReleaseApplicationID = -1;

        }

        public clsDetainedLicenses(int DetainID,
            int LicenseID, DateTime DetainDate,
            decimal FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate,
            int ReleasedByUserID, int ReleaseApplicationID)

        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUsers.GetUserInfoByUserID(this.CreatedByUserID);
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.ReleasedByUserInfo = clsUsers.GetUserInfoByUserID(this.ReleasedByUserID);

        }

        private bool _AddNewDetainedLicense()
        {
            //call DataAccess Layer 

            this.DetainID = clsDetainedLicensesDataAccess.AddNewDetainedLicense(
                this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            //call DataAccess Layer 

            return clsDetainedLicensesDataAccess.UpdateDetainedLicense(
                this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.CreatedByUserID);
        }

        public static clsDetainedLicenses Find(int DetainID)
        {
            int LicenseID = -1; DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (clsDetainedLicensesDataAccess.GetDetainedLicenseInfoByID(DetainID,
            ref LicenseID, ref DetainDate,
            ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicenses(DetainID,
                     LicenseID, DetainDate,
                     FineFees, CreatedByUserID,
                     IsReleased, ReleaseDate,
                     ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesDataAccess.GetAllDetainedLicenses();

        }

        public static clsDetainedLicenses FindByLicenseID(int LicenseID)
        {
            int DetainID = -1; DateTime DetainDate = DateTime.Now;
            decimal FineFees = 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (clsDetainedLicensesDataAccess.GetDetainedLicenseInfoByLicenseID(LicenseID,
            ref DetainID, ref DetainDate,
            ref FineFees, ref CreatedByUserID,
            ref IsReleased, ref ReleaseDate,
            ref ReleasedByUserID, ref ReleaseApplicationID))

                return new clsDetainedLicenses(DetainID,
                     LicenseID, DetainDate,
                     FineFees, CreatedByUserID,
                     IsReleased, ReleaseDate,
                     ReleasedByUserID, ReleaseApplicationID);
            else
                return null;

        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainedLicense();

            }

            return false;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicensesDataAccess.IsLicenseDetained(LicenseID);
        }

        public static bool ReleaseDetainedLicense(int ReleasedByUserID, int DetainID, int ReleaseApplicationID)
        {
            return clsDetainedLicensesDataAccess.ReleaseDetainedLicense(DetainID,
                   ReleasedByUserID, ReleaseApplicationID);
        }

        public static int GetDetainedLicenseIDByLicenseID(int LicenseID)
        {
            return clsDetainedLicensesDataAccess.GetDetainedLicenseIDByLicenseID(LicenseID);
        }

    }
}
