using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
            
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int i = 0;

            char gradeChar = '_';
            foreach (var student in Students)
            {
                i++;
                foreach (var grades in student.Grades)
                {
                    if (grades >= 80) gradeChar = 'A';
                    if (grades <= 79 && grades >= 60) gradeChar = 'B';
                    if (grades >= 59 && grades >= 40) gradeChar = 'C';
                    if (grades >= 39 && grades >= 20) gradeChar = 'D';
                    if (grades < 19) gradeChar = 'F';
                }
            }

            if (i < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to works");
            }

            return gradeChar;
        }
    }
}