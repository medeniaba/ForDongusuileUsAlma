int sayi;
int üs;
int toplam = 1; 
Console.WriteLine("Hesaplanacak sayıyı giriniz : ");
sayi = int.Parse(Console.ReadLine());
Console.WriteLine("Hesaplanacak üs degerini giriniz :");
üs = int.Parse(Console.ReadLine());

for ( int i = 1; i <= üs; i++)
{
     toplam *= sayi;  

}
Console.WriteLine(toplam);
Console.ReadKey();