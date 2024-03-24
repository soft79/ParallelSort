using Sort;
using System.Security.Cryptography;

Console.WriteLine("Hello, Array.Sort 2D!");
Console.WriteLine();

CArray Arr = new CArray(10, 10);

for (int i = 0; i < Arr.ColLength; ++i)
    Console.Write(string.Format("Col {0}\t", i + 1));
Console.WriteLine();
for (int i = 0; i < Arr.ColLength; ++i)
    Console.Write(string.Format("-------\t"));
Console.WriteLine();

// Fill in each cell with its row position value
for (int j = 0; j < Arr.RowLength; ++j)
{
    for (int i = 0; i < Arr.ColLength; ++i)
    {
        Arr[i][j] = new CVariant(RandomNumberGenerator.GetInt32(0, 9), j);
        Console.Write(string.Format("({0},{1})={2}\t", j, i, Arr[i][j]));
    }
    Console.WriteLine();
}
Console.WriteLine();

string? str;
int iColumn;
bool b;
do
{
    Console.Write(string.Format("Sort on column ({0}-{1}): ", 1, Arr.ColLength));
    str = Console.ReadLine();
    b = Int32.TryParse(str, out iColumn);
    if (b)
        b = iColumn > 0 && iColumn <= Arr.ColLength;
} while (!b);

Console.WriteLine();
Console.WriteLine(string.Format("Sorting on Column {0}", iColumn));

// Sort
Arr.ParallelSort(iColumn - 1);

Console.WriteLine();

for (int i = 0; i < Arr.ColLength; ++i)
    Console.Write(string.Format("Col {0}\t", i + 1));
Console.WriteLine();
for (int i = 0; i < Arr.ColLength; ++i)
    Console.Write(string.Format("-------\t"));
Console.WriteLine();

for (int j = 0; j < Arr.RowLength; ++j)
{
    for (int i = 0; i < Arr.ColLength; ++i)
        Console.Write(string.Format("({0},{1})={2}\t", j, i, Arr[i][j]));
    Console.WriteLine();
}

Console.WriteLine();
