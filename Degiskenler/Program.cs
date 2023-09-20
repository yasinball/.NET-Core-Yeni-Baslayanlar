// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
 
byte b= 5; // (0-255 arasındaki degerleri alır ) 1 byte
sbyte c=5; // (-128 ile 127 arasındaki degerleri) 1 byte

short s =5; //  (-32768 ile + 32768 tam sayı değerleri alır )2 byte
ushort us=5; //(0 ile 365 arasında ki değerleri alabilir ) 2 byte

Int16 i16=2; // 2 byte 
int i=2; // 4 byte yer kaplar (en fazla kullanıla bilen )
Int32 i32=2; // 4 byte yer kaplar
Int64 i64=2; // 8 byte yer kaplar

uint u2=2; // 4 byte
long l=4; //8 byte yer kaplar
ulong ul=4; // 8 byte

// Real SAYILAR
float f=5; //real ve tam sayı değer alir 4 byte
double d=5; //real sayı tutar 8byte
decimal de=5; //16 byte yer kaplar

Char Ch='2';  // 2 byte yer kaplar
string str ="Zikriye"; // sınırsız byte kadar gider.

bool b1=true;
bool b2=false;

DateTime dt=DateTime.Now;

System.Console.WriteLine(dt);

//Object tüm değerleri alır
object o1="x";
object o2='s';
object o3= 4.3;
object o4=4;

//string ifadeler

string str1=string.Empty;
str1="Zikriye Ürkmez";
string ad="Zikriye";
string soyad="Ürkmez";
string tamIsım=ad+" "+soyad;


//Integer tanımlama şekilleri

int integer1=5;
int integer2=3;
int integer3=integer1+integer2;

//Boolen
bool bool1=10<2;

//Degisken Dönüşümleri

String srt20="20";
int int20 =20;

string yeniDeger=srt20+int20.ToString();
System.Console.WriteLine(yeniDeger);//Çıktısı 2020

int int21=int20+Convert.ToInt32(srt20);
System.Console.WriteLine(int21);//Çıktısını 40

int int22=int20+int.Parse(srt20); //Çıktısı 40


//DateTime

string datetime=DateTime.Now.ToString("dd/MM/yyyy");
System.Console.WriteLine(datetime);

string datetime2=DateTime.Now.ToString("HH:mm");
System.Console.WriteLine(datetime2);

System.Console.WriteLine("Bitis");


















Console.ReadKey();
