using System;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions =
            {
                "Q1- 27 + 11 = ?",
                "Q2- The capital of spain is.... .",
                "Q3- One of the five senses........ . ",
                "Q4- How many eyes do we have? ",
                "Q5- The unit of electrical current is......",
                "Q6- when is the winter?"
            };

            string[] correctAnswers = {
                "38",
                "Madrid",
                "taste",
                "2",
                "ampere",
                "December,January,February"
            };

            string[] answers =
            {
                "a- 102    b- 455    c- 3377   d- 38 ",
                "a- Madrid    b-Samanod   c-El Mahalla   d-Talkha",
                "a-Problem solving   b-taste   c- love   d-c# ",
                "a- 55     b- 2      c-none     d- heart vision",
                "a- Ampere   b-meter    c-kelvin   d-volt",
                "a- 8/27     b- December,January,February   c- 6/14   d- 7/18"
            };

            Console.WriteLine("Welcome to the quiz! Please answer the following questions:");
            Console.WriteLine("---------------------------------------------\n");

            Quiz(questions, correctAnswers, answers);
        }

        static void Quiz(string[] questions, string[] cans, string[] ans)
        {
            int score = 0;
            int correctAnsCount = 0;
            int falseAnswersCount = 0;
            int totalPoints = questions.Length * 10;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.WriteLine(ans[i]);

                string answer = (Console.ReadLine() ?? string.Empty).Trim();

               
                if (string.Equals(answer, cans[i], StringComparison.OrdinalIgnoreCase))
                {
                    score += 10;
                    correctAnsCount++;
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    falseAnswersCount++;
                    Console.WriteLine($"Wrong. The correct answer is: {cans[i]}\n");
                }

                Console.WriteLine("---------------------------------------------\n");
            }

            int finalPercent = CalculateScore(score, totalPoints);
            ViewScore(finalPercent, correctAnsCount, falseAnswersCount);
        }

        static int CalculateScore(int score, int totalPoints)
        {
            if (totalPoints == 0) return 0;
            return (score * 100) / totalPoints;
        }

        static void ViewScore(int finalPercent, int correctCount, int wrongCount)
        {
            if (finalPercent >= 80)
            {
                Console.WriteLine("Excellent");
            }
            else if (finalPercent >= 50)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Try again!!");
            }

            Console.WriteLine($"Your score is: {finalPercent}%");
            Console.WriteLine($"Correct answers: {correctCount}");
            Console.WriteLine($"False answers: {wrongCount}");
        }
    }
}
