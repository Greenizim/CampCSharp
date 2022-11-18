using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack And Heap
            //int,decimal,float,enum,boolean.. bunlar value types dir

            int number1 = 10;
            int number2 = 20;

            number1 = number2;

            number2 = 1000;

            Console.WriteLine("Number 1 : " +number1);
            /* int vale type oldugu ucun ve value typlar memoryde ancaq stack'da saxlandigi ucun
             *biz number1 e number 2yi menimsetdikden sonra number 2 yi 1000 etsekde bize donen deyer 
             *20 olacaq cunkii burda eslinde number 1 number 2 ye yox onun deyerine yeni 20 ye beraber olur
             *daha sonra edilen deyisiklikerin value type oldugu ucun buna bir aidiyyati yoxdur!
             *burda menimsedilen sadece deyerdir!
             */

            //arrays,class, interface....... bunlar reference typesdir 
            int[] numbers1 = new int[] {2,5,9,6};
            int[] numbers2 = new int[] {25,56,79,36};

            numbers1 = numbers2;
            numbers2[2] = 79070;

            Console.WriteLine("Numbers1[2] : " + numbers1[2]);
            /*arraylerin referans tip oldugunu demisdik burda int yazilmagina abxma bu arraydir 
             *referans tipler memoryde hem stack hemde heapde saxlanilir 
             *biz burda numbers1 in heapdeki adresini numbers2 nin heapdeki adresine beraber edirik bu sebeble
             *numbers1 in 2 ci indexi eslinde numbers2 nin heapdeki ikinci indeksine beraber olmus olur
             *ve number 1 in heapdeki adresi bir muddet sonra visual studiodaki garbage collector (zibil yigan ) terefinden
             * memoryden hecbir referans tip terefinden tutulmadigi ucun silinir
             */
            #endregion Stack And Heap

            #region Inheritance & Base Class
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ali";
            person2 = person1;
            /* burda reference tip oldugu ucun tamamiyle referans nomresi uzerinden gedir
             * ver belelikle person2 yi yazdirdigimizda o gedip person1 in referans nomresinden yazir
             */ 
            person1.FirstName = "Mike";
            Console.WriteLine("Person2 Firstname : " + person2.FirstName);
            //biz burda referans tiplerde deyer beraberlesdirmesi yox
            //adres referans nomresi beraeberlesdirmesi edirik
            
            Customer customer1 = new Customer();
            customer1.FirstName = "Green";
            Employee employee1 = new Employee();
            employee1.FirstName = "George";

            /*customer1 = employee1;
             * biz burda customere employee'yi teyin ede bilmerik cunki ikiside ferqli tipdir
             * ama person base class oldugu ucun persona customeri teyin ede bilirik
             * cunki customer ve employee eyni zamanda person dur
             * miras aldigimiz sinife mirasi alan sinifi yeni clasi teyin ede bilerik cunki base class temel sinifdir ana sinifdir
             */

            Person person = customer1;
            #endregion Inheritance & Base Class

            #region Boxing
            Console.WriteLine(person.FirstName);
            customer1.CreditCardNumber = "44557874115";
            /* indi burda bir sual yaranirki biz niye customerdan gedende kredit kartini goruruk 
             * ama persondan gedende gormuruk
             * cunki biz person sablonu uzerinden gedirik
             * bunun ucun boxing etmeliyik
             */

            Console.WriteLine(((Customer)person).CreditCardNumber);
            //biz burda person'a customera boxing (qutulama) eledik!

            #endregion Boxing

            #region Base Parameter
            //burda bir sual daha yarana bilerki biz niye customer uzerinden yox person uzerinden gedirik

            PersonManager personManager = new PersonManager();
            personManager.Add(employee1);
            /*bura hem person hem customer hemde employee vermemize imkan yaradir 
            *bize eyni kodu ferli obyekler uzerinde isletmeye imkan verir
            */
            #endregion Base Parameter

        }

        #region Inheritance & Base Class
        //burda base class mother class yeni temel class persondur
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }
        // biz burda deyirikki Customer eyni zamanda persondur ve empoyee ise eyni zamanda persondur buna Inheritance miras deyilir

        #endregion Inheritance

        #region Base Parameter Manager
        class PersonManager
        {
            //biz tutaqki istediyimiz an customerla, istediyimiz an employee ile islemek isteyirikse
            public void Add(/*Customer customer biz bura bele customer veya employee elesek ancaq customer veya employee ile islemis oluruq
                             ammma biz bura base class olan personu yazsaq her ucune data elave edilmis her ucuyle islmis oluruq*/ Person person
                           )
            {
                Console.WriteLine(person.FirstName);

                //ornek yuxarida
            }
        }
        #endregion BAse Parameter Manager
    }
}
