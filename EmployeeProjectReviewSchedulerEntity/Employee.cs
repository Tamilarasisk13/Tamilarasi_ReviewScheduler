
using System;
namespace EmployeeProjectReviewSchedulerEntity
{
    public class Employee
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string id { get; set; }
        public string emailId { get; set; }
        public string gender { get; set; }
        public string mobileNumber { get; set; }
        public DateTime dob { get; set; }
        public DateTime doj { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string designation { get; set; }
        public string role { get; set; }

        public Employee(string firstName, string lastName, string emailId, string gender, string mobileNumber, DateTime dob, DateTime doj, string userName, string password, string designation, string role)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailId = emailId;
            this.gender = gender;
            this.mobileNumber = mobileNumber;
            this.dob = dob;
            this.doj = doj;
            this.userName = userName;
            this.password = password;
            this.designation = designation;
            this.role = role;
        }
    }
}
