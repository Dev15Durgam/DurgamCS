using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Employee
    {
        private string name;
        private int age;
        private string gender;
        private int salary;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string empName,int empAge, string empGender,int empSalary)
        {
            this.Name = empName;
            this.Age = empAge;
            this.Gender = empGender;
            this.Salary = empSalary;

        }

        public override string ToString()
        {
            return $"Emp Name :{Name} Age :{Age} Gender:{Gender} Salary:{Salary}";
        }
    }
}
