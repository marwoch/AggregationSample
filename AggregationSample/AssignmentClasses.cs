using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationSample
{
    class Student
    {
        // complier will put in default constructor

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    class Instructor
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public string OfficeLocation { get; set; }
    }

    class Course
    {
        public Course()
        {
           GetInstructor();
           LoadRoster();
        }

        public string Description { get; set; }

        public byte NumCredits { get; set; }

        public string Number { get; set; }

        public string Title { get; set; }

        public List<Student> Roster { get; set; }

        public Instructor Instructor { get; private set; }

        public void LoadRoster()
        {
            //pretend to load students from the db
            List<Student> stuList = new List<Student>();

            Student s1 = new Student()
            {
                FirstName = "Bob",
                LastName = "Smith"
            };

            Student s2 = new Student()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            stuList.Add(s1);
            stuList.Add(s2);

            Roster = stuList;
        }

        private void GetInstructor()
        {
            //pretend to connect to db and find the actual course instructor
            var courseInstructor = new Instructor();

            courseInstructor.Email = "joe.programmer@cptc.edu";
            courseInstructor.Name = "Joe Programmer";
            courseInstructor.OfficeLocation = "B11 R111E";

            Instructor = courseInstructor;
        }
    }
}
