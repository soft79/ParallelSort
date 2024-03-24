namespace Sort
{
    public static class Global
    {
        static public Type g_bColType;
        static public bool g_bSortOrder;

        static Global()
        {
            g_bColType = typeof(Int32);
            g_bSortOrder = false;
        }
    }
}
