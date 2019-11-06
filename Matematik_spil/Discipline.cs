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

        public string Operation;
        public Disciplines PrintDiscipline()
        {
            Console.WriteLine("what kind of discipline would you like?\n");
            Console.WriteLine("There is addition, division, multiplication and subtraction.");

            while (!Enum.TryParse<Disciplines>(Console.ReadLine(), out discipline))
            {
                Console.WriteLine("That is not a Discipline");
            }
            return discipline;
        }

        public string DisciplineOperation()
        {
            switch (discipline)
            {
                case Disciplines.Addition:
                    Operation = "+";
                    break;
                case Disciplines.Division:
                    Operation = "/";
                    break;

                case Disciplines.Multiplication:
                    Operation = "*";
                    break;
                case Disciplines.Subtraction:
                    Operation = "-";
                    break;
            }

            return Operation;
        }

        public Disciplines discipline;
    }
}
