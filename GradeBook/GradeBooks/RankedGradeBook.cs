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
            int a,b,c,d,e,f = 0;
            foreach (var student in Students)
            {
                i++;
                foreach (var grades in student.Grades)
                {
                    if (grades > 80) return 'A';
                    if (grades < 80 && grades > 60) return 'B';
                    if (grades > 60 && grades > 40) return 'C';
                    if (grades > 40 && grades > 20) return 'D';
                }
            }

            if (i < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to works");
            }
            else
            {
                return 'F';
            }
            
        }
    }
}