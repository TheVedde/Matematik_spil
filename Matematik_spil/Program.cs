using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{
    class Program
    {
    
        private static bool _isRunning;
        static void Main(string[] args)
        {
            Question question = new Question();
            Discipline discipline = new Discipline();
            Validator validator = new Validator();
            Gamelogic gamelogic = new Gamelogic();
            _isRunning = true;

            Game.Instance.Initialize();
            gamelogic.GameLoop();

        }
        
    }
}
