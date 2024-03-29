public static class Util
{
    public static int RowLength<T>(this T[,] arr) => arr.GetLength(0);
    public static int ColLength<T>(this T[,] arr) => arr.GetLength(1);

    public static T[,] Sort<T>(this T[,] arr, int column, bool descending = false) where T : notnull
    {
        var comparer = new VariantComparer();

        var indices = Enumerable
            .Range(0, arr.RowLength())
            .OrderBy(i => arr[i, column], comparer)
            .ToArray();

        if (descending) indices = indices.Reverse().ToArray();

        var sorted = new T[arr.RowLength(), arr.ColLength()];
        for (int r = 0; r < arr.RowLength(); r++)
            for (int c = 0; c < arr.ColLength(); c++)
                sorted[r, c] = arr[indices[r], c];

        return sorted;
    }

    public static bool IsNumericType(object o)
    => Type.GetTypeCode(o.GetType()) is
        TypeCode.Byte or
        TypeCode.SByte or
        TypeCode.UInt16 or
        TypeCode.UInt32 or
        TypeCode.UInt64 or
        TypeCode.Int16 or
        TypeCode.Int32 or
        TypeCode.Int64 or
        TypeCode.Decimal or
        TypeCode.Double or
        TypeCode.Single;
}
