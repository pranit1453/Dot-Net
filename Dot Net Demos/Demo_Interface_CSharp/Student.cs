using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface_CSharp
{
    internal class Student:StudentInfo,ContactInfo
    {
        private int studentID;
        private string studentName;
        private int rollno;
        private string studentEmail;
        private string studentPhone;

        public Student()
        {
            this.studentID = 0;
            this.studentName = string.Empty;
            this.rollno = 0;
            this.studentEmail = string.Empty;
            this.studentPhone = string.Empty;
        }

        public Student(int studentID, string studentName, int rollno, string studentEmail, string studentPhone)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.rollno = rollno;
            this.studentEmail = studentEmail;
            this.studentPhone = studentPhone;
        }

        public int Sid
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public String Sname
        {
            get { return this.studentName; }
            set { this.studentName = value; }
        }

        public int RollNo
        {
            get { return this.rollno; }
            set { this.RollNo = value; }
        }
        public string Email
        {
            get{ return this.studentEmail; }
            set { this.studentEmail = value; }
        }
        public string Phone
        {
            get{ return this.studentPhone; }
            set { this.studentPhone = value; }
        }

       

        public override string ToString()
        {
            return base.ToString() + $" StudentID : {studentID}, Student Name : {studentName}," +
                $"Student Roll No : {rollno}, Student Email : {studentEmail}, Student Phone : {studentPhone}.";
        }

        // implicit interface
        public void contactInfo()
        {
            Console.WriteLine($"Email : {studentEmail}, Phone : {studentPhone}");
        } 
        // explicit interface 
        //void ContactInfo.contactInfo()
        //{
        //    Console.WriteLine($"Email : {studentEmail}, Phone : {studentPhone}");
        //}

        void StudentInfo.displayInfo()
        {
            Console.WriteLine($"ID: {studentID}, Name: {studentName}, Roll No: {rollno}");
        }
    }
}
