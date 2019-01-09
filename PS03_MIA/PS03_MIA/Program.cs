using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS03_MIA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  A Program that reads information about the company and its manager
             *  Company: {Name, Address, Phone_Number, Fax_Number, Website}
             *  Manager: {First_Name,Surname,Phone_Number}
             */

            String Company_Name, Address, Phone_Number, Fax_Number, Website;    // Variable Info about Company
            String Manager_Fname, Manager_Lname, Manager_Cphone;                // Variable Info about Manager


            Console.WriteLine("A Program that reads information about the company and its manager\n");

            // Input all the information about the Company
            Console.Write("Enter Company's Name: ");
            Company_Name = Console.ReadLine();
            Console.Write("Enter Company's Address: ");
            Address = Console.ReadLine();
            Console.Write("Enter Company's Phone Number: ");
            Phone_Number = Console.ReadLine();
            Console.Write("Enter Company's Fax Number: ");
            Fax_Number = Console.ReadLine();
            Console.Write("Enter Company's Website: ");
            Website = Console.ReadLine();

            // Input all the information about the Manager
            Console.Write("Enter Manager's First Name: ");
            Manager_Fname = Console.ReadLine();
            Console.Write("Enter Manager's Surname: ");
            Manager_Lname = Console.ReadLine();
            Console.Write("Enter Manager's Cellphone Number: ");
            Manager_Cphone = Console.ReadLine();



            // Info about the Company 
            Console.WriteLine("\nInformation About the Company:");
            Console.WriteLine("\tAddress: " + Company_Name);
            Console.WriteLine("\tPhone Number: " + Company_Name);
            Console.WriteLine("\tFax Number: " + Company_Name);
            Console.WriteLine("\tWebsite: " + Company_Name);

            // Info about the Manager 
            Console.WriteLine("\nInformation About the Comapny's Manager:");
            Console.WriteLine("\tFirst Name: " + Manager_Fname);
            Console.WriteLine("\tSurame: " + Manager_Lname);
            Console.WriteLine("\tCellphone Number: " + Manager_Cphone);




            Console.ReadLine();
        }
    }
}
