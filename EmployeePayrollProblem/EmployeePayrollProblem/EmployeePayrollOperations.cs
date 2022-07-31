using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollProblem
{
    public class EmployeePayrollOperations
    {
        public List<EmployeePayroll> employeePayroll = new List<EmployeePayroll>();

        //Method to Read all the data in the database
        public static void ReadDataFromDataBase()
        {
            string SQL = "SELECT * FROM employee_payroll";
            string connectingstring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee_payroll_service;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectingstring);
            SqlCommand cmd = new SqlCommand(SQL, connection);
            connection.Open();
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                List<EmployeePayroll> employeePayroll = new List<EmployeePayroll>();
                while (reader.Read())
                {
                    var employee = new EmployeePayroll();
                    employee.id = reader.GetInt32(0);
                    employee.name = reader.GetString(1);
                    employee.salary = reader.GetInt32(2);
                    employee.startdate = reader.GetDateTime(3);
                    employee.gender = reader.GetString(4);
                    employee.phone = reader.GetInt64(5);
                    employee.address = reader.GetString(6);
                    employee.BasicPay = reader.GetDouble(7);
                    employee.Deductions = reader.GetDouble(8);
                    employee.TaxablePay = reader.GetDouble(9);
                    employee.IncomeTax = reader.GetDouble(10);
                    employee.NetPay = reader.GetDouble(11);
                    employee.DepartmentID = reader.GetInt32(12);
                    employeePayroll.Add(employee);
                }
                reader.Close();
                foreach (var emp in employeePayroll)
                {
                    Console.WriteLine("\nID :" + emp.id +
                        "\nName :" + emp.name +
                        "\nSalary :" + emp.salary +
                        "\nStart Date : " + emp.startdate +
                        "\nGender :" + emp.gender +
                        "\nPhone :" + emp.phone +
                        "\nAddress :" + emp.address +
                        "\nBasic Pay :" + emp.BasicPay +
                        "\nDeductions :" + emp.Deductions +
                        "\nTaxable Pay :" + emp.TaxablePay +
                        "\nIncome Tax :" + emp.TaxablePay +
                        "\nNet Pay :" + emp.NetPay +
                        "\nDepartment ID :" + emp.DepartmentID);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //UC1-Adding Multiple employee to Payroll
        public void AddEmployeeToPayroll(List<EmployeePayroll> employeePayroll)
        {
            employeePayroll.ForEach(employeedata =>
            {
                Console.WriteLine("Employee being added: " + employeedata.name);
                this.AddEmployeeToPayroll(employeedata);
                Console.WriteLine("Employee added: " + employeedata.name);
            });
            Console.WriteLine(this.employeePayroll.ToString());
        }

        public void AddEmployeeToPayroll(EmployeePayroll employeedata)
        {
            employeePayroll.Add(employeedata);
        }

        //UC2-Adding Multiple employee to Payroll with threads
        public void AddEmployeeToPayrollWithThread(List<EmployeePayroll> employeePayroll)
        {
            employeePayroll.ForEach(employeedata =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeedata.name);
                    this.AddEmployeeToPayroll(employeedata);
                    Console.WriteLine("Employee added: " + employeedata.name);
                });
                thread.Start();

            });
            Console.WriteLine(this.employeePayroll.ToString());
        }
    }
}

