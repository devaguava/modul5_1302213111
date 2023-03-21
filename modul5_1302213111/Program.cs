// See https://aka.ms/new-console-template for more information

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T inputSatu, T inputDua, T inputTiga)
    {
        return ((dynamic)inputSatu + (dynamic)inputDua + (dynamic)inputTiga);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Penjumlahan penjumlahan= new Penjumlahan();
        Console.WriteLine(penjumlahan.JumlahTigaAngka<float>(13, 2, 21));
    }
}