using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{
    class Question
    {
        List<int> Difficulty = new List<int> {1, 2, 3, 4};
        Discipline discipline = new Discipline();



        public void Test()
        {
            Console.WriteLine("what is? ");
        
            if(Answer == true)
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

            //difficulty = Convert.ToInt32(Console.ReadLine());
            while (!int.TryParse(Console.ReadLine(), out difficulty))
            {
                Console.Write("Please type a valid input: ");
            }
        }

        public int difficulty;

        public bool Answer { get; private set; }
    }
}
