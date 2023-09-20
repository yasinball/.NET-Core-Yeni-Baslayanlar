
try
{
System.Console.WriteLine("Bir sayı giriniz");
int say1=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Girmiş Oldunuğuz Sayı :"+say1);
}
catch (Exception ex)
{
    
   System.Console.WriteLine("Hata:"+ex.Message.ToString());
}
//
//finally
//{
//    System.Console.WriteLine("İşlem Tamamlandı");
//}


try
{
    int a=int.Parse("20000000000");

}
catch (ArgumentNullException ex)
{
    
    System.Console.WriteLine("Boş Değer Girdiniz");
    System.Console.WriteLine(ex);
}
catch(FormatException ex)
{
    System.Console.WriteLine("Veri Tipi Uygun Değil");
    System.Console.WriteLine(ex);
}
catch(OverflowException ex)
{
    System.Console.WriteLine("Çok küçük yada çok büyük veri girdiniz");
    System.Console.WriteLine(ex);
}












System.Console.ReadKey();