public class Penjumlahan
{

    public void JumlahTigaAngka<T>(T x, T y, T z)
    {
        dynamic hasil = x;
        dynamic hasil2 = y;
        dynamic hasil3 = z;
        dynamic hasil_akhir = hasil + hasil2 + hasil3;
        Console.WriteLine($"Hasil penjumlahan dari {x} + {y} + {z} = {hasil_akhir}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan jumlah = new Penjumlahan();
        jumlah.JumlahTigaAngka<long>(13, 02, 22);
    }
}