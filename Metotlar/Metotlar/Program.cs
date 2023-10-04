namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Erisim_belirteci geri_dönüstipi metotadi(parametrelistesi/arguman)
            //{
            //
            //
            //}


            int a = 2;
            int b = 3;

            Console.WriteLine( a+ b);

   
            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);

            Metotlar ornek =new Metotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2=ornek.ArttırvVeTopla( a, b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a+b));
        }

        static int Topla(int değer1, int deger2)
        {
            return (değer1 + deger2);
        }

        class Metotlar
        {
            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }

            public int ArttırvVeTopla(int deger1,int deger2)
            {
                
                deger1 += 1;
                deger2+= 1;
                return deger1 + deger2;

            }
        }
    }

}