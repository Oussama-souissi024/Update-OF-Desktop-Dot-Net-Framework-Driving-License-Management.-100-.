using DVLDDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsApplicationTypes
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public decimal Fees { set; get; }

        public clsApplicationTypes()

        {
            this.ID = -1;
            this.Title = "";
            this.Fees = 0;
        }

        public clsApplicationTypes(int ID, string ApplicationTypeTitel, decimal ApplicationTypeFees)

        {
            this.ID = ID;
            this.Title = ApplicationTypeTitel;
            this.Fees = ApplicationTypeFees;
        }

        public static string GetApplicationTypeTitleByApplicationTypeID(int ApplicationTypeID)
        {
            return clsApplicationTypesDataAccess.GetApplicationTypeTitleByApplicationTypeID(ApplicationTypeID);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
        }

        public static clsApplicationTypes Find(int ID)
        {
            string Title = ""; decimal Fees = 0;

            if (clsApplicationTypesDataAccess.GetApplicationTypeInfoByID((int)ID, ref Title, ref Fees))

                return new clsApplicationTypes(ID, Title, Fees);
            else
                return null;

        }

        private bool _AddNewApplicationType()
        {
            //call DataAccess Layer 

            this.ID = clsApplicationTypesDataAccess.AddNewApplicationType(this.Title, this.Fees);

            return (this.ID != -1);
        }

        private bool _UpdateApplicationType()
        {
            //call DataAccess Layer 

            return clsApplicationTypesDataAccess.UpdateApplicationType(this.ID, this.Title, this.Fees);
        }

        public bool Save()
        {
            return _UpdateApplicationType();
        }
    }
}
