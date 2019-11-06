using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{

    public enum Disciplines {addition, multiplication, division, subtraction };
    

    class Discipline
    {

        public string Operation;
        public Disciplines PrintDiscipline()
        {
            Console.WriteLine("what kind of discipline would you like?\n");
            Console.WriteLine("There is addition, division, multiplication and subtraction.");

            while (!Enum.TryParse<Disciplines>(Console.ReadLine().ToLower(), out discipline))
            {
                Console.WriteLine("That is not a Discipline");
            }
            return discipline;
        }

        public string DisciplineOperation()
        {
            switch (discipline)
            {
                case Disciplines.addition:
                    Operation = "+";
                    break;
                case Disciplines.division:
                    Operation = "/";
                    break;

                case Disciplines.multiplication:
                    Operation = "*";
                    break;
                case Disciplines.subtraction:
                    Operation = "-";
                    break;
            }

            return Operation;
        }

        public Disciplines discipline;
    }
}
