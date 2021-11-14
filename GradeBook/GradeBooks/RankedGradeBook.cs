using System;
using System.Linq;

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
            int amountOfStudent = 0;

            char gradeChar = '_';
            foreach (var student in Students)
            {
                amountOfStudent++;
            }

            if (amountOfStudent < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to works");
            }

            var threshold = (int)Math.Ceiling(Students.Count * 0.2);
            
            
            var grades = Students.OrderByDescending(e=>e.AverageGrade);

            return gradeChar;
        }
    }
}