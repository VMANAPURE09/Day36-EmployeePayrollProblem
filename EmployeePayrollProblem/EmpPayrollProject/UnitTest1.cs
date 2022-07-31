using NUnit.Framework;
using EmployeePayrollProblem;
using System.Collections.Generic;
using System;

namespace EmpPayrollProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()

        {
            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
        }

        [Test]
        public void GivenEmployeeList_InAddingEmployeeMethod_ReturnSameListThatisAdded()
        {
            EmployeePayrollOperations employeePayrollOperations = new EmployeePayrollOperations();
            List<EmployeePayroll> employeesListToBeAddedToDB = new List<EmployeePayroll>();
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Vaibhav", salary = 30000, startdate = DateTime.Now, phone = 9764510067, address = "Nagpur", BasicPay = 30000, Deductions = 2000, TaxablePay = 1000, IncomeTax = 500, NetPay = 21500, DepartmentID = 2});
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Sanjay", salary = 25000, startdate = DateTime.Now, phone = 9827786288, address = "Gondia", BasicPay = 22000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 20000, DepartmentID = 1 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Shubham", salary = 40000, startdate = DateTime.Now, phone = 86429532174, address = "Dharwad", BasicPay = 25000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 23000, DepartmentID = 1 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Minu", salary = 28000, startdate = DateTime.Now, phone = 7485321696, address = "Sagar", BasicPay = 18000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 17000, DepartmentID = 2 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Sai", salary = 40000, startdate = DateTime.Now, phone = 9652385137, address = "Kumta", BasicPay = 35000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 33000, DepartmentID = 2 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Akash", salary = 20000, startdate = DateTime.Now, phone = 8863259674, address = "Chitradurga", BasicPay = 20000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 18000, DepartmentID = 3 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Terissa", salary = 22000, startdate = DateTime.Now, phone = 7958623485, address = "Mirjan", BasicPay = 26000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 25000, DepartmentID = 3 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Srinivas", salary = 27000, startdate = DateTime.Now, phone = 9647853215, address = "Gokarna", BasicPay = 28000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 26000, DepartmentID = 1 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Manjesh", salary = 30000, startdate = DateTime.Now, phone = 9674851236, address = "Pavagada", BasicPay = 29000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 28000, DepartmentID = 1 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Suhas", salary = 38000, startdate = DateTime.Now, phone = 7648652952, address = "Shivamoga", BasicPay = 36000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 35000, DepartmentID = 2 });
            employeesListToBeAddedToDB.Add(new EmployeePayroll { name = "Navnath", salary = 35000, startdate = DateTime.Now, phone = 8899775684, address = "Udupi", BasicPay = 33000, Deductions = 1000, TaxablePay = 500, IncomeTax = 500, NetPay = 31000, DepartmentID = 1 });

            DateTime startDateTime = DateTime.Now;
            Console.WriteLine($"Data Addition to DB started on {startDateTime}");
            employeePayrollOperations.AddEmployeeToPayroll(employeesListToBeAddedToDB);

            DateTime endDateTime = DateTime.Now;
            Console.WriteLine($"Data Addition to DB ended on {endDateTime}");
            Console.WriteLine($"Time for Adding Data to DB is {endDateTime - startDateTime}");
            Assert.Pass();

           
        }
    }
}