using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface ICreditManager //oxunabilirliyi artirmaq ucun interfaceler I herfi ile yazilir
    {
        public void Calculate(); //burda calculate imzadir imzanin eyni oldugu ama icerisinin ferqli oldugu durumlarda biz basede olusturdugumuz class'i class olaraq deyil interface olaraq yaradiriq
        //{ 
        //bu o demekdirki egerki biri bu interface'i islederse o bu metoda malik olmaq mecburiyyetindedir bir nece metodda ola biler.
        //}
        public void Example();
    }
}
