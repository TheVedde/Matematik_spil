using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{
    public static class Extender
    {
        public static Boolean Operator(this string logic, int x, int y, int expected)
        {
            switch (logic.ToLower())
            {
                case "+": return x + y == expected;
                case "-": return x - y == expected;
                case "/": return x / y == expected;
                case "*": return x * y == expected;
            }
            return false;
        }
    }

    class Question
    {
        Discipline discipline = new Discipline();
        Difficulty difficultysetting = new Difficulty();
       
        public void WriteQuestion()
        {

            DisciplineValidator();
            difficultysetting.x = x;
            difficultysetting.y = y;
            Console.WriteLine("what is " + x + " " + Operation + " " + y + "?");
            int.TryParse(Console.ReadLine(), out guess);            
            AnswerValidater();
            if (_iscorrect == true)
            {
                Console.WriteLine("That is correct");
                NextQuestion();
            }

            else {
                Console.WriteLine("That is not correct \n");
                Console.WriteLine("You have lost.");
                EndGame();
            }
        }

        public void DisciplineValidator()
        {
            switch (discipline.discipline)
            {
                case Disciplines.Addition:
                    Operation = "+";
                    break;
                case Disciplines.Division:
                    Operation = "/";
                    break;

                case Disciplines.Multiplication:
                    Operation = "*";
                    break;
                case Disciplines.Subtraction:
                    Operation = "-";
                    break;
            }

        }

        private bool AnswerValidater()
        {   

            if(Operation.Operator(x, y, guess))
            {
                return _iscorrect = true;
            }

            else {
                return _iscorrect = false;
            }
        }

        private void EndGame()
        {
            throw new NotImplementedException();
        }

        private void NextQuestion()
        {
            throw new NotImplementedException();
        }

        public void DifficultySetting()
        {
                Console.WriteLine("at what difficulty would you like your game? 1 - 4.");


            while (!int.TryParse(Console.ReadLine(), out difficulty))
            {
                Console.Write("Please type a valid input: ");
                difficultysetting.difficultyCheck(difficulty);
            }
            difficultysetting.difficultyCheck(difficulty);
        }

        public int difficulty;
        public int x;
        public int y;
        public int guess;
        public bool _iscorrect;
        public string Operation { get; private set; }
    }
}
