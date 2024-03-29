using System.Security.Cryptography;

internal class Program
{
    private static void Print(object[,] Arr)
    {
        for (int i = 0; i < Arr.ColLength(); ++i)
            Console.Write(string.Format("Col {0}\t", i + 1));
        Console.WriteLine();
        for (int i = 0; i < Arr.ColLength(); ++i)
            Console.Write(string.Format("-------\t"));
        Console.WriteLine();

        for (int j = 0; j < Arr.RowLength(); ++j)
        {
            for (int i = 0; i < Arr.ColLength(); ++i)
                Console.Write(string.Format("{0}\t", Arr[j, i]));
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Array.Sort 2D!");
        Console.WriteLine();

        object[,] Arr = new object[10, 10];

    again:
        // Fill in each cell with its row position value
        for (int i = 0; i < Arr.ColLength(); ++i)
        {
            // Column contains random numbers
            for (int j = 0; j < Arr.RowLength(); ++j)
            {
                Arr[j, i] = GetRandomValue();
            }
        }

        Print(Arr);

        int iColumn;
        while (true)
        {
            Console.Write(string.Format("Sort on column ({0}-{1}): ", 1, Arr.ColLength()));
            var str = Console.ReadLine();
            if (int.TryParse(str, out iColumn) && iColumn > 0 && iColumn <= Arr.ColLength()) break;
        }

        bool descending;
        while (true)
        {
            Console.Write("Ascending or Descending (A/D): ");
            var strSort = Console.ReadLine();
            if (string.Compare(strSort, "A", true) == 0)
            {
                descending = false;
                break;
            }
            else if (string.Compare(strSort, "D", true) == 0)
            {
                descending = true;
                break;
            }
        }

        Console.WriteLine();
        Console.WriteLine(string.Format("Sorting on Column {0} {1}", iColumn, descending ? "Descending" : "Ascending"));

        // Sort
        Arr = Arr.Sort(iColumn - 1, descending);

        Console.WriteLine();

        Print(Arr);

        while (true)
        {
            Console.Write("Again (Y/N): ");
            var strAgain = Console.ReadLine();
            if (string.Compare(strAgain, "Y", true) == 0) goto again;
            if (string.Compare(strAgain, "N", true) == 0) break;
        }
        Console.WriteLine();
    }

    private static readonly string[] Words = {
        "Apple", "Orange", "Banana", "Onion", "Garlic", "Carrot", "Sun", "Moon", "Mercury",
        "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto"
    };

    private static object GetRandomValue() => RandomNumberGenerator.GetInt32(0, 5) switch
    {
        0 => RandomNumberGenerator.GetInt32(-50, 100),
        1 => Words[RandomNumberGenerator.GetInt32(0, Words.Length)],
        2 => RandomNumberGenerator.GetInt32(-500, 1000) / 10.0,
        3 => RandomNumberGenerator.GetInt32(2) == 0,
        _ => (byte)RandomNumberGenerator.GetInt32(0, 100),
    };
}
