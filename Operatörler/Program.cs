// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Atama ve İşlemli Atama
int x=3;
int y=3;
y=y+2;
System.Console.WriteLine(y);

y+=2;
System.Console.WriteLine(y);

y/=1;
System.Console.WriteLine(y);

x*=2;
System.Console.WriteLine(x);

//Mantıksal Operatörler
// ||, &&, !


// && ve demek
// || veya 
// != Eşit Değilse
bool isSucces=true;
bool isCompleted=false;

if( isSucces && isCompleted){
    System.Console.WriteLine("Perfect");
}
if( isSucces || isCompleted){
    System.Console.WriteLine("Perfect");
}
if( isSucces != isCompleted){
    System.Console.WriteLine("Fine");
}

//İlişkisel Operatörler
//<,>,<=,>=,==,!=

int a =3;
int b=4;
bool sonuc=a>b;
System.Console.WriteLine(sonuc);
sonuc=a>b;
System.Console.WriteLine(sonuc);
sonuc=a>=b;
System.Console.WriteLine(sonuc);
sonuc=a<=b;
System.Console.WriteLine(sonuc);
sonuc=a==b;
System.Console.WriteLine(sonuc);
sonuc=a!=b;
System.Console.WriteLine(sonuc);



// Aritmatik Operatörler

// +,-,/,*

int sayı1=10;
int sayı2=5;

int sonuc1 =sayı1/sayı2;

System.Console.WriteLine(sonuc1);

sonuc1=sayı1*sayı2;
System.Console.WriteLine(sonuc1);


// % mod alır

int sonuc2=20%3;
System.Console.WriteLine(sonuc2);







































Console.ReadKey();
