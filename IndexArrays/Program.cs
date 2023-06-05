using IndexingArrays;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Выберите нижний порог итератора:");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Выберите верхний порог итератора:");
        int max = int.Parse(Console.ReadLine());
        Random random = new Random();
        IndexArrays<int> arr = new IndexArrays<int>(min, max);
        for (int i = arr.GetMin(); i < arr.Length(); ++i)
        {
            arr[i] = random.Next(100);
            Console.WriteLine(arr[i]);
        }
    }
}