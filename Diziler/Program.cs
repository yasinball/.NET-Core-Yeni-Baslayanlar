// Dizilerin Tanımı

string[] renkler=new string[5];
renkler[3]="kırmızı";
System.Console.WriteLine(renkler[3]);

string[] hayvanlar={"kedi","köpek","sinek"};
System.Console.WriteLine(hayvanlar[0]);

int[] dizi;
dizi=new int[5];



// Dizilere değer atama ve erişim
renkler[0]="Mavi";
System.Console.WriteLine(hayvanlar[0]);
dizi[3]=10;
System.Console.WriteLine(dizi[3]);


// Döngülerle dizi tanımı
//Klavyeden girilen n tane sayının ortalamasını alan program
//Klavyeden Girilen n tane sayının ortalamasını hesaplayan program
System.Console.Write("Lütfen dizinin eleman sayısını giriniz:  ");
int diziUzunlugu=int.Parse(Console.ReadLine());
int[] sayıDizisi=new int[diziUzunlugu];


for (int i = 0; i < diziUzunlugu; i++)
{
    System.Console.WriteLine("Lütfen {0}. Sayıyı giriniz:",i+1);
    sayıDizisi[i]=int.Parse(Console.ReadLine());

}
int toplam=0;

foreach (var sayi in sayıDizisi)

 toplam+=sayi;

 System.Console.WriteLine("Ortalama:"+toplam/diziUzunlugu);   

Console.ReadKey();