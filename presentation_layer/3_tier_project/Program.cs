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
        static void test_find(int id)
        {
            clscontact a_contact = clscontact.find(id);
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

        static void test_add()
        {
            clscontact contact = new clscontact();
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

        static void test_update(int id)
        {
            clscontact contact = clscontact.find(id);
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

        static void test_delete(int id)
        {
            if (clscontact.delete(id))
                Console.WriteLine("deleted");
            else
                Console.WriteLine("not deleted");
        }

        static void list_all_contacts()
        {
            DataTable dt = clscontact.list_all();
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"{row["ContactID"]}: {row["FirstName"]} {row["LastName"]}");
            }
        }

        static void test_is_exist(int id)
        {
            if(clscontact.is_exist(id))
                Console.WriteLine("exists");
            else
                Console.WriteLine("not exists");
        }

        static void Main(string[] args)
        {
            test_is_exist(1);
            
            
        }
    }
}
