public class SimpleDataBase
{
    private List<T> storedData = new List<T>();
    private List<DateTime> inputDates = new List<DateTime>();

    public SimpleDataBase() 
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void addNewData(T data) 
    {
        this.storedData.Add(data);
        imputDate.Add(DateTime.Now);
    }

    public void PrintAllData()
    {

    }
}
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