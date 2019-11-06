using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{


    class Game
    {
        private static Game _instance = null;
        private int guess;
        private int firstNumb;
        private int lastNumb;
        int _tempdifficulty;
        private string tempOperator;
        private Disciplines _tempDiscipline;
        private bool _iscorrect;
        private static Discipline _classDiscipline = null;
        private static Validator _validator = null;



        Question question = new Question();
        
        static Game()
        {
            if (_instance == null)
                _instance = new Game();
            if(_classDiscipline == null)
            {
                _classDiscipline = new Discipline();
            }
            if(_validator == null)
            {
                _validator = new Validator();
            }
        }

        public static Game Instance { get => _instance; }
        public static Discipline ClassDiscipline { get => _classDiscipline; }
        public static Validator Validator { get => _validator; }


        public void GameLoop()
        {
            difficultyCheck(_tempdifficulty);
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
                Console.ReadKey();
                Game.Instance.EndGame();
            }


        }

        public void Initialize()
        {
            _tempDiscipline = classDiscipline.PrintDiscipline();
            _tempOperator = classDiscipline.DisciplineOperation();
            _tempdifficulty = validator.DifficultySetting();
        }

        public void EndGame()
        {
            Environment.Exit(0);
        }

        public void NextQuestion()
        {
            GameLoop();
        }

        public void difficultyCheck(int difficulty)
        {
            Random rand = new Random();
            
            switch (difficulty)
            {
                case 1:
                    lastNumb = rand.Next(1, 11);
                    firstNumb = rand.Next(lastNumb, 11);
                 
                    break;
                case 2:
                    lastNumb = rand.Next(10, 101);
                    firstNumb = rand.Next(lastNumb, 101);
                    break;
                case 3:
                    lastNumb = rand.Next(100, 1001);
                    firstNumb = rand.Next(lastNumb, 1001);
                    break;
                case 4:
                    lastNumb = rand.Next(1000, 10001);
                    firstNumb = rand.Next(lastNumb, 10001);
                    break;
            }
        }

        public Validator validator { get => _validator; set => _validator = value; }
        public Discipline classDiscipline { get => _classDiscipline; set => _classDiscipline = value; }
        public Disciplines _discipline { get => _tempDiscipline; set => _tempDiscipline = value; }
        public int _x { get => firstNumb; set => firstNumb = value; }
        public int _y { get => lastNumb; set => lastNumb = value; }
        public string _tempOperator { get => tempOperator; set => tempOperator = value; }
        public int _guess { get => guess; set => guess = value; }
        public bool IsCorrect { get => _iscorrect; set => _iscorrect = value; }

    }
}
