using clsData1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Business
{
    public class clscontact
    {
        public enum enmode { addnew = 0, update = 1 };
        public enmode mode = enmode.addnew;
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }

        public clscontact()
        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.CountryID = -1;
        }

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

        private bool _add_new()
        {
            this.ID = clsData.add_new(FirstName, LastName, Email, Phone, Address, CountryID);
            return (ID != -1);
        }
        private bool _update()
        {
            return clsData.update(ID, FirstName, LastName, Email, Phone, Address, CountryID);
        }

        public static bool delete(int id)
        {
            return clsData.delete(id);
        }

        public static DataTable list_all()
        {
            return clsData.list_all();
        }

        public bool Save()
        {
            switch (mode)
            {
                case enmode.addnew:
                    if (_add_new())
                    {
                        mode = enmode.update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enmode.update:
                    return _update();
            }
            return false;
        }


    };

    public class Class1
    {
    }
}
