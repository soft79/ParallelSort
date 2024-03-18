namespace Sort
{
    public static class Global
    {
        static public bool g_bSortOrder;
        static public Type g_bColType;

        static Global()
        {
            g_bSortOrder = true; // ascending
            g_bColType = typeof(Int32);
        }
    }
}
