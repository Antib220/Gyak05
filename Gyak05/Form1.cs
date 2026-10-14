using Gyak05.StudentModels;

namespace Gyak05
{
    public partial class Form1 : Form
    {
        StudentContext context = new StudentContext();
        public Form1()
        {
            InitializeComponent();
            Frissit();
        }

        public void Frissit()
        {
            studentBindingSource.DataSource = context.Students.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            if(formAdd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            context.Students.Add(formAdd.Student);
            context.SaveChanges();
            Frissit();
        }
    }
}
