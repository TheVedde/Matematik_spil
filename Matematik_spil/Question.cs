using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{


    class Game
    {

        private int guess;
        private int x;
        private int y;
        int _tempdifficulty;
        private string tempOperator;
        public Disciplines _tempDiscipline;

        Discipline discipline = new Discipline();
        Difficulty difficulty = new Difficulty();
        Validator validator = new Validator();

        //    Question question = new Question();

        public int _x { get => x; set => x = value; }
        public int _y { get => y; set => y = value; }
        public string _tempOperator { get => tempOperator; set => tempOperator = value; }
        public int _guess { get => guess; set => guess = value; }


        private static Game _instance = null;
        static Game()
        {
            if (_instance == null)
                _instance = new Game();
        }

        public static Game Instance { get => _instance; }

        
        public void Initialize(){
           
            _tempDiscipline = discipline.PrintDiscipline();

            _tempOperator = discipline.DisciplineOperation();
            _tempdifficulty = validator.DifficultySetting();
             difficultyCheck(_tempdifficulty);
             

            

        }

       

        public void EndGame()
        {
            throw new NotImplementedException();
        }

        public void NextQuestion()
        {
            throw new NotImplementedException();
        }

        public void difficultyCheck(int difficulty)
        {
            Random rand = new Random();

            switch (difficulty)
            {
                case 1:
                    y = rand.Next(1, 11);
                    x = rand.Next(1, 11);
                    break;
                case 2:
                    y = rand.Next(10, 101);
                    x = rand.Next(10, 101);
                    break;
                case 3:
                    y = rand.Next(100, 1001);
                    x = rand.Next(100, 1001);
                    break;
                case 4:
                    y = rand.Next(1000, 10001);
                    x = rand.Next(1000, 10001);
                    break;
            }
        }


    }

    class Gamelogic
    {
        Validator validator = new Validator();
        Question question = new Question();

        private static Gamelogic _instance = null;

        static Gamelogic()
        {
            if (_instance == null)
                _instance = new Gamelogic();
        }

        public static Gamelogic Instance { get => _instance; }
       
        private bool _iscorrect;

        public bool IsCorrect { get => _iscorrect; set => _iscorrect = value; }

        public void GameLoop()
        {
            question.WriteQuestion();

            
            if (validator.AnswerValidator(Game.Instance._x, Game.Instance._y, Game.Instance._guess))
            {

                Console.WriteLine("That is correct");
                Game.Instance.NextQuestion();
            }

            else
            {
                Console.WriteLine("That is not correct \n");
                Console.WriteLine("You have lost.");
                Game.Instance.EndGame();
            }
        }


    }

    class Question
    {
       // Discipline discipline = new Discipline();
        Difficulty difficulty = new Difficulty();
        Validator validator = new Validator();

        public void WriteQuestion()
        {
            Console.WriteLine("what is " + Game.Instance._x + " " + Game.Instance._tempOperator + " " + Game.Instance._y + "?");
            
            int.TryParse(Console.ReadLine(), out int guess);

            Game.Instance._guess = guess;
        }

       

       
        
    }
}
