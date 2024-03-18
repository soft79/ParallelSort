using System.Text;

namespace Sort
{
    public class CValue : IComparable<CValue>, IEquatable<CValue>, IComparable
    {
        private string m_strVal;
        private string m_strVal2;
        private int m_iRow;
        private int m_iRow2;

        public CValue(string strVal, int iRow)
        {
            m_strVal = strVal;
            m_strVal2 = strVal;
            m_iRow = iRow;
            m_iRow2 = iRow;
        }
        public override string ToString()
        {
            return string.Format("[{0}]={1}", m_iRow, m_strVal);
        }
        public override int GetHashCode()
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(ToString()), Base64FormattingOptions.None).GetHashCode();
        }
        public int CompareTo(CValue? rhs)
        {
            int iRet;
            TypeCode TypeCode = Type.GetTypeCode(Global.g_bColType);
            bool bLhs, bRhs, bType;
            switch (TypeCode)
            {
                case TypeCode.Int32:
                    bLhs = Int32.TryParse(!string.IsNullOrEmpty(m_strVal) ? m_strVal : "0", out Int32 iLhs32);
                    bRhs = Int32.TryParse(!string.IsNullOrEmpty(rhs.m_strVal) ? rhs.m_strVal : "0", out Int32 iRhs32);
                    bool bNumber = (bLhs && bRhs) ? true : false;
                    if (bNumber)
                        iRet = Global.g_bSortOrder ? (iLhs32 < iRhs32 ? -1 : (iLhs32 == iRhs32 ? 0 : 1)) : (iLhs32 < iRhs32 ? 1 : (iLhs32 == iRhs32 ? 0 : -1));
                    else // fallback to string
                        iRet = Global.g_bSortOrder ? string.Compare(m_strVal, rhs.m_strVal) : string.Compare(rhs.m_strVal, m_strVal);
                    break;
                case TypeCode.Double:
                    bLhs = double.TryParse(!string.IsNullOrEmpty(m_strVal) ? m_strVal : "0.0", out double dLhs);
                    bRhs = double.TryParse(!string.IsNullOrEmpty(rhs.m_strVal) ? rhs.m_strVal : "0.0", out double dRhs);
                    bType = (bLhs && bRhs) ? true : false;
                    if (bType)
                        iRet = Global.g_bSortOrder ? (dLhs < dRhs ? -1 : (dLhs == dRhs ? 0 : 1)) : (dLhs < dRhs ? 1 : (dLhs == dRhs ? 0 : -1));
                    else // fall back to string
                        iRet = Global.g_bSortOrder ? string.Compare(m_strVal, rhs.m_strVal) : string.Compare(rhs.m_strVal, m_strVal);
                    break;
                case TypeCode.DateTime:
                    bLhs = DateTime.TryParse(!string.IsNullOrEmpty(m_strVal) ? m_strVal : "0", out DateTime dtLhs);
                    bRhs = DateTime.TryParse(!string.IsNullOrEmpty(rhs.m_strVal) ? rhs.m_strVal : "0", out DateTime dtRhs);
                    bType = (bLhs && bRhs) ? true : false;
                    if (bType)
                        iRet = Global.g_bSortOrder ? (dtLhs < dtRhs ? -1 : (dtLhs == dtRhs ? 0 : 1)) : (dtLhs < dtRhs ? 1 : (dtLhs == dtRhs ? 0 : -1));
                    else // fall back to string
                        iRet = Global.g_bSortOrder ? string.Compare(m_strVal, rhs.m_strVal) : string.Compare(rhs.m_strVal, m_strVal);
                    break;
                case TypeCode.String:
                    iRet = Global.g_bSortOrder ? string.Compare(m_strVal, rhs.m_strVal) : string.Compare(rhs.m_strVal, m_strVal);
                    break;
                default:
                    bLhs = Int64.TryParse(!string.IsNullOrEmpty(m_strVal) ? m_strVal : "0", out Int64 iLhs64);
                    bRhs = Int64.TryParse(!string.IsNullOrEmpty(rhs.m_strVal) ? rhs.m_strVal : "0", out Int64 iRhs64);
                    bNumber = (bLhs && bRhs) ? true : false;
                    if (bNumber)
                        iRet = Global.g_bSortOrder ? (iLhs64 < iRhs64 ? -1 : (iLhs64 == iRhs64 ? 0 : 1)) : (iLhs64 < iRhs64 ? 1 : (iLhs64 == iRhs64 ? 0 : -1));
                    else // fallback to string
                        iRet = Global.g_bSortOrder ? string.Compare(m_strVal, rhs.m_strVal) : string.Compare(rhs.m_strVal, m_strVal);
                    break;
            }
            return iRet;
        }
        int IComparable.CompareTo(object? rhs)
        {
            if (!(rhs is CValue))
                throw new InvalidOperationException("CompareTo: Not a CValue");
            return CompareTo((CValue)rhs);
        }
        public static bool operator <(CValue lhs, CValue rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator >(CValue lhs, CValue rhs) => lhs.CompareTo(rhs) > 0;
        public bool Equals(CValue? rhs)
        {
            return CompareTo(rhs) == 0;
        }
        public override bool Equals(object? rhs)
        {
            if (!(rhs is CValue))
                return false;
            return Equals((CValue)rhs);
        }
        public static bool operator ==(CValue lhs, CValue rhs) => lhs.Equals(rhs);
        public static bool operator !=(CValue lhs, CValue rhs) => !(lhs == rhs);

        public string Value
        {
            get { return m_strVal; }
            set { m_strVal = value; }
        }

        public string Value2
        {
            get { return m_strVal2; }
            set { m_strVal2 = value; }
        }

        public int Row
        {
            get { return m_iRow; }
            set { m_iRow = value; }
        }

        public int Row2
        {
            get { return m_iRow2; }
            set { m_iRow2 = value; }
        }
    }
}
