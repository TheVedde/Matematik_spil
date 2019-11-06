using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{


    class Question
    {
       // Discipline discipline = new Discipline();
        Validator validator = new Validator();

        public void WriteQuestion()
        {
            Console.WriteLine("what is " + Game.Instance._x + " " + Game.Instance._tempOperator + " " + Game.Instance._y + "?");
            
            int.TryParse(Console.ReadLine(), out int guess);

            Game.Instance._guess = guess;
        }

       

       
        
    }
}
