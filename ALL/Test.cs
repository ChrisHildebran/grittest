namespace Gritv3.GritTest
{
    using System;

    public static class Test
    {
        #region Constants

        private const string _questionHeader15 = "[1-Not like me at all] [2-Not much like me] [3-Somewhat like me] [4-Mostly like me] [5-Very much like me]";

        private const string _questionHeader51 = "[5-Not like me at all] [4-Not much like me] [3-Somewhat like me] [2-Mostly like me] [1-Very much like me]";

        #endregion

        #region Fields

        private static string _nameFirst;

        private static string _nameLast;

        private static readonly string _questionBreak = "--------------------------------------------------";

        private static int _questionHeader = 1;

        private static int _questionsAnswered;

        private static double _questionScore;

        private static double _scoreTotal;

        #endregion

        #region Methods

        internal static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            _nameFirst = Console.ReadLine();

            Console.Write("Enter your last name: ");
            _nameLast = Console.ReadLine();
            Console.WriteLine("Hello " + _nameFirst + "!");
            Console.WriteLine(_questionBreak);

            Console.WriteLine("Initial Values");
            Console.WriteLine("Score Total: " + _scoreTotal);
            Console.WriteLine("Questions Answered: " + _questionsAnswered);
            Console.WriteLine("Average so far is " + _scoreTotal / _questionsAnswered);
            Console.WriteLine(_questionBreak);

            string[] questions = new string[10];

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
                Console.WriteLine("Question #" + (_questionsAnswered + 1) + ": " + s);
                Console.WriteLine();

                if (_questionHeader % 2 == 0)
                {
                    Console.WriteLine("-" + _questionHeader15);
                }
                else
                {
                    Console.WriteLine("-" + _questionHeader51);
                }

                _questionHeader++;

                _questionScore = int.Parse(Console.ReadLine());

                _scoreTotal += _questionScore;
                Console.WriteLine("Score Total: " + _scoreTotal);

                _questionsAnswered += 1;
                Console.WriteLine("Questions Answered: " + _questionsAnswered);
                Console.WriteLine();
                Console.WriteLine("Average so far is " + _scoreTotal / _questionsAnswered);
                Console.WriteLine();

                Console.WriteLine(_questionBreak);
            }
        }

        #endregion
    }
}