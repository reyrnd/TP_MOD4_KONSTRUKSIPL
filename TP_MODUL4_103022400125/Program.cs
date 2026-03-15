// See https://aka.ms/new-console-template for more information
public class KodePos
{
    public (string[] kelurahan, string[] kodePos) getKodePos()
    {
        string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", 
            "Margasari", "Sekejati", "Kebonwaru", "Maleer" };

        string[] kodepos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", 
            "40272", "40274" };

        return (kelurahan, kodepos);
    }
}

public class DoorMachine
{
    enum State
    {
        Terkunci,
        Terbuka
    }

    private State stateSaatIni = State.Terkunci;

    public DoorMachine()
    {
        Console.WriteLine("Pintu terkunci"); 
    }

    public void BukaPintu()
    {
        if (stateSaatIni == State.Terkunci)
        {
            stateSaatIni = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka, tidak bisa buka lagi");
        }
    }

    public void KunciPintu()
    {
        if (stateSaatIni == State.Terbuka)
        {
            stateSaatIni = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci, tidak bisa kunci lagi");
        }
    }
}

public class Program
{
    public static void Main()
    {

        KodePos kode = new KodePos();

        var (kelurahan, kodepos) = kode.getKodePos();

        Console.WriteLine("=== Daftar Kode Pos ===");

        for (int i = 0; i < kelurahan.Length; i++)
        {
            Console.WriteLine("Kelurahan " + kelurahan[i] + " : " + kodepos[i]);
        }

        Console.WriteLine("Simulasi DoorMachine");
        Console.WriteLine();

        DoorMachine pintu = new DoorMachine(); 

        Console.WriteLine("Aksi: BukaPintu");
        pintu.BukaPintu(); 

        Console.WriteLine("Aksi: KunciPintu");
        pintu.KunciPintu(); 

        Console.WriteLine("Aksi: BukaPintu lagi");
        pintu.BukaPintu(); 

        Console.WriteLine("Aksi: BukaPintu lagi (state sudah Terbuka)");
        pintu.BukaPintu();
    }
}
