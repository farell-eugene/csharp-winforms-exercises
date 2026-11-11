using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Course
    {
        public string CourseName { get; set; }
        public int Weight { get; set; }
        public float Assignment { get; set; }
        public float MidTerm { get; set; }
        public float FinalExam { get; set; }
        public float Total { get; set; }
        public string Grade { get; set; }

        public Course(string courseName, int weight, float assignment, float midTerm, float finalExam)
        {
            CourseName = courseName;
            Weight = weight;
            Assignment = assignment;
            MidTerm = midTerm;
            FinalExam = finalExam;
            Total = calculateTotal();
        }


        public float calculateTotal()
        {
            return Total = (float)((Assignment * 0.3) + (MidTerm * 0.3) + (FinalExam * 0.4));
        }
        public void CalculateGrade()
        {
            double totalScore = (Assignment * 0.3) + (MidTerm * 0.3) + (FinalExam * 0.4);

            if (totalScore >= 85) Grade = "A";
            else if (totalScore >= 80) Grade = "A-";
            else if (totalScore >= 75) Grade = "B+";
            else if (totalScore >= 70) Grade = "B";
            else if (totalScore >= 65) Grade = "B-";
            else if (totalScore >= 60) Grade = "C+";
            else if (totalScore >= 55) Grade = "C";
            else if (totalScore >= 50) Grade = "C-";
            else Grade = "F";
        }
    }
}

