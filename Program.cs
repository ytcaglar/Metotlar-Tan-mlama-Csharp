using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erişim_Belirteci Geri_Dönüş_Tipi metot_adı(değişkenler)
            //{
            //      metotlar_Buraya
            //}

            int a = 5; 
            int b = 3;

            Console.WriteLine(a+b);

            int sonuc = Topla(a,b);
            System.Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();

            ornek.PrintMetot(sonuc.ToString(),a,b);
            
            int sonuc2 = ornek.ArttırveTopla(a,b);
            ornek.PrintMetot(sonuc2.ToString(),a,b);

            int sonuc3 = ornek.RefileArttırveTopla(ref a, ref b);
            ornek.PrintMetot(sonuc3.ToString(),a,b);

            ornek.PrintMetot((a+b).ToString(),a,b);

        }

        public static int Topla(int a, int b){
            return a + b ;
        }
    }

    class Metotlar
    {
        public void PrintMetot(string veri, int a , int b)
        {
            System.Console.WriteLine("a: {1} b: {2} İşlemin sonucu: {0}", veri,a,b);
        }

        public int ArttırveTopla(int deger1, int deger2) // metot içinde yapılan değişiklerin referansları ile
                                                         // gönderilmediğinden a ve b nin esas değerleri üzerinde
                                                         // değişiklik yapılmaz. Birnevi onların kopyası üzerinde 
                                                         // yapılır. Bundan dolayı değişikler onları bağlamaz.
        {
            deger1++;
            deger2++;
            return deger1+deger2;
        }

        public int RefileArttırveTopla(ref int deger1, ref int deger2) // Bu metotta gönderilen değişkenler referansları ile
                                                                       // gönderildiğinden a ve b nin esas değerleri üzerinde
                                                                       // değişiklik yapılmış olur. Bu nedenle adresteki veri 
                                                                       // üzerinde değişiklik olmuş olur.
        {
            deger1++;
            deger2++;
            return deger1+deger2;
        }
    }
}

