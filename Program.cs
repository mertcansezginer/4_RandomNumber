

using System.ComponentModel.Design;

Random rastgeleSayiUretici = new Random();  // random sinifindan bir nesne olusturduk
int rastgeleSayi = rastgeleSayiUretici.Next(1, 11); //1 dahil 11 haric, bu aralikta rastgele sayi uretir


Console.WriteLine(" 1 ile 10 arasinda bir sayi tahmin edin. ");

while (true)   // sonsuz dongu, dogru tahmin yapilana kadar dongu devam eder
{
    Console.WriteLine("Tahmininizi giriniz : ");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    if (tahmin == rastgeleSayi)
    {
        Console.WriteLine("Tebrikler! Sayiyi dogru tahmin ettin.");
        break;
    }

    else
    {
        Console.WriteLine("Yanlis tahmin, tekrar dene");
    }

}
    
 