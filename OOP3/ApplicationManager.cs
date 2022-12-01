using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //method injection
        public void MakeAnApplication(List<ICreditManager> creditManagers /*ICreditManager creditManagerburda hamisininnreferansini tutan ninterface var*/, List<ILoggerService> loggerServices)
        {
            //basvuran melumatlarinin deyerlendirilmesi
            //    MortageCreditManager mortageCreditManager1 = new MortageCreditManager();
            //    mortageCreditManager1.Calculate();//bunu etsek butun basvurulari mortage kredite baglamis oluruq diqqet! bu edilmemelidir dogru deyil
            //bura artig istediyimiz kreditit yollaya bilerik 
            //creditManager.Calculate();
            //loggerServices.Log();
            #region MultiLogger
            foreach (var creditManager in creditManagers)
            {
                creditManager.Calculate();
            }
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            #endregion MultiLogger
        }
        public void MakeALoanPreInformation(List<ICreditManager> credits /*parametr verdik*/ )//kredit on melumatlandirma
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
