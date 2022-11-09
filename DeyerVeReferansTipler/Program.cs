using System;
using System.Linq;

namespace DeyerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ref-Out Keywords & Parameters
            Add();
            Add2(20,30);
            /*nece parametr varsa oqeder deyer yazmaliyiq
              burda number1 ve number 2 ye deyer menimsedir ama biz bunu consoleda gormeyeceyik
              consoleda gormek ucun deyisene deyer menimsedib yazdirmaliyiq*/
            var result = Add2(20,30);
            var result2 = Add2(20);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            int number1 = 50; // outda deyisene burda deyer menimsetmesekde olar ama refde olmaz
            int number2 = 100;
            var result3 = Add3(ref number1 /*number1*/
                //bunu normalda referanssiz refsiz yazsaydiq
                //iki deyisen yaranacaqdi number1 adinda
                //ama biz her iki terefde ref oldugunu gosterdik
                //belece busefer number1 i yazdirsaq 50 yox 30 oldugunu
                //burdaki deyerinde deyisdiyini goreceyik
                , number2);
            var result4 = Add4(out number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);
            Console.WriteLine(result4);       

            #endregion

            #region Method Overloading
            Console.WriteLine(Multiply(3,5));
            Console.WriteLine(Multiply(3,5,12));
            #endregion Method Overloading

            #region Param Keyword
            Console.WriteLine(Add5(5,7,3,2,1,4,5,6,9));
            #endregion Param Keyword

            Console.ReadLine();
        }
        #region Fixed Parameters
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        #endregion

        #region Parameters
        static /*void*/ int Add2(int number1, int number2 =50 /*c# 'a gelen yenilikle 4+ versiyua olan c# larda metodlarda default parametrlerle
                                                               * islemek olur yeni number 2 ye deyer verilmese default olaraq 50 ile isleyecek*/  ) 
        /*voidle return ede bilmerik cunki void icra et islem ele demekdi
        buna gore netice hansi tipde donsun isteyirikse o tipi yaziriq*/
        {
            return number1 + number2;
        }
        #endregion Parameters

        #region Ref Keyword
        static /*void*/ int Add3(ref int number1 /*number1*/, int number2 = 50 /*c# 'a gelen yenilikle 4+ versiyua olan c# larda metodlarda default parametrlerle
                                                               * islemek olur yeni number 2 ye deyer verilmese default olaraq 50 ile isleyecek*/  )
        /*voidle return ede bilmerik cunki void icra et islem ele demekdi
        buna gore netice hansi tipde donsun isteyirikse o tipi yaziriq*/
        {
            number1 = 30;
            return number1 + number2;
        }
        #endregion Ref Keyword

        #region Out Keyword
        static int Add4(out int number1, int number2)
        {
            number1 = 50; //outda mutleq iceride deyisene deyer menimsetmeliyik
            return number1 + number2;
        }
        #endregion Out Keyword

        #region Method Overloading
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2, int num3)
        {
            //burda tutalimki ucuncu bir ededide vurmaq lazimdirsa 
            //ozaman normalda metodun adini deyisib Multiply2 ederdik
            //ama Merhod overloading bize eyni adla ferqli parametrler
            //vermeye imkan yaradir
            return num1 * num2;
        }
        #endregion

        #region Param Keyword
        //tutalimki bir nece ededi toplamaliyiq 3-4-5-10-15
        //burda bunlari method overloading ile yazabilerik ama birmuddet sonra
        //method overloading elverissiz olmaga baslayacaq bu zaman
        //bizim komeyimize params Keyword gelir param ile dirextory kataloq list mentiqi ile
        //tek metodla birnece deyer uzerinden emeliyyat icra ede bilirik

        static int Add5(int number, /*bu zaman 5 deyeri number'e
         menimsedilecek ama hecbir emeliyyyat icra olunmayacaq*/ params int[] numbers)
        {
            return numbers.Sum();
            //eyni zamanda paramsa diger deyisenlerde menimsetmek mumkundur
            //paramsin sonuna deyisen qoymamaq serti ile!
        }
        #endregion Param Keyword

        #region Arrays

        #endregion Arrays
    }
}
