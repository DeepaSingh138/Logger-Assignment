using Microsoft.VisualBasic;
using Practiceself.Mainloger;

namespace Practiceself {
    public class Program {
        public static void Main(string[] args)
        {
            Interfaceloger mylog = getlog();
            Logmanager manager = new Logmanager(mylog);
            manager.WriteLog("Done Sucessfully");
        }

              static Interfaceloger getlog()
            {
                string Log = "File";
                if (Log == "File")
                {
                    return new Filelog();
                }
                else if (Log == "Azure")
                { return new Azurecloud(); }
      
                {
                    return new Databaselog();
                }

            }


             }
        
    }



       

    
  
