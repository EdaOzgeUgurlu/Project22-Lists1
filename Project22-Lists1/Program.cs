string[] davetliler = new string[8]; // dizi oluşturuyoruz.
Console.WriteLine("davetlilerin isimlerini yazınız");
for (int i = 0; i < davetliler.Length; i++)
{
    
    string davetli = Console.ReadLine();
    davetliler[i] = davetli; //kullanıcıdan alınan her davetliyi davetliler listesine atıyoruz.

}

foreach (string item in davetliler) //davetli isimlerini yazdıyoruz
{ 
    Console.WriteLine(item);
}