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

                switch (student.Grades)
                {
                    
                }
            }

            if (i < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to works");
            }
            else
            {
                switch (Type)
                {
                    
                }
                return 'F';
            }
            
        }
    }
}