using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsLicenseClasses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }

        public clsLicenseClasses()

        {
            this.LicenseClassID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 18;
            this.DefaultValidityLength = 10;
            this.ClassFees = 0;

            Mode = enMode.AddNew;

        }

        public clsLicenseClasses(int LicenseClassID, string ClassName,
            string ClassDescription,
            byte MinimumAllowedAge, byte DefaultValidityLength, decimal ClassFees)

        {
            this.LicenseClassID = LicenseClassID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            Mode = enMode.Update;
        }
        public static string GetLicenseClassNameByLicenseClassID(int licenseClassID)
        {
            return clsLicenseClassesDataAccess.GetLicenseClassNameByLicenseClassID(licenseClassID);
        }

        public static  bool IsPersonHaveMinimumLicenseAge(int PersonAge, int LicenseClassID)
        {
            return clsLicenseClassesDataAccess.IsPersonHaveMinimumLicenseAge(PersonAge, LicenseClassID);

        }

        public static clsLicenseClasses Find(int LicenseClassID)
        {
            string ClassName = ""; string ClassDescription = "";
            byte MinimumAllowedAge = 18; byte DefaultValidityLength = 10; decimal ClassFees = 0;

            if (clsLicenseClassesDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref ClassName, ref ClassDescription,
                    ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClasses(LicenseClassID, ClassName, ClassDescription,
                    MinimumAllowedAge, DefaultValidityLength, ClassFees);
            else
                return null;

        }
    }
}
