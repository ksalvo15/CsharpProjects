using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter uin your firstname");
            string date = DateTime.Today.ToShortDateString();
            string uname = Console.ReadLine();
            string msg = $"\nWelscome back {uname}. Today is {date}";
            Console.WriteLine(msg);

            string path = @"C:\Users\kelse\Documents\Tech-Academy-Files\GitHub\CsharpProjects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;
            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines) 
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score" + avgScore);


            Console.WriteLine("\n\npress any key to exit");
            Console.ReadKey();
        }
    }
}
