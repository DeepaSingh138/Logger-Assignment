using Practiceself.Mainloger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceself
{
    public class Filelog : Interfaceloger
    {
        public Filelog() {
            Console.WriteLine("log is in file ");
        }
        public bool WriteLog(string message)
        {
            Console.WriteLine(" Log is done in file sucessfully "+ message);
            return true;
        }
    }
}
