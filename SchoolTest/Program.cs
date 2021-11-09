using System;
using System.IO;

namespace SchoolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstScoreList = "oldScores.txt";
            var revisedScoreList = "newScores.txt";

            int indexOfDash;
            string name;
            int initialScore;
            int newScore;
            string scoreText;

            //File.Create(revisedScoreList);
            foreach (var score in File.ReadAllLines(firstScoreList))
            {
                indexOfDash = score.IndexOf("-");

                name = score.Substring(0, indexOfDash);
                initialScore = int.Parse(score.Substring(indexOfDash + 1));

                if (initialScore > 50)
                {
                    newScore = initialScore + 5;
                }
                else if (initialScore < 50)
                {
                    newScore = initialScore + 10;
                }
                else
                {
                    newScore = initialScore;
                }
                scoreText = name + "-" + newScore;
                File.AppendAllLines(revisedScoreList,new string[] {scoreText});
            }

            Console.WriteLine("Scores updated, check file to see changes.");
            Console.WriteLine("File location at bin>Debug>net5.0>newScores");

        }
    }
}
