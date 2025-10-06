// Advancement in the grading system of the marks obtanin by the students 

using System;
namespace AdvanceInGrading
{
    class Program
    {
        static void Main(string[] args)
        {
            int examAssignments = 5;
            string[] studntName = new string[] { "Sophia", "Emma", "Logan", "Andrew" };
            int[] sophiaScore = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] emmaScore = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] loganScore = new int[] { 90, 85, 81, 96, 90, 89 };
            int[] andrewScore = new int[] { 90, 95, 87, 88, 96, 96 };

            int[] studentScores = new int[10];
            string currentStudentLetterGrade = "";

            Console.WriteLine("Student\t\tGrade\t\tGradeLetter");
            foreach (string name in studntName)
            {
                string currentStudent = name;
                if (currentStudent == "Sophia")
                {
                    studentScores = sophiaScore;
                }
                else if (currentStudent == "Emma")
                {
                    studentScores = emmaScore;
                }
                else if (currentStudent == "Logan")
                {
                    studentScores = loganScore;
                }
                else if (currentStudent == "Andrew")
                {
                    studentScores = andrewScore;
                }

                int sumAssignmentScores = 0;
                decimal currentStudentGrade = 0;
                int gradedAssignments = 0;

                foreach (int score in studentScores)
                {
                    gradedAssignments += 1;
                    if (gradedAssignments <= examAssignments)
                    {
                        sumAssignmentScores += score;
                    }
                    else
                    {
                        sumAssignmentScores += score / 10;
                    }
                }
                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;


                if (currentStudentGrade >= 97)
                {
                    currentStudentLetterGrade = "A+";
                }
                else if (currentStudentGrade >= 93)
                {
                    currentStudentLetterGrade = "A";
                }
                else if (currentStudentGrade >= 90)
                {
                    currentStudentLetterGrade = "A-";
                }
                else if (currentStudentGrade >= 87)
                {
                    currentStudentLetterGrade = "B+";
                }
                else if (currentStudentGrade >= 83)
                {
                    currentStudentLetterGrade = "B";
                }
                else if (currentStudentGrade >= 80)
                {
                    currentStudentLetterGrade = "B-";
                }
                else if (currentStudentGrade >= 77)
                {
                    currentStudentLetterGrade = "C+";
                }
                else if (currentStudentGrade >= 73)
                {
                    currentStudentLetterGrade = "C";
                }
                else if (currentStudentGrade >= 70)
                {
                    currentStudentLetterGrade = "C-";
                }
                else if (currentStudentGrade > 67)
                {
                    currentStudentLetterGrade = "D+";
                }
                else if (currentStudentGrade >= 63)
                {
                    currentStudentLetterGrade = "D";
                }
                else if (currentStudentGrade >= 60)
                {
                    currentStudentLetterGrade = "D-";
                }
                else
                {
                    currentStudentLetterGrade = "F";
                }
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}");
            }
        }
    }
}