# Davetliler Listesi Uygulaması

Bu proje, C# dilinde kullanıcıdan davetli isimlerini alarak bir diziye kaydetmeyi ve ardından bu isimleri ekrana yazdırmayı amaçlamaktadır. Aşağıda projenin detaylı açıklaması ve kullanım kılavuzu yer almaktadır.

## İçindekiler

1. [Proje Hakkında](#proje-hakkında)
2. [Kurulum](#kurulum)
3. [Kullanım](#kullanım)
4. [Kod Açıklamaları](#kod-açıklamaları)


## Proje Hakkında

Bu proje, kullanıcıdan toplamda 8 davetli ismi alır ve bu isimleri bir dizi içinde saklar. Daha sonra, dizideki davetli isimlerini ekrana yazdırır.

## Kurulum

1. C# geliştirme ortamını (Visual Studio veya .NET SDK) kurun.
2. Yeni bir C# konsol projesi oluşturun.
3. Aşağıdaki kodu `Program.cs` dosyasına yapıştırın.
4. Projeyi çalıştırmak için `F5` tuşuna basın veya `dotnet run` komutunu kullanın.

## Kullanım

1. Uygulama çalıştığında, kullanıcıdan sırasıyla 8 davetli ismi girmesi istenir.
2. Kullanıcıdan alınan isimler diziye kaydedilir.
3. Tüm davetli isimleri ekrana yazdırılır.

## Kod Açıklamaları

```csharp
using System;

class Program
{
    static void Main()
    {
        // 8 elemanlı bir string dizisi tanımlanıyor
        string[] davetliler = new string[8]; 

        // Kullanıcıdan davetli isimlerini al
        Console.WriteLine("Davetlilerin isimlerini yazınız");
        for (int i = 0; i < davetliler.Length; i++)
        {
            // Kullanıcıdan bir davetli ismi al
            string davetli = Console.ReadLine();
            // Alınan davetli ismini diziye kaydet
            davetliler[i] = davetli; 
        }

        // Davetli isimlerini ekrana yazdır
        Console.WriteLine("Davetli İsimleri:");
        foreach (string item in davetliler) 
        { 
            Console.WriteLine(item); // Her bir davetli ismini ekrana yazdır
        }
    }
}
```

### Açıklamalar

- **Dizi Tanımlama:** `string[] davetliler = new string[8];` ifadesi ile 8 elemanlı bir dizi tanımlanır.
- **Döngü ile İsim Alma:** `for` döngüsü kullanılarak kullanıcıdan isimler alınmakta ve bu isimler diziye kaydedilmektedir.
- **Yazdırma:** `foreach` döngüsü ile dizideki isimler ekrana yazdırılmaktadır.
