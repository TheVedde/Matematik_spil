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


        public void PrintDiscipline()
        {
            Console.WriteLine("what kind of discipline would you like?\n");
            Console.WriteLine("There is addition, division, multiplication and subtraction.");
             discipline = Console.ReadLine();

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
        public string discipline;
    }
}
