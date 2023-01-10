using Capgemini.EMS.BusinessLayer;
using Capgemini.EMS.Entities;
using Capgemini.EMS.Exceptions;
using System;

namespace Capgemini.EMS.PL
{
   internal class Program
    {
        private static void Main(string[] args)
        {
            while(true)
            {


                Console.WriteLine("1 Add Employee, 2 Employee List,3 Update the employee, 4 Delete Employee, 5 exit" );
                Console.WriteLine("Enter your choice");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("invalid input");
                return;
            }
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        EmployeeList();
                       break;
                    case 3:
                        updateEmployee();
                        break;
                    case 4:
                        DeleteEmployee();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
            }

        }

        //for updation
        private static void updateEmployee()
        {
            //emp id 
            string input;
            int empid;
            do
            {
                Console.WriteLine("enter employee id ");
                input = Console.ReadLine();

            }
            while (!int.TryParse(input, out empid));
            //emp id - check 
            var existingEmployee = EmployeeBL.GetById(empid);
            if (existingEmployee == null)
            {
                Console.WriteLine("employee not found");
                return;
            }
            //ask for the parameter to be updated 
            do
            {
                Console.WriteLine("enter employee name ");
                input = Console.ReadLine();

            }
            while (string.IsNullOrEmpty(input));
            existingEmployee.name = input;
            DateTime DateofJoining;
            do
            {
                Console.WriteLine("enter date of joining");
                input = Console.ReadLine();

            }
            while (!DateTime.TryParse(input, out DateofJoining));
            existingEmployee.DateofJoining = DateofJoining;

            //update
            var isUpadte = EmployeeBL.Update(existingEmployee);
            if (isUpadte)
            {
                Console.WriteLine("Employee Updated");
            }
            else
            {
                Console.WriteLine("Not updated");
            }
        }
        //for deletion
        private static void DeleteEmployee()
        {

            string input;
            int empId;
            do
            {
                Console.WriteLine("enter employee id ");
                input = Console.ReadLine();

            }
            while (!int.TryParse(input, out empId));
            //emp id - check 
            var existingEmployee = EmployeeBL.GetById(empId);
            if (existingEmployee == null)
            {
                Console.WriteLine("employee not found");
                return;
            }
            //delete data
            var isDelete = EmployeeBL.Delete(empId);
            if(isDelete)
            {
                Console.WriteLine("deletion sucessful");
            }
            else
            {
                Console.WriteLine("deletion unsuccesful");
            }

        }
        //for employee list
        private static void EmployeeList()
        {
            var list = EmployeeBL.GetList();
            Console.WriteLine("EmployeeList");
            foreach (var emp in list)
            {
                Console.WriteLine(emp);

            }
        }

        //for adding employee
        private static void AddEmployee()
        {
            Employee newEmployee = new Employee();
            string input;
            int empid;
            do
            {
                Console.WriteLine("enter employee id ");
                input = Console.ReadLine();

            } 
            while (!int.TryParse(input,  out empid));
            newEmployee.Id = empid;
            do
            {
                Console.WriteLine("enter employee name ");
                input = Console.ReadLine();

            }
            while (string.IsNullOrEmpty(input));
            newEmployee.name = input;
            DateTime DateofJoining;
            do
            {
                Console.WriteLine("enter date of joining");
                input = Console.ReadLine();

            }
            while (!DateTime.TryParse(input, out DateofJoining));
            newEmployee.DateofJoining = DateofJoining;

            //call BL
            try
            {
                bool isAdded = EmployeeBL.Add(newEmployee);
                if (isAdded)
                {
                    Console.WriteLine("employee added successfully");
                }
                else
                {
                    Console.WriteLine("employee add failed");
                }
            }
            catch (EmsExceptions e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
           
           
        }
    }
   
}
