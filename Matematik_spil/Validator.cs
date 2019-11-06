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

    class Validator
    {
        public bool _iscorrect;

        Discipline discipline = new Discipline();
    //    Difficulty difficulty = new Difficulty();
        

        public int DifficultySetting()
        {
            int difficulty;
            Console.WriteLine("at what difficulty would you like your game? 1 - 4.");

            while (!int.TryParse(Console.ReadLine(), out difficulty))
            {
                Console.Write("Please type a valid input: ");    
            }
            return difficulty;
            
        }


        public bool AnswerValidator(int x, int y, int guess)
        {
            
            if (discipline.DisciplineOperation().Operator(Game.Instance._x, Game.Instance._y, Game.Instance._guess))
            {
                return _iscorrect = true;
            }

            else
            {
                return _iscorrect = false;
            }

        }
       
        

        



    }
}
