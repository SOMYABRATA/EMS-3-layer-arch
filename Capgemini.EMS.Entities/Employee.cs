using System;

namespace Capgemini.EMS.Entities
{
    public class Employee
    {
        //creating properties 
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime DateofJoining { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {name}, DateOfJoining: {DateofJoining.ToShortDateString()}";
        }
    }
}
