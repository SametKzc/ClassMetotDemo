using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.Id = 1;    
        musteri1.Ad = "Mert";
        musteri1.Soyad = "Demir";   

        MusteriManager musteriManager  = new MusteriManager();
        musteriManager.MusteriEkle(musteri1);
        musteriManager.MusteriListele(musteri1);
        musteriManager.MusteriSil(musteri1);
       
    }
}