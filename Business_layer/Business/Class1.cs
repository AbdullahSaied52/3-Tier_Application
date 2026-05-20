using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsData1;
namespace Business
{
    public class clscontact
    { 
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }

        //public clscontact()
        //{
        //    this.ID = -1;
        //    this.FirstName = "";
        //    this.LastName = "";
        //    this.Email = "";
        //    this.Phone = "";
        //    this.Address = "";
        //    this.CountryID = -1;
        //}

        private clscontact(int id,string FN,string LN,string email,
            string phone,string address,int countryid)
        {
            this.ID = id;
            this.FirstName = FN;
            this.LastName = LN;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
            this.CountryID = countryid;
        }

        public static clscontact find(int id)
        {
            string Firstname = "", Lastname = "", email = "", phone = "", address = "";
            int Countryid=-1;
            if(clsData.is_found(id,ref Firstname,ref Lastname,ref email,ref phone,
                ref address,ref Countryid))
            {
                return new clscontact(id,Firstname, Lastname, email, phone, address, Countryid);
            }
            else
            {
                return null;
            }
        }
    };

    public class Class1
    {
    }
}
