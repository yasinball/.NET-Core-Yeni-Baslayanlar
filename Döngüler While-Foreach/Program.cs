
//While 
//1 den baslayarak consoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp konsola yazdıran program
System.Console.WriteLine("Lütfen Bir Sayı Giriniz");
int kullanıcı=int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac <= kullanıcı)
{
    toplam+= sayac;
    sayac ++;
    System.Console.WriteLine(toplam/kullanıcı);
}

// a dan z ye kadar tüm harfleri konsola yazdıralım

char character='a';

while (character<='z')
{
    System.Console.Write(character);
    character ++;
}


System.Console.WriteLine("*******FOREACH********");
string[] arabalar={"BMW","FORD","TOYATA","NİSSAN"};
foreach (var araba in arabalar)
{
     System.Console.WriteLine(araba);
}

















System.Console.ReadKey();