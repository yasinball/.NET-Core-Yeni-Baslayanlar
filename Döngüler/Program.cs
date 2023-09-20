
//Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
System.Console.WriteLine("Lütfen bir sayı giriniz");
int sayac= int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    if(i%2==1)
    {
        System.Console.WriteLine(i);
    }
}
    // 1 ie 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdıralım
    
    int tekToplam=0;
    int ciftToplam=0;

    for (int i = 1; i < 1000; i++)

    {
        if(i%2==1)
        {
            tekToplam+=i; //TekToplam= Tektoplam+i;

        }
        else
           ciftToplam+=i; //TekToplam= Tektoplam+i;
    }
      System.Console.WriteLine("Tek Toplam: "+ tekToplam);
      System.Console.WriteLine("Cift Toplam: "+ ciftToplam);


// break , continue


for (int i = 1; i < 10; i++)
{
    if(i==4)
     break;
     System.Console.WriteLine(i);
}

for (int i = 1; i < 10; i++)
{
    if(i==4)
     continue;
     System.Console.WriteLine(i);
}














System.Console.ReadKey();