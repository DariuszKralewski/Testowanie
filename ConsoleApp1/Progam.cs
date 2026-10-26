using ConsoleApp1.Atrapy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    public class Progam
    {
        public static int Main(string[] args)
        {
            var service = new VideoService(); // utworzenie instancji VideoService
            var title = service.ReadVideoTitle(); // wywołanie metody ReadVideoTitle z użyciem FileReader
            return 0;
        }
    }
}
