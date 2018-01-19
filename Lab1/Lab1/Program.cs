using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        public static void inputTest(string[] test, string name)
        {
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine("Please enter the answer submitted by " + name + " for question " + (i+1) + ": ");
                test[i] = Console.ReadLine();
            }
        }
        public static void gradeTest(string[] test, string name)
        {
            int score = 0;
            string[] answers = { "b", "d", "a", "a", "c", "a", "b", "a", "c", "d", "b", "c", "d", "a", "d", "c", "c", "b", "d", "a" };
            string incorrect = "";
            string grade = "";
            for (int i = 0; i<answers.Length; i++)
            {
                if (test[i].ToLower() != answers[i])
                {
                    incorrect += " " + (i+1);
                }
                else
                {
                    score++;
                }
            }
            if (score >= 15)
            {
                grade = "passed";
            }
            else
            {
                grade = "failed";
            }
            Console.WriteLine(name + " " + grade + " with a score of " + score + "/20 on this test. \nQuestions answered wrong are:" + incorrect + ".");
        }
        static void Main(string[] args)
        {
            string EXIT = "";
            Console.WriteLine("Welcome to the Test Grading Program.");
            string[] test = {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""};
            while (EXIT != "exit")
            {
                Console.WriteLine("Please enter the name of this student who took this test. ");
                string stuName = Console.ReadLine();
                inputTest(test,stuName);
                gradeTest(test,stuName);
                Console.WriteLine("This is the end of the program. Enter EXIT to exit the program or Hit the enter key to continue grading tests. ");
                EXIT = Console.ReadLine().ToLower();
            }
        }
    }
}
