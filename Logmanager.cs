using Practiceself.Mainloger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceself
{
    public class Logmanager 
    {
        Interfaceloger mylog = null;
        public Logmanager( Interfaceloger log) {
            mylog = log;
        }
        public bool WriteLog(string message)
        {
           return  mylog.WriteLog(message);
        }
    }
}
