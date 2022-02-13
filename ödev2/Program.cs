using System;

namespace ödev2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Bir oyuncu oynuyacak ve kendi nick name ile giriş yapcak 
             * 2. Oyuncu bir noktaya hasar vermeye çalışıcak
             * 3. Noktanın uzaklığı random şekilde verilicek
             * 4. Bir silah seçiçek
             * 5. Silahın hangi mesafaden etkili oldupu oyun başı verilicek
             * 6. Oyuncunun doğru merafeye doğru silahı seçmesi halinde görev başarılı olacak
             * 7. Aksi taktirde görev başarısız sayılıcak
             */
            NickAdd();
            Yazdir();
            RandomNumber();
            int Number = GunSelect();
            WinnerSelect(Number);
        }

        static void NickAdd()
        {
            Player nick = new Player();
            Console.WriteLine("nick name yaz");
            nick.NickName = Console.ReadLine();
           
        }
        static void Yazdir()
        {
            ShortRange knf = new ShortRange();
            Console.WriteLine("1."+knf.Name+"   Max Range="+knf.MaxRange+"    Min Range="+knf.MinRange);
            MediumRange med = new MediumRange();
            Console.WriteLine("2."+med.Name + "   Max Range=" + med.MaxRange + "    Min Range=" + med.MinRange);
            LongRange Long = new LongRange();
            Console.WriteLine("3." + Long.Name + "   Max Range=" + Long.MaxRange + "    Min Range=" + Long.MinRange);
        }
        static void RandomNumber()
        {
            MapPoint number = new MapPoint();
            Console.WriteLine("Mesafe="+number.Range);
        }
        static int GunSelect()
        {
            Console.WriteLine("Seçmek istediğiniz silahın numarasını giriniz");
            int GunNumber =  Convert.ToInt32(Console.ReadLine());
            return GunNumber;
        }
        static void WinnerSelect(int Number)
        {
            switch (Number)
            {
                case 1:
                    MapPoint range = new MapPoint();
                    ShortRange knf = new ShortRange();
                    if (knf.MinRange<= range.Range && knf.MaxRange>=range.Range)
                    {
                        Console.WriteLine("winner");
                    }
                    else
                    {
                        Console.WriteLine("losser");
                    }
                    break;
                case 2:
                    MapPoint range1 = new MapPoint();

                    MediumRange med = new MediumRange();
                    if (med.MinRange <= range1.Range && med.MaxRange >= range1.Range)
                    {
                        Console.WriteLine("winner");
                    }
                    else
                    {
                        Console.WriteLine("losser");
                    }
                    break;
                case 3:
                    MapPoint range2 = new MapPoint();
                    LongRange Long = new LongRange();
                    if (Long.MinRange <= range2.Range && Long.MaxRange >= range2.Range)
                    {
                        Console.WriteLine("winner");
                    }
                    else
                    {
                        Console.WriteLine("losser");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
