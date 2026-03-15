// See https://aka.ms/new-console-template for more information
public class KodePos
{
    public (string[] kelurahan, string[] kodePos) getKodePos()
    {
        string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari", 
            "Margasari", "Sekejati", "Kebonwaru", "Maleer" };

        string[] kodepos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274" };

        return (kelurahan, kodepos);
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
    }
}
