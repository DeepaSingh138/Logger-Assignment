using Practiceself.Mainloger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceself
{
    public class Databaselog : Interfaceloger
    {
        public Databaselog()
        {
            Console.WriteLine("Logging in database");
        }
        public bool WriteLog(string message)
        {
            Console.WriteLine(" Log is done in databse sucessfully  "+message);
            return true;
        }
    }
}
