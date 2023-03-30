internal class Program
{
    private static void Main(string[] args)
    {
              Console.WriteLine("*************Birinci Ödev Çift Sayı***************");

        Console.Write("Kaç Adet Sayı girilecek? : ");
        int nsayi = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < nsayi; i++)
        {
            Console.Write("Sayı girin : ");
            int sayilar = Convert.ToInt32(Console.ReadLine());
            if(sayilar.IsEvenNumber()){
                Console.WriteLine(sayilar + " Sayısı Çifttir");
            }  
        }

              Console.WriteLine("*************İkinci Ödev Bölünebilme***************");
        
        Console.Write("Lütfen n sayısını giriniz: ");
         int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen m sayısını giriniz: ");
         int m = Convert.ToInt32(Console.ReadLine());

        

         int[] sayilar = new int[n];
         Console.WriteLine("Lütfen " + n + "adet pozitif sayı girin: ");


         for (int i = 0; i < n; i++)
         {
            Console.Write((i+1) + ". sayıyı girin: ");
            sayilar[i] = int.Parse(Console.ReadLine());
         }

         Console.WriteLine(m + " sayısına eşit yada tam bölünen sayılar: ");
         for (int i = 0; i < n; i++)
         {
            if (sayilar[i] % m == 0)
            {
                Console.WriteLine(sayilar[i]);
            }
         }


            Console.WriteLine("**************3. Ödev n adet kelime ters sıra ile yazdırma ");

        Console.Write("Lütfen Bir Sayı Giriniz: ");
        int n = Convert.ToInt32(Console.ReadLine());

        string[] kelimeler = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write((i+1) + ". kelimeyi giriniz: ");
            kelimeler[i] = Console.ReadLine();
        }

        Array.Reverse(kelimeler);

        foreach (var kelime in kelimeler)
        {
            Console.WriteLine(kelime);
        }

        Console.WriteLine("**************4. Ödev cümle yazdırma kelime ve harf sayısını yazma ");

        Console.Write("Lütfen Bir Cümle Giriniz: ");
        string cumle = Console.ReadLine();

    
        int kelimeSayisi = cumle.Split().Length;
        int harfSayisi = cumle.Length;

        Console.WriteLine("Kelime Sayısı: " + kelimeSayisi);
        Console.WriteLine("Harf Sayısı: " + harfSayisi);


    }
}

public static class Extension{
    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }

}