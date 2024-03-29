using System.Collections;

public class VariantComparer : IComparer<object>
{
    public int Compare(object? a, object? b)
    {
        if (a == b) return 0;
        if (a == null) return -1;
        if (b == null) return 1;
        if (a.GetType() == b.GetType()) return Comparer.Default.Compare(a, b);

        if (a is string stringA) return stringA.CompareTo(b.ToString());
        if (b is string stringB) return -stringB.CompareTo(a.ToString());

        if (a is double doubleA && Util.IsNumericType(b)) return doubleA.CompareTo(Convert.ToDouble(b));
        if (b is double doubleB && Util.IsNumericType(a)) return -doubleB.CompareTo(Convert.ToDouble(a));

        if (a is float floatA && Util.IsNumericType(b)) return floatA.CompareTo(Convert.ToDouble(b));
        if (b is float floatB && Util.IsNumericType(a)) return -floatB.CompareTo(Convert.ToDouble(a));

        return a.ToString().CompareTo(b.ToString());
    }
}
