using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._10_
{
    public class Employee
    {
        private static int _id = 1;
        public int EmployeeId { get; private set; }
        public string Name;
        public string Surname;
        public int Age;
        public int DepartmentNo;

        private double _salary;

        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if(value > 0)
                {
                    _salary = value;
                }
            }
        }
        public Employee(string name,string surname,int age,int departmentNo,double salary)
        {
            EmployeeId = _id++;
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentNo = departmentNo;
            Salary = salary;
        }
        
    }
}
