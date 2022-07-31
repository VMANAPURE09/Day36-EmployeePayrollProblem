using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollProblem
{
    public class EmployeePayroll
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public DateTime startdate { get; set; }
        public string gender { get; set; }
        public long phone { get; set; }
        public string address { get; set; }
        public Double BasicPay { get; set; }
        public Double Deductions { get; set; }
        public Double TaxablePay { get; set; }
        public Double IncomeTax { get; set; }
        public Double NetPay { get; set; }
        public int DepartmentID { get; set; }
    }
}
