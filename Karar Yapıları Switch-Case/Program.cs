// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");


int mount= DateTime.Now.Month;

switch (mount)//Expression koşul
{
    case 1:
    System.Console.WriteLine("Ocak Ayındasınız");
    break;
    case 2 :System.Console.WriteLine("Şubat Ayyındasınız");
    break;
    case 3:System.Console.WriteLine("Mart Ayındasınız");
    break;
    case 9:System.Console.WriteLine("Eylül Ayındasınız");
    break;
    
    default:System.Console.WriteLine("Yanlış bir giriş yaptınız");
    break;

}

switch (mount)
{
    case 12:
    case 1:
    case 2:
    System.Console.WriteLine("Kış ayındasınız");
    break;

    case 3:
    case 4:
    case 5:
    System.Console.WriteLine("İlk bahar ayındasınız");
    break;

    case 6:
    case 7:
    case 8:
    System.Console.WriteLine("Yaz ayındasınız");
    break;

    default:
    System.Console.WriteLine("Hatalı bir giris yaptınız");
    break;
   
}

