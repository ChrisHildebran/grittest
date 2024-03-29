namespace Main
{
    using System;
 

    public static class Test
    {

        internal static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            nameFirst = Console.ReadLine();

            Console.Write("Enter your last name: ");
            nameLast = Console.ReadLine();
            Console.WriteLine("Hello " + nameFirst + " " + nameLast + "!");
            Console.WriteLine(questionBreak);

            Console.WriteLine("Initial Values");
            Console.WriteLine("Score Total: "        + scoreTotal);
            Console.WriteLine("Questions Answered: " + questionsAnswered);
            Console.WriteLine("Average so far is "   + scoreTotal / questionsAnswered);
            Console.WriteLine(questionBreak);

            var questions = new string[10];

            questions[0] = "New ideas and projects sometimes distract me from previous ones.";
            questions[1] = "Setbacks don't discourage me. I don't give up easily.";
            questions[2] = "I often set a goal but later choose to pursue a different one.";
            questions[3] = "I am a hard worker.";
            questions[4] = "I have a difficulty maintaining my focus on projects that take more than a few months to complete.";
            questions[5] = "I finish whatever 1 begin.";
            questions[6] = "My interests change from year to year.";
            questions[7] = "I am diligent. I never give up.";
            questions[8] = "I have been obsessed with a certain idea or project for a  short time but later lost interest.";
            questions[9] = "I have overcome setbacks to conquer an important challenge.";

            foreach (var s in questions)
            {
                Console.WriteLine("Question #" + (questionsAnswered + 1) + ": " + s);
                Console.WriteLine();

                if (questionHeader % 2 == 0)
                {
                    Console.WriteLine("-" + questionHeader15);
                }
                else
                {
                    Console.WriteLine("-" + questionHeader51);
                }

                questionHeader++;

                questionScore = int.Parse(Console.ReadLine());

                scoreTotal += questionScore;
                Console.WriteLine("Score Total: " + scoreTotal);

                questionsAnswered += 1;
                Console.WriteLine("Questions Answered: " + questionsAnswered);
                Console.WriteLine();
                Console.WriteLine("Average so far is " + scoreTotal / questionsAnswered);
                Console.WriteLine();

                Console.WriteLine(questionBreak);
            }
        }

        private static string nameFirst;

        private static string nameLast;

        private static readonly string questionBreak = "--------------------------------------------------";

        private static int questionHeader = 1;

        private static int questionsAnswered;

        private static double questionScore;

        private static double scoreTotal;

        private const string questionHeader15 = "[1-Not like me at all] [2-Not much like me] [3-Somewhat like me] [4-Mostly like me] [5-Very much like me]";

        private const string questionHeader51 = "[5-Not like me at all] [4-Not much like me] [3-Somewhat like me] [2-Mostly like me] [1-Very much like me]";

    }

}