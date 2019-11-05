using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{

    public enum Disciplines {Addition, Multiplication, Division, Subtraction };
   
    
    class Discipline
    {
        
        public void PrintDiscipline()
        {
            Console.WriteLine("what kind of discipline would you like?\n");
            Console.WriteLine("There is addition, division, multiplication and subtraction.");

            while (!Enum.TryParse<Disciplines>(Console.ReadLine(), out discipline))
            {
                Console.WriteLine("WRONG!!!");
            }

            
        }



        public Disciplines discipline;
       
    }
}
