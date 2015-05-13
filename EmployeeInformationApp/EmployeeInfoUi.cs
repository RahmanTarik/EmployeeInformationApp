using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformationApp
{
    public partial class EmployeeInfoUi : Form
    {
        public EmployeeInfoUi()
        {
            InitializeComponent();
        }

        List<Employee> emplyeeList = new List<Employee>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (emplyeeList.Count <5)
            {
                Employee aEmployee = new Employee();
                aEmployee.id = idTextBox.Text;
                aEmployee.name = nameTextBox.Text;
                aEmployee.salary = Convert.ToDouble(salaryTextBox.Text);
                emplyeeList.Add(aEmployee);
                ClearText();
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show(" Can't enter more then 5 employee ");
            }
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            if (emplyeeList != null)
            {


                string employeeinfo = "";
                foreach (Employee employee in emplyeeList)
                {
                    employeeinfo += employee.id + "\t" + employee.name + "\t" + employee.salary + "\n";
                }

                MessageBox.Show("ID\tName\tSalary\n" + employeeinfo);
            }
            else
            {
                MessageBox.Show("nothing to show");
            }
        }

        private void ClearText()
        {
            idTextBox.Text = String.Empty;
            nameTextBox.Text = String.Empty;
            salaryTextBox.Text = String.Empty;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            emplyeeList.Clear();
            emplyeeList.Count.Equals(0);
            MessageBox.Show("Cleared");
            ClearText();
        }
    }
}
