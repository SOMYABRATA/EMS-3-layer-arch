using Capgemini.EMS.DataAcessLayer;
using Capgemini.EMS.Entities;
using Capgemini.EMS.Exceptions;
using System;
using System.Collections.Generic;

namespace Capgemini.EMS.BusinessLayer
{
    public class EmployeeBL
    {
        public static bool Add(Employee emp)
        {
            //biz validations
            //throw
            if (emp.Id <= 0)//invalid business rule
            {
                throw new EmsExceptions("Employee id should be greater than zero");


            }
            //call Dal method
            bool isAdded = EmployeeDAL.Add(emp);
            return isAdded;
        }
        public static List<Employee> GetList()
        {
            var list = EmployeeDAL.GetList();
            return list;
        }
        public static Employee GetById(int id)
        {
            var emp = EmployeeDAL.GetbyId(id);
            return emp;}
        public static bool Update(Employee emp)
        {
            bool isUpdated = EmployeeDAL.Update(emp);
            return isUpdated;
        }
        public static bool Delete(int id)
        {
            var isDelete = EmployeeDAL.Delete(id);
            return isDelete;
        }

    }
    

        
    }

