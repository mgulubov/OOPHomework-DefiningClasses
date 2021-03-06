﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem.Classes.StudentClasses.StudentTypes.CurrentStudentTypes
{
    class OnsiteStudent : CurrentStudent
    {
        private int _numberOfVisits;

        public OnsiteStudent(String firstName, String lastName, int age,
            int studentNumber, double avgGrade, String currentCourse, int numberOfVisits)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.StudentNumber = studentNumber;
            this.AvgGrade = avgGrade;
            this.CurrentCourse = currentCourse;
            this.NumberOfVisits = numberOfVisits;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}\n" +
                "Age: {2}\n" +
                "Student Number: {3}\n" +
                "Avg Grade: {4}\n" +
                "Current Course: {5}\n" +
                "Number Of Visits: {6}\n",
                this.FirstName, this.LastName,
                this.Age,
                this.StudentNumber,
                this.AvgGrade,
                this.CurrentCourse,
                this.NumberOfVisits);
        }

        public int NumberOfVisits
        {
            set
            {
                this._numberOfVisits = value;
            }
            get
            {
                return this._numberOfVisits;
            }
        }

        public override bool IsOnsite()
        {
            return true;
        }
    }
}
