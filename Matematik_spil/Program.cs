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


            _isRunning = true;

            discipline.PrintDiscipline();
            question.DifficultySetting();
            question.WriteQuestion();
           

        }
        
    }
}
