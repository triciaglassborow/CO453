using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        const int NAME = 0;
        const int MARK = 1;
        const int GRADE = 2;

        int min = 100;
        int max = 0;
        double mean;
        int total = 0;

        //setting up lists
        public string[] students = { "amy", "matt", "ed", "george", "jj", "john", "ben", "emily", "megs", "lucy" };
        public int[] marks = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public string[] grades = { "Invalid", "Invalid", "Invalid", "Invalid", "Invalid", "Invalid",
            "Invalid", "Invalid", "Invalid", "Invalid", };

        //for number of students iwth each grade
        int StatFail = 0;
        int StatThird = 0;
        int StatLower = 0;
        int StatUpper = 0;
        int StatFirst = 0;

        public void App03Run()
        {
            Header();
            Input();
            CalcGrades();
            ClassProfile();
            ClassStats();
            Output();
        }

        public void Header()
        {
            Console.WriteLine("\n                  APP 03                      ");
            Console.WriteLine("                  ------                      ");
            Console.WriteLine("Input student marks between 0-100 and their grades will be assigned\n");
        }


        public void Input()
        {
            //printing out each name on the class list and asking for their mark
            Console.WriteLine("Mark Input");
            Console.WriteLine("----------\n");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]+"'s mark:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            
        }

        public void CalcGrades()
        {
            //comparing each mark with the grade criteria and then assigning the grade to
            //the correct posstion in the grade list
            for (int i = 0; i < students.Length; i++)
            {
                if (marks[i] <= 39)
                {
                    grades[i] = "Fail";
                }

                else if (marks[i] <= 49)
                {
                    grades[i] = "Third Class";
                }

                else if (marks[i] <= 59)
                {
                    grades[i] = "Lower Second Class";
                }

                else if (marks[i] <= 69)
                {
                    grades[i] = "Upper Second Class";
                }

                else if (marks[i] <= 100)
                {
                    grades[i] = "First Class";
                }
            }
        }

        public void ClassStats()
        {
            //min mark. if mark entired is less then the current min, the
            //new min value is set to that of the mark it was just compared to
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }  
            }

            //max mark. if mark entired is more then the current max, the
            //new max value is set to that of the mark it was just compared to
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }   
            }

            //adding up every mark adn then dividing it by the total list length
            for (int i = 0; i < marks.Length; i++)
            {
                total = marks[i] + total;
            }
            
            mean = total / marks.Length;
        }

        //number of students with each grade
        public void ClassProfile()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == "Fail")
                {
                    StatFail++;
                }

                if (grades[i] == "Third Class")
                {
                    StatThird++;
                }

                if (grades[i] == "Lower Second Class")
                {
                    StatLower++;
                }

                if (grades[i] == "Upper Second Class")
                {
                    StatUpper++;
                }

                if (grades[i] == "First Class")
                {
                    StatFirst++;
                }
            }
        }

        public void Output()
        {
            Console.WriteLine("\nClass list");
            Console.WriteLine("----------");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i] + ":\n mark: "+ marks[i] + "\n grade: "+ grades[i]);
            }

            Console.WriteLine("\nClass Stats");
            Console.WriteLine("-----------");
            Console.WriteLine("Min mark: "+min);
            Console.WriteLine("Max mark: " + max);
            Console.WriteLine("Mean mark: " + mean);

            Console.WriteLine("\nClass Profile");
            Console.WriteLine("-------------");
            Console.WriteLine("Fail: "+ StatFail);
            Console.WriteLine("Third Class: " + StatThird);
            Console.WriteLine("Lower Second Class: " + StatLower);
            Console.WriteLine("Upper Second Class: " + StatUpper);
            Console.WriteLine("First Class: " + StatFirst);
            
        }

    }


        

        
}


