using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{
    class Difficulty
    {
        public int x;
        public int y;

        static Random rand = new Random();

        public void difficultyCheck(int difficulty)
        {
            
            if (difficulty == 1)
            {
                int y = rand.Next(1, 11);
                int x = rand.Next(1, 11);
            }
            else if (difficulty == 2)
            {
                y = rand.Next(1, 101);
                x = rand.Next(1, 101);

            }
            else if (difficulty == 3)
            {
                y = rand.Next(1, 1001);
                x = rand.Next(1, 1001);

            }
            else if (difficulty == 4)
            {
                y = rand.Next(1, 10000);
                x = rand.Next(1, 10000);
            }



        }


    }
}
