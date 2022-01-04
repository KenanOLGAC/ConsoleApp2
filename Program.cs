using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety güvenliği (yazı güvenligi
            //do not repeat yourself - kendini tekrar etme
            //burada kategoriEtiketi bir değer atadık( consol.writeline)komutu ilede geğeri başka bir sayfaya çağıra biliriz bu şekilde her sayfaya ayrı ayrı yazmamış oluruz ve değiştirmek istediğmizde tek bir yerden değiştiririz ve işlem tamamlanır.
            //c dilindeki gibi ; ile biten komutu sonlandırmalıyız
            string kategoriEtiketi = "kategori";
            int ogrenciSayısı = 320000;
            double faizOranı = 1.45;

            
            //şart komutları bool ile
            bool sistemegirişyapmışMı = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.35;
            

            if (dolarBugun < dolarDun)
            {
                Console.WriteLine("AzalışOku");
            }
            else if(dolarBugun>dolarDun)
            {
                Console.WriteLine("ArtışOku");
            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }
            // yukarıdaki true(durumu bir veri kaynagından gelir)
            //evet ise
            // iki durum var if'ten sonra (şart geçerli ise) alttaki bolokta (süslü parantez)
            //komutunu islet hılı (if(true) {}) oluşumu için if yaz 2 kere taba bas.
            //burada satece simule ediliyor butonu oluşturma işlemi 
            //html de yapılıyor oda <button>kullanıcı ayarlar (bu kısımda butunun üzerinde ne yazmasını istiyorsak onu giriyoruz.)</button> ile bur buton oluşturulur

            if (sistemegirişyapmışMı == true)
            {
                Console.WriteLine("kullanıcı ayarlar butonu");  
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayısı);
            Console.WriteLine(faizOranı);
        }
    }
}
