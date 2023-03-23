using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        public void Run()
        {
          InputMarks();
          ConvertToGrade();
          OutputGrades();

        }
        // Constants (Grade Boundaries)
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;
        private int mean_mark;
        private int total_mark;
        private int mark;

        // Properties
        public string[] Students { get; set; }

        public string[] Marks { get; set; }

        public string[] GradeProfile { get; set; }

        public string[] Mean { get; set; }

        public string[] Minimum { get; set; }

        public string[] Maximum { get; set; }
    
        // Attributes

        /// <summary>
        /// Class constructer is called when an 
        /// object is created and sets up an array of students
        /// </summary>

        public StudentGrades()
        {
            OutputHeading();
            InputMarks();
            int mean_mark = 0;
            int total_mark = 0;
            int[] marks = new int[10];
            string[] Students = new string[]
            {
            "kiran","raman","ravleen","aman",
            "deepak","harsh","komal","randeep",
            "rohan","honey"
            };
            ConvertToGrade();
            OutputGrades();

            for(int i = 0;i<10; i++)
            {
                string total_marks = null;
                total_marks += Marks[i];
                mean_mark = (total_mark / 10);
            }

            int minimum_mark = marks[0];
            int maximum_mark = marks[0];
            for(int i = 0;i<10; i++)
            {
              if(marks[i] > maximum_mark)
              {
                maximum_mark = marks[i];
              }
              if(marks[i] < minimum_mark)
              {
                minimum_mark = marks[i];
              }
            }

            Console.WriteLine("\n");
            Console.WriteLine("\t mean marks  :  {00}", mean_mark);
            Console.WriteLine("\t Minimum marks  : {00}", minimum_mark);
            Console.WriteLine("\t Maximum marks : {00}", maximum_mark);
            Console.WriteLine("\n\n");
            Console.ReadKey();
            
        }

        /// <summary>
        /// Input a mark betwwen 0 - 100 for each student
        /// and store it in the Marks array        
        /// </summary>

        private void InputMarks()
        {
            int[] marks = new int[10];
            for(int i = 0 ; i<10 ; i++)
            {
              Console.WriteLine("\tEnter marks of " + Students[i] + " :  ");
              Console.ReadLine();
            }
        }

        /// <summary>
        /// List all the students and display their
        /// name and cuurent marks and grades
        /// </summary>
        private void OutputGrades()
        {
            int[] marks = new int[10];
            for(int i = 0 ; i<10 ; i++)
            {
              Console.WriteLine("\t Grade of " + Students[i] + " is :  " );
              Console.ReadLine();
            }
        }

        /// <summary>
        /// Convert a student mark to grade 
        /// from F(Fail) to A(First Class)
        /// </summary>

        public Grades ConvertToGrade()
        {
            if (mark >= 0 && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if (mark >= LowestGradeA && mark <= HighestMark)
            {
                return Grades.A;
            }
            return Grades.F;
        }

        public void CalculateGrade()
        {
            throw new NotImplementedException();
        }

        private void OutputHeading()
        {
          Console.WriteLine("\n");
            Console.WriteLine("\n Converter for students marks into grades");
            Console.WriteLine("\n          by kirandeeep kaur             ");
            Console.WriteLine("\n");

        }

        /// <summary>
        /// Claculate and display the proportion of students
        /// achieving each of the grades
        /// </summary>

//public void CalculateGradeProfile()
  //      {
    //        for (int i = 0; i < GradeProfile.Length; i++)
      //      {
        //        GradeProfile[i] = 0;
          //  }

            //foreach (int mark in Marks)
            //{
              //  Grade grade = ConvertToGrade(mark);
                //GradeProfile[(int)grade]++;
            //}
            //OutputGradeProfile();
        //}

        //private void OutputGradeProfile()
        //{
          //  Grade grade = grade.X;
            //Console.WriteLine();

            //foreach (int count in GradeProfile)
            //{
              //  int percentage = count * 100 / Marks.Length;
                //Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                //grade++;
            //}

            //Console.WriteLine();
        //}

    }

}
