using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDictionary Tipinde bir array oluşyuruyoruz. buna iki değer giriyoruz. Value ve Key olacak şekilde.
            MyDictionary<string, int> isimSehir = new MyDictionary<string, int>();
            isimSehir.Add("Hande", 34);
            isimSehir.Add("Mustafa", 06);
            isimSehir.Add("Nalan", 24);
            isimSehir.Add("Buse", 52);
            isimSehir.Add("Hakan", 01);
            isimSehir.Add("Muzaffer", 58);
            // Ekrana Oluşturduğumuz _arrayK ve _arrayV nin Length'ini yazdırıyoruz.
            Console.Write("Value: " + isimSehir.CountK + " Key: " + isimSehir.CountV);
            // CRK
            Console.ReadKey();
        }
    }
    class MyDictionary<V, K>
    {
        // ARRAYLERE HER CLASS,METOT VS DEN ULAŞILABİLSİN DİYE EN DIŞARDA TANIMLIYORUZ.
        V[] _arrayV;
        V[] _tempArrayV;
        K[] _arrayK;
        K[] _tempArrayK;
        public MyDictionary()
        {
            // STANDART CLASS METOT'UN DA ARRAY(HEAP) ATAMASI YAPIYORUZ.
            _arrayV = new V[0];
            _arrayK = new K[0];
        }
        public void Add(V itemV, K itemK)
        {
            // ARRAY SAYISI ARTTIĞINDA _ARRAYV VE _ARRAYK NIN HEAP NUMARASI BOŞTA KALIYOR 
            // ÖNCEKİ ARRAY NUMARASI KAYBOLMASIN DİYE OLUŞTURDUĞUMUZ YENİ ARRAY İLE O DEĞERİ TUTUYORUZ.
            _tempArrayV = _arrayV;
            _tempArrayK = _arrayK;
            // ARRAY'E ADD DEDİĞİMİZDE ARRAY LENGTH'İ BİR UZUYOR AMA HEAP DEĞERİ DEĞİŞTİĞİ İÇİN İÇİ BOŞ KALIYOR.
            _arrayV = new V[_arrayV.Length + 1];
            _arrayK = new K[_arrayK.Length + 1];
            // FOR İLE İ DEĞİŞKENİNE EŞDEĞER ARRAY LENGTH'İ _ARRAYV VE _ARRAYK YA TEKRAR ATIYORUZ
            // BU ŞEKİLDE ÖNCEKİ ARRAY İÇERİSİNDEKİ DEĞERLER SAYI ARTTIĞINDA BOŞ OLAN ARRAY'İN İÇİNE YERLEŞİYOR.
            for (int i = 0; i < _tempArrayV.Length; i++)
            {
                _arrayV[i] = _tempArrayV[i];
            }
            for (int i = 0; i < _tempArrayK.Length; i++)
            {
                _arrayK[i] = _tempArrayK[i];
            }
            // İtem'ların eklenmesi gereken yeri ayarlıyoruz
            _arrayV[_arrayV.Length - 1] = itemV;
            _arrayK[_arrayK.Length - 1] = itemK;
        }
        // GET İLE _ARRAYV NİN LENGTH(KAÇ ELEMANI) OLDUĞUNU GERİ RETURN EDİYORUZ 
        // VE COUNT SORGULADIĞIMIZDA O ARRAY'İN ELAMANINI YAZDIRIYOR.
        public int CountV
        {
            get { return _arrayV.Length; }
        }
        public int CountK
        {
            get { return _arrayK.Length; }
        }
    }
}
