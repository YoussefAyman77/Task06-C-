using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06
{
    internal struct Employee
    {
        private int empID;
        private string empName;


        //without using properties
        public void setEmpName(string name)
        { empName = name; }
        public string getEmpName()
        { return empName; }
        //using full properties
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }
        //using automatic properties
        public decimal Salary { get; }
        public Employee(int _Id, string _Empname, decimal _Salary)
        {
            empID= _Id;
            empName = _Empname; 
            Salary = _Salary;
        }

        public override string ToString()
        {
            return $"Employee ID: {empID}, Employee Name: {empName}, Salary: {Salary}";
        }

    }
}
