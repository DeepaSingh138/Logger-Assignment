using Practiceself.Mainloger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceself
{
    internal class Azurecloud : Interfaceloger
    {
        public Azurecloud()
        {
            Console.WriteLine("Logging in Azure.");

        }
        public bool WriteLog(string message)
        {
            Console.WriteLine(" Log Done in Azure sucessfully "+message);
            return true;
        }
    }
}
