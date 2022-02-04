using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    public partial class APIForm : Form
    {
        public APIForm()
        {
            InitializeComponent();
        }

        public static int iterator = 0;
        Program1.Datum[] data;

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (iterator > 0)
            {
                iterator--;
                idOutputLabel.Text = data[iterator].id + "";
                nameOutputLabel.Text = data[iterator].employee_name;
                salaryOutputLabel.Text = String.Format("{0:C}", data[iterator].employee_salary);
                ageOutputLabel.Text = data[iterator].employee_age + "";
            }
            else
            {
                iterator = data.Length - 1;
                idOutputLabel.Text = data[iterator].id + "";
                nameOutputLabel.Text = data[iterator].employee_name;
                salaryOutputLabel.Text = String.Format("{0:C}", data[iterator].employee_salary);
                ageOutputLabel.Text = data[iterator].employee_age + "";
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (iterator < data.Length - 1)
            {
                iterator++;
                idOutputLabel.Text = data[iterator].id + "";
                nameOutputLabel.Text = data[iterator].employee_name;
                salaryOutputLabel.Text = String.Format("{0:C}", data[iterator].employee_salary);
                ageOutputLabel.Text = data[iterator].employee_age + "";
            }
            else
            {
                iterator = 0;
                idOutputLabel.Text = data[iterator].id + "";
                nameOutputLabel.Text = data[iterator].employee_name;
                salaryOutputLabel.Text = String.Format("{0:C}", data[iterator].employee_salary);
                ageOutputLabel.Text = data[iterator].employee_age + "";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void APIForm_Load(object sender, EventArgs e)
        {
            try
            {
                data = Program1.getEmployeeData().data;
                idOutputLabel.Text = data[iterator].id + "";
                nameOutputLabel.Text = data[iterator].employee_name;
                salaryOutputLabel.Text = String.Format("{0:C}", data[iterator].employee_salary);
                ageOutputLabel.Text = data[iterator].employee_age + "";
            }
            catch(Exception e1)
            {
                this.Close();
            }
        }
    }
}
