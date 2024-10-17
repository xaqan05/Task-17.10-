using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task_17._10_
{
    public class Department
    {
        public int No;

        public Employee[] Employees;

        public int EmployeeLimit;

        public Department(int no, int employeeLimit)
        {
            Employees = new Employee[0];
            No = no;
            EmployeeLimit = employeeLimit;
        }

        public void AddEmployee(Employee employee)
        {
            Employee[] newEmployees = new Employee[Employees.Length + 1];

            for (int i = 0; i < Employees.Length; i++)
            {
                newEmployees[i] = Employees[i];
            }
            newEmployees[Employees.Length] = employee;
            Employees = newEmployees;
        }

        public Employee getEmployee(int id)
        {
            Employee emp = null;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (id == Employees[i].EmployeeId)
                {
                    emp = Employees[i];
                    return emp;
                }
            }
            return emp;
        }

        

        public Employee getAllEmp()
        {
            for(int i = 0; i < Employees.Length;i++)
            {
                return Employees[i];
            }
            return null;
        }
        public Employee getEmpsBySalary(double salary)
        {
            Employee emp = null;
            for(int i = 0;i < Employees.Length; i++)
            {
                if(salary == Employees[i].Salary)
                {
                    emp= Employees[i];
                    return emp;
                }
            }
            return emp;
        }

        public Employee GetAllEmpByDepNo(int depNo)
        {
            Employee emp = null;
            for( int i = 0;i<Employees.Length ; i++)
            {
                if(depNo == Employees[i].DepartmentNo)
                {
                    emp= Employees[i];
                    return emp;
                }
            }
            return emp;
        }
        public void GetEmpInfo(Employee emp)
        {
            Console.WriteLine($"Id:{emp.EmployeeId}, Name: {emp.Name}, Surname: {emp.Surname}, Age: {emp.Age}, Department No: {emp.DepartmentNo}");
        }

    }
}
