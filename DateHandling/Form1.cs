using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the days until due date
            DateTime currentDate = DateTime.Now;
            DateTime dueDate = DateTime.Parse(txtFutureDate.Text);
            TimeSpan timeTillDue = dueDate - currentDate;
            int daysTillDue = timeTillDue.Days;
            MessageBox.Show("Time till due: " + daysTillDue, "Hello");
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age
            DateTime currentDate = DateTime.Now;
            DateTime dueDate = DateTime.Parse(txtBirthDate.Text);
            TimeSpan timeTillDue = dueDate - currentDate;
            int daysTillDue = timeTillDue.Days;
            MessageBox.Show("Time till birthday: " + daysTillDue, "Hello");

        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}