using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using clsData1;
namespace Business
{
    public class clscountry_business
    {
        public enum enmode { addnew = 0, update = 1 }
        public enmode moode = enmode.addnew;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public  clscountry_business()
        {
            this.ID = -1;
            this.Name = "";
            this.Code = "";
            moode = enmode.addnew;
        }
        private clscountry_business(int id,string name,string code)
        {
            this.ID = id;
            this.Name = name;
            this.Code=code;
            moode = enmode.update;
        }

        public static clscountry_business find_by_name(string name)
        {
            int id = -1;
            string code = "";
            if(clscountry_data.found_by_name(ref id,name,ref code))
            {
                return new clscountry_business(id, name,code);
            }
            else
            {
                return null;
            }
        }
        public static clscountry_business find_by_id(int id)
        {
            string name = "";
            string code = "";
            if (clscountry_data.found_by_id( id,ref name, ref code))
            {
                return new clscountry_business(id, name, code);
            }
            else
            {
                return null;
            }
        }

        private bool _add_new()
        {
            //this.ID = clscountry_data.country_add_new(Name);
            return (clscountry_data.add_new(this.Name,this.Code) != -1);
        }

        private bool _update()
        {
            return clscountry_data.update(ID,Name,Code);
        }

        public static bool deletee(string name)
        {
            return clscountry_data.delete(name);
        }

        public static DataTable list()
        {
            return clscountry_data.list();
        }

        public static bool is_exist(string name)
        {
            return clscountry_data.is_exist(name);
        }
        public bool save()
        {
            switch (moode)
            {
                case enmode.addnew:
                    if (_add_new())
                    {
                        moode = enmode.update;
                        return true;
                    }
                    else return false;
                case enmode.update:
                    return _update();
            }
            return false ;

        }
    }
}
