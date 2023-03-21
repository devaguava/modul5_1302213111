// See https://aka.ms/new-console-template for more information

public class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();

        Console.WriteLine("Masukkan 3 angka : ");

        for (int input = 3; input > 0; input--)
        {
            double i = Convert.ToDouble(Console.ReadLine());
            data.AddNewData(i);
        }
        data.PrintAllData();
    }
}
public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for(int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data "+i+" berisi: " + storedData[i]+" yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
   
}


