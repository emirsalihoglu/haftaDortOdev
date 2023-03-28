namespace haftaDortOdev
{
    class Mevduat
    {
        string MusteriTC;
        string MusteriAdSoyad;
        double Bakiye;
        double EkHesap;

        void paraYatir(int yatirilan) 
        {
            Bakiye += yatirilan;
        }

        void ekHesapArttir(int artiMiktar) 
        {
            EkHesap += artiMiktar;
        }

        void paraCek(int cekilenTutar)
        {
            if (Bakiye >= cekilenTutar)
            {
                Bakiye -= cekilenTutar;
            }
            else if (Bakiye + EkHesap >= cekilenTutar)
            {
                EkHesap = EkHesap - (cekilenTutar - Bakiye);
                Bakiye = 0;
            }
            else
            {
                Console.WriteLine("Bakiyeniz ve ek hesabınızdaki toplam tutar çekilmek istenen tutardan küçük olduğu için işlem gerçekleşmedi.");
            }

        }

        void hesapYazdir() 
        {
            Console.WriteLine(MusteriAdSoyad + "" + MusteriTC + "");
            Console.WriteLine("Bakiyeniz: " + Bakiye);
            Console.WriteLine("Ek Hesap Bakiyeniz: " + EkHesap);
        }

        public string Musteriİsim
        {
            get
            {
                return MusteriAdSoyad;
            }
            set { MusteriAdSoyad = value; }
        }
        public string MusteriKimlik
        {
            get
            {
                return MusteriTC;
            }
            set { MusteriTC = value; }
        }

        public double MusteriPara
        {
            get
            {
                return Bakiye;
            }
            set { Bakiye = value; }
        }

        public double MusteriEkPara
        {
            get
            {
                return EkHesap;
            }
            set { EkHesap = value; }
        }


        static void Main(string[] args)
        {
            Mevduat k1 = new Mevduat();
            k1.paraYatir(100);
            k1.ekHesapArttir(100);
            k1.paraCek(50);
            k1.hesapYazdir();
        }
    }
}