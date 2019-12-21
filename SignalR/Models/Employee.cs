using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.Models
{
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int Salary { get; set; }
        public string DeptName { get; set; }
        public string Designation { get; set; }
    }
}