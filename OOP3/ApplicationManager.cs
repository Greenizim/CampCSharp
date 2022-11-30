using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager/*burda hamisininnreferansini tutan ninterface var*/)
        {
            //basvuran melumatlarinin deyerlendirilmesi
            //    MortageCreditManager mortageCreditManager1 = new MortageCreditManager();
            //    mortageCreditManager1.Calculate();//bunu etsek butun basvurulari mortage kredite baglamis oluruq diqqet! bu edilmemelidir dogru deyil
            //bura artig istediyimiz kreditit yollaya bilerik 
            creditManager.Calculate(); 
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
