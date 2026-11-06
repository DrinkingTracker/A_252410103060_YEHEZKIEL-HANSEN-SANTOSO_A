using System.Runtime.CompilerServices;

class Program
{
    static public void Main(String[] args)
    {
        // soal 1
        Sekolah sekolah1 = new Sekolah("0001", "NATO barracks", 100);
        Sekolah sekolah2 = new Sekolah("0002", "Mount Division", 200);

        sekolah1.TampilInfo();
        Console.WriteLine();
        sekolah2.TampilInfo();

        // soal 4
        

    }
}

class Sekolah
{
    // property
    public string idSekolah;
    public string namaSekolah;
    public int jumlahPaketDiterima;
        
    // struct
    public Sekolah(string idSekolah, string namaSekolah, int jumlahPaketDiterima)
    {
        this.idSekolah = idSekolah;
        this.namaSekolah = namaSekolah;
        this.jumlahPaketDiterima = jumlahPaketDiterima;
    }

    // method
    public void TampilInfo()
    {
        Console.WriteLine("Informasi Sekolah");
        Console.WriteLine($"ID = {idSekolah}");
        Console.WriteLine($"Nama = {namaSekolah}");
        Console.WriteLine($"Jumlah Paket = {jumlahPaketDiterima}");
    }
}

abstract class PaketMBG 
{
    // property
    private string idPaket { get; set; }
    private string namaPaket { get; set; }
    private int stokDapur 
    {
        get { return stokDapur; }
        set
        {
            if (stokDapur < 0)
            {
                Console.WriteLine("stok tidak boleh negatif!");

            }
        }
    }

    // struct
    public PaketMBG(string idPaket, string namaPaket, int stokDapur)
    {
        this.idPaket = idPaket;
        this.namaPaket = namaPaket;
        this.stokDapur = stokDapur;
    }

    // method
    public void KurangiStok(int jumlah)
    {
        if (stokDapur == 0)
        {
            Console.WriteLine("Stok Habis");
        } else if (jumlah < stokDapur)
        {
            Console.WriteLine("Stok yang ingin dikurangi melebihi stok yang tersedia");
        }
        else
        {
            stokDapur -= jumlah;
        }
    }

    //public virtual int HitungBiaya(int jumlah)
    //{
    //    return jumlah;
    //}

    public abstract int HitungBiaya(int jumlah);

    

}

class PaketReguler : PaketMBG
{
    // property
    public string nasi;
    public string ayam;
    public string sayur;
    public string buah;

    // struct
    public PaketReguler(string nasi, string ayam, string sayur, string buah, string idPaket, string namaPaket, int stokDapur) : base(idPaket, namaPaket, stokDapur)
    {
        this.nasi = nasi;
        this.ayam = ayam;
        this.sayur = sayur;
        this.buah = buah;
    }

    // method
    public override int HitungBiaya(int jumlah)
    {
        return jumlah * 15000;
    }
}

class PaketKhusus : PaketMBG
{
    // property
    public string nasi;
    public string ayam;
    public string sayur;
    public string buah;
    public string jenisDiet;

    // struct
    public PaketKhusus(string nasi, string ayam, string sayur, string buah, string jenisDiet, string idPaket, string namaPaket, int stokDapur) : base(idPaket, namaPaket, stokDapur)
    {
        this.nasi = nasi;
        this.ayam = ayam;
        this.sayur = sayur;
        this.buah = buah;
        this.jenisDiet = jenisDiet;
    }

    // method
    public override int HitungBiaya(int jumlah)
    {
        return jumlah * 20000;
    }
}

interface DapatDidistribusikan
{
    void KirimPaket();
}

class DistribusiMBG
{
    // property 
    public Sekolah tujuan;
    public PaketMBG paket;
    public int jumlah;

    // struct
    public DistribusiMBG(Sekolah tujuan, PaketMBG paket)
    {
        this.tujuan = new Sekolah(idSekolah, namaSekolah);
        this.paket = new PaketMBG(namaPaket);
        this.jumlah = jumlah;
    }

    public void KirimPaket(int jumlah)
    {
        if (jumlah < 0)
        {
            Console.WriteLine();
        }
    }
}






