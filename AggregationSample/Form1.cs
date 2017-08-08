using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AggregationSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Course c1 = new Course()
            {
                Title = "Advanced .NET",
                Number = "CPW 212",
                NumCredits = 5
            };

            Course c2 = new Course()
            {
                Title = ".NET Web",
                Number = "CPW 213",
                NumCredits = 5
            };

            var courses = new List<Course>()
            {
                c1,
                c2
            };
            //lstCourses.Items.Add(c1);
            //lstCourses.Items.Add(c2);

            lstCourses.DataSource = courses;
            lstCourses.DisplayMember = nameof(Course.Title);
        }

        private void btnViewInstructor_Click(object sender, EventArgs e)
        {
            //Course c = GetSelectedCourse();
            //Instructor courseInstructor = c.Instructor;
            //MessageBox.Show(courseInstructor.Name.ToUpper());

            Course c = GetSelectedCourse();
            MessageBox.Show(c.Instructor.Name.ToUpper());

            //MessageBox.Show(GetSelectedCourse().Instructor.Name.ToUpper());
        }

        private void btnViewRoster_Click(object sender, EventArgs e)
        {
            Course c = GetSelectedCourse();
            var display = new StringBuilder();
            foreach (Student s in c.Roster)
            {
                display.AppendLine($"{s.FirstName} {s.LastName}");
            }
            MessageBox.Show(display.ToString());
        }

        private Course GetSelectedCourse()
        {
            return (Course)lstCourses.SelectedItem;
        }
    }

}
