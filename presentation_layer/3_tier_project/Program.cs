using Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
/*
 * 1)find
 * 2) add
 * 3)update
 * 4)delete
 */
namespace _3_tier_project
{
    internal class Program
    {
        static void contact_test_find(int id)
        {
            clscontact_business a_contact = clscontact_business.find(id);
            if (a_contact != null)
            {
                Console.WriteLine($"Contact ID: {a_contact.ID}");
                Console.WriteLine($"Name: {a_contact.FirstName} {a_contact.LastName}");
                Console.WriteLine($"Email: {a_contact.Email}");
                Console.WriteLine($"Phone: {a_contact.Phone}");
                Console.WriteLine($"Address: {a_contact.Address}");
                Console.WriteLine($"Country ID: {a_contact.CountryID}");
                Console.WriteLine();
            }
            else
                Console.WriteLine("Contact [" + id + "] Not found!");
        }

        static void contact_test_add()
        {
            clscontact_business contact = new clscontact_business();
            contact.FirstName = "Ahmed";
            contact.LastName = "Ali";
            contact.Email = "a@gamil.com";
            contact.Address = "3 st";
            contact.Phone = "456897";
            contact.CountryID = 2;
            if(contact.Save())
            {
                Console.WriteLine("done");
            }
            else
            {
                Console.WriteLine("failed");
            }
            
        }

        static void contact_test_update(int id)
        {
            clscontact_business contact = clscontact_business.find(id);
            contact.FirstName = "kemo";
            contact.LastName = "kemo";
            contact.Email = "a@gamil.com";
            contact.Address = "3 st";
            contact.Phone = "456897";
            contact.CountryID = 2;
            if (contact.Save())
            {
                Console.WriteLine("updated");
            }
            else
            {
                Console.WriteLine("not updated");
            }
        }

        static void contact_test_delete(int id)
        {
            if (clscontact_business.delete(id))
                Console.WriteLine("deleted");
            else
                Console.WriteLine("not deleted");
        }

        static void contact_list_all_contacts()
        {
            DataTable dt = clscontact_business.list_all();
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ContactID"]}: {row["FirstName"]} {row["LastName"]}");
            }
        }

        static void contact_test_is_exist(int id)
        {
            if(clscontact_business.is_exist(id))
                Console.WriteLine("exists");
            else
                Console.WriteLine("not exists");
        }

        //-----------------------------------------------------
        static void find_country(string name)
        {
            clscountry_business country = clscountry_business.find(name);
            if(country!=null)
            {
                Console.WriteLine($"CountryID {country.ID} ");
                Console.WriteLine($"CountryName {country.Name} ");
            }
            else
                Console.WriteLine("country "+ name+" is not found");
        }

        static void add_country()
        {
            clscountry_business country = new clscountry_business();
            country.Name = "Jaban";
            country.Code = "1";
            if (country.save())
                Console.WriteLine("saved");
            else
                Console.WriteLine("not saved");

        }
        
        static void update_country(string name)
        {
            clscountry_business country = clscountry_business.find(name);
            country.Name = "turkish";
            
            if (country.save())
                Console.WriteLine("updated");
            else
                Console.WriteLine("not updated");


        }

        static void delete_country(string name)
        {
            if (clscountry_business.is_exist(name))
            {
                if (clscountry_business.deletee(name))
                    Console.WriteLine("deleted");
                else
                    Console.WriteLine("not deleted");
            }
            else
                Console.WriteLine("country :"+name+" is not exist");

        }

        static void list_country()
        {
            DataTable dt = clscountry_business.list();
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["CountryID"]} : {row["CountryName"]}  {row["Code"]}");
            }
        }

        static void is_exist_country(string name)
        {
            if (clscountry_business.is_exist(name))
                Console.WriteLine("exist");
            else
                Console.WriteLine("not exist");
        }



        static void Main(string[] args)
        {
            list_country();
            
            
        }
    }
}
