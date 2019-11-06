using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_spil
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Instance.Initialize();
            Game.Instance.GameLoop();

        }
        
    }
}
