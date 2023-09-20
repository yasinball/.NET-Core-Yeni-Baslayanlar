
int time=DateTime.Now.Hour;
if(time>=6 && time < 11)
{
    System.Console.WriteLine("Günaydın");
}
else if (time<=18)
{
    System.Console.WriteLine("İyi Günler");
}
else
{
    System.Console.WriteLine("İyi geceler");
}

string sonuc=time<=18 ? "İyi Günler" : "İyi geceler ";
System.Console.WriteLine(sonuc);


string sonucc= time >= 6 && time<11 ? "Günaydın" :time <=18 ? "İyi Günler" : "İyi geceler";
System.Console.WriteLine(sonucc);






































System.Console.ReadLine();