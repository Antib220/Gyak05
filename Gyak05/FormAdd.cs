using Gyak05.StudentModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gyak05
{
    public partial class FormAdd : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public StudentModels.Student Student { get; set; } = new Student();
        public FormAdd()
        {
            InitializeComponent();
            bindingSource1.DataSource = Student;
            MessageBox.Show(dateTimePicker1.Value.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public bool Check()
        {
            if(string.IsNullOrWhiteSpace(Student.Name))
            {
                return false;
            }

            Regex r = new Regex(@"^[A-Z][A-Z0-9]{5}$");
            if (!r.IsMatch(Student.Neptun))
            {
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Check())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Hibás adatok!");
            }
        }
    }
}
