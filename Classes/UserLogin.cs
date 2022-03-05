using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_MGS.Classes
{
    class UserLogin
    {
        //Static Fields
        private static string StaffID;
        private static string StaffName;
        private static string UserType;

        //Setter Methods
        public static void setStaffID(string id)
        {
            StaffID = id;
        }

        public static void setStaffName(string name)
        {
            StaffName = name;
        }

        public static void setUserType(string userType)
        {
            UserType = userType;
        }

        //Getter Methods
        public static string getStaffID()
        {
            return StaffID;
        }

        public static string getStaffName()
        {
            return StaffName;
        }

        public static string getUserType()
        {
            return UserType;
        }
    }
}
