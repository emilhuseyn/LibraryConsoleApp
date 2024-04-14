using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentConsoleApp
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public int Experience { get; set; }
        public string Address { get; set; }
        public int BirthDay { get; set; }
        public string ContactNumber { get; set; }
        public decimal Salary { get; set; }
        public EmployeeRoles EmployeeRole { get; set; }

        public Employee(string firstName, string lastName, byte age, 
            int experience, string address, int birthDay, string contactNumber, 
            decimal salary, EmployeeRoles role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Experience = experience;
            Address = address;
            BirthDay = birthDay;
            ContactNumber = contactNumber;
            Salary = salary;
            EmployeeRole = role;
        }

    }
}
