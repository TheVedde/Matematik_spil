using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{

    enum Disciplines {Addition, Multiplication, Division, Subtraction };
   

    class Discipline
    {

        public void PrintDiscipline()
        {
            Console.WriteLine("what kind of discipline would you like?\n");
            Console.WriteLine("There is addition, division, multiplication and subtraction.");
            discipline = Console.ReadLine();
 
        }

        public string discipline;
    }
}
