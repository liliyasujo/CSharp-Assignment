using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
//-------------------delegate
    public delegate void StudentDelegate(Student student);
//-------------------Address Class
    public class Address
    {
        private int pincode;

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int Pincode
        {
            get { return pincode; }
            set
            {
                if (value >= 0 && value <= 999999)
                {
                    pincode = value;
                }
                else
                {
                    pincode = 570010;
                }
            }
        }

        public Address(string addressLine1, string addressLine2, string city, int pincode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            Pincode = pincode;
        }

    }
//-------------------Student class
    public class Student
    {
        public double CollegeFees { get; set; }
        public char Gender { get; set; }
        public int Marks { get; set; }
        public bool SportsQuota { get; set; }
        public string StudentName { get; set; }

        public Student(string studentName, int marks, char gender, bool sportsQuota)
        {
            StudentName = studentName;
            Marks = marks;
            Gender = gender;
            SportsQuota = sportsQuota;
        }

    }
//------------College class
    public class College
    {
        static int counter=1000;

        public int CollegeId { get; set; }
        public string CollegeName { get; set; }
        public College(string collegeName)
        {
            CollegeId = ++counter;
            CollegeName = collegeName;

        }
    }
    //------------GovtCollege class
    public class GovtCollege : College
    {
        private Address govtCollegeAddress;

        public Address GovtCollegeAddress 
        {
            get { return govtCollegeAddress; }
            set { govtCollegeAddress = value; }
        }
        public GovtCollege(string collegeName, Address govtCollegeAddress) : base(collegeName)
        {
            GovtCollegeAddress = govtCollegeAddress;
        }

        public void CalculateFeesBasedOnMarks(Student student)
        {
            if (student.Marks > 80)
            {
                student.CollegeFees = 20000;
            }
            else
            {
                student.CollegeFees = 35000;
            }
        }

        public void CalculateFeesBasedOnSportsQuota(Student student)
        {
            if (student.SportsQuota)
            {
                student.CollegeFees -= 5000;
            }
        }

        public void SetFees(Student student)
        {
            StudentDelegate studentDelegate = CalculateFeesBasedOnMarks;
            studentDelegate += CalculateFeesBasedOnSportsQuota;

            studentDelegate(student);
        }



    }
    //------------PrivateCollege class
    public class PrivateCollege:College
    {
        private int donation;
        private Address privateCollegeAddress;

        public Address PrivateCollegeAddress { get; set; }
        public int Donation { get; set; }

        public PrivateCollege(string collegeName, int donation, Address privateCollegeAddress)
        : base(collegeName)
        {
            PrivateCollegeAddress = privateCollegeAddress;
            Donation = donation;
        }

        public void CalculateFees(Student student)
        {
            if (student.Marks > 75 && Donation > 100000)
            {
                student.CollegeFees = 75000 - (Donation * 0.5);
            }
            else
            {
                student.CollegeFees = 75000;
            }
        }
    }

}
