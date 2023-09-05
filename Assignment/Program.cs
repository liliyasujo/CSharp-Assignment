using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Address adObjl = new Address("Guindy", "Sardar Patel Road", "Chennai", 600025);
                Student stdObj = new Student("Haridas", 87, 'M', true);
                GovtCollege gcObj = new GovtCollege("Anna University", adObjl);
                Console.WriteLine("CollegeDetails");
                Console.WriteLine(" \n");
                Console.WriteLine("College Id:" + gcObj.CollegeId);
                Console.WriteLine("College Name:" + gcObj.CollegeName);
                Console.WriteLine("College Address:" + gcObj.GovtCollegeAddress.AddressLine1 + ", " + gcObj.GovtCollegeAddress.AddressLine2 + ", " + gcObj.GovtCollegeAddress.City + ", " + gcObj.GovtCollegeAddress.Pincode);
                Console.WriteLine("Student Name:" + stdObj.StudentName);
                Console.WriteLine("Student Gender:" + stdObj.Gender);
                Console.WriteLine("Student Marks:" + stdObj.Marks);
                Console.WriteLine("Sports Quota Applicable:" + stdObj.SportsQuota);
                gcObj.SetFees(stdObj);
                Console.WriteLine("College Fees:" + stdObj.CollegeFees);
                Console.WriteLine("\n ************************************************************************\n");

                Address adObj2 = new Address("Kavaraipettai", "National Highway 45", "Tiruvallur", 601206);
                Student stdObj2 = new Student("Gayathri", 75, 'F', false);
                PrivateCollege pcObj = new PrivateCollege("R.M.K Engineering College", 10001, adObj2);
                Console.WriteLine("CollegeDetails");
                Console.WriteLine(" \n");
                Console.WriteLine("College Id:" + pcObj.CollegeId);
                Console.WriteLine("College Name:" + pcObj.CollegeName);
                Console.WriteLine("College Address:" + pcObj.PrivateCollegeAddress.AddressLine1 + ", " + pcObj.PrivateCollegeAddress.AddressLine2 + ", " + pcObj.PrivateCollegeAddress.City + ", " + pcObj.PrivateCollegeAddress.Pincode);
                Console.WriteLine("Student Name:" + stdObj2.StudentName);
                Console.WriteLine("5tudent Gender:" + stdObj2.Gender);
                Console.WriteLine("Student Marks:" + stdObj2.Marks);
                Console.WriteLine("Sports Quota Applicable:" + stdObj2.SportsQuota);
                pcObj.CalculateFees(stdObj2);
                Console.WriteLine("College Fees:" + stdObj2.CollegeFees);
            }
            catch (Exception)
            {
                Console.WriteLine("Some error occured!!!");
            }
            finally 
            {
                Console.ReadKey();
            }

        }
    }
}
