using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfLogin.Context;
using WpfLogin.Models;

namespace WpfLogin.Controller
{
    class EmployeeController
    {
        public void Addemployee(string first, string last, string address, string email )
        {
            var result = 0;
            User user = new User();
            Employee employee = new Employee();
            MyContext ObjContext = new MyContext();

            employee.First_name = first;
            employee.Last_name = last;
            employee.Address = address;
            employee.Personal_Email = email;
            ObjContext.Employees.Add(employee);
            result = ObjContext.SaveChanges();

            if (result > 0)
            {
                MessageBox.Show("Register Successful");
            }
            else
            {
                MessageBox.Show("Register Failed");
            }


        }
    }
}
