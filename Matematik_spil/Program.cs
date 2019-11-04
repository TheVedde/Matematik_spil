using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{
    class Program
    {
      static int x = 0;
      static int y = 0;

        static Random rand = new Random();
        private static bool _isRunning;
        static void Main(string[] args)
        {
            Question question = new Question();
            _isRunning = true;

            question.PrintDiscipline();
            while (_isRunning)
            {
                question.DifficultySetting();
                switch (question.discipline)
                {
                    case "quit":
                        _isRunning = false;

                        break;

                    case ("addition"):
                        difficultyCheck(question.difficulty);
                        Console.WriteLine("what is: " + x + " + " + y + "?");
                        int trial = Convert.ToInt32(Console.ReadLine());
                        int answer = x + y;
                        if (trial == answer)
                        {
                            Console.WriteLine("That is correct");
                        }
                        else Console.WriteLine("That is wrong.");
                        break;

                    case ("division"):
                        difficultyCheck(question.difficulty);
                        break;

                    case ("multiplication"):
                        difficultyCheck(question.difficulty);
                        break;

                    case ("subtraction"):
                        difficultyCheck(question.difficulty);
                        break;

                    default:
                        Console.WriteLine("That is not an available input.");
                        break;          
                }

                Console.ReadKey();
            }

        }
        static void difficultyCheck(int difficulty)
        {
            const int startnum = 1;
            if (difficulty == 1)
            {
                y = rand.Next(startnum, 11);
                x = rand.Next(startnum, 11);
            }
            else if (difficulty == 2)
            {
                y = rand.Next(startnum, 101);
                x = rand.Next(startnum, 101);

            }
            else if (difficulty == 3)
            {
                y = rand.Next(startnum, 1001);
                x = rand.Next(startnum, 1001);

            }
            else if (difficulty == 4)
            {
                y = rand.Next(startnum, 10000);
                x = rand.Next(startnum, 10000);
            }



        }
    }
}
