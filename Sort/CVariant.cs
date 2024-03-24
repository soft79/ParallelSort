using System.Text;

namespace Sort
{
    public class CVariant : IComparable<CVariant>, IEquatable<CVariant>, IComparable
    {
        private readonly TypeCode m_TypeCode;
        private readonly Boolean[]? m_boolVal = null;
        private readonly Char[]? m_cVal = null;
        private readonly Byte[]? m_byteVal = null;
        private readonly SByte[]? m_sbyteVal = null;
        private readonly Int16[]? m_int16Val = null;
        private readonly UInt16[]? m_uint16Val = null;
        private readonly Int32[]? m_int32Val = null;
        private readonly UInt32[]? m_uint32Val = null;
        private readonly Int64[]? m_int64Val = null;
        private readonly UInt64[]? m_uint64Val = null;
        private readonly Single[]? m_fVal = null;
        private readonly Double[]? m_dVal = null;
        private readonly Decimal[]? m_decVal = null;
        private readonly DateTime[]? m_dtVal = null;
        private readonly String[]? m_strVal = null;
        private readonly int[]? m_arrRow = null;
        private bool[]? m_bNull = null;

        public CVariant(bool bNull)
        {
            m_bNull = new bool[] { bNull, bNull };
        }
        public CVariant(int iRow) : this(true)
        {
            m_TypeCode = TypeCode.Empty;
            m_arrRow = new int[] { iRow, iRow };
        }

        public CVariant(TypeCode TypeCode, int iRow) : this(true)
        {
            m_TypeCode = TypeCode;
            switch (TypeCode)
            {
                case TypeCode.Boolean:
                    m_boolVal = new Boolean[] { false, false };
                    break;

                case TypeCode.Char:
                    m_cVal = new Char[] { Char.MinValue, Char.MinValue };
                    break;

                case TypeCode.Byte:
                    m_byteVal = new Byte[] { Byte.MinValue, Byte.MinValue };
                    break;

                case TypeCode.SByte:
                    m_sbyteVal = new SByte[] { SByte.MinValue, SByte.MinValue };
                    break;

                case TypeCode.Int16:
                    m_int16Val = new Int16[] { Int16.MinValue, Int16.MinValue };
                    break;

                case TypeCode.UInt16:
                    m_uint16Val = new UInt16[] { UInt16.MinValue, UInt16.MinValue };
                    break;

                case TypeCode.Int32:
                    m_int32Val = new Int32[] { Int32.MinValue, Int32.MinValue };
                    break;

                case TypeCode.UInt32:
                    m_uint32Val = new UInt32[] { UInt32.MinValue, UInt32.MinValue };
                    break;

                case TypeCode.Int64:
                    m_int64Val = new Int64[] { Int64.MinValue, Int64.MinValue };
                    break;

                case TypeCode.UInt64:
                    m_uint64Val = new UInt64[] { UInt64.MinValue, UInt64.MinValue };
                    break;

                case TypeCode.Single:
                    m_fVal = new Single[] { Single.MinValue, Single.MinValue };
                    break;

                case TypeCode.Double:
                    m_dVal = new Double[] { Double.MinValue, Double.MinValue };
                    break;

                case TypeCode.Decimal:
                    m_decVal = new Decimal[] { Decimal.MinValue, Decimal.MinValue };
                    break;

                case TypeCode.DateTime:
                    m_dtVal = new DateTime[] { DateTime.MinValue, DateTime.MinValue };
                    break;

                case TypeCode.String:
                    m_strVal = new String[] { string.Empty, string.Empty };
                    break;

                default:
                    break;
            }
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Boolean boolVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Boolean;
            m_boolVal = new Boolean[] { boolVal, boolVal };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Char cVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Char;
            m_cVal = new Char[] { cVal, cVal };
            m_arrRow = new int[] { iRow, iRow };
        }

        public CVariant(Byte byteVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Byte;
            m_byteVal = new Byte[] { byteVal, byteVal };
            m_arrRow = new int[] { iRow, iRow };
        }

        public CVariant(SByte sbyteVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.SByte;
            m_sbyteVal = new SByte[] { sbyteVal, sbyteVal };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Int16 int16Val, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Int16;
            m_int16Val = new Int16[] { int16Val, int16Val };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(UInt16 uint16Val, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.UInt16;
            m_uint16Val = new UInt16[] { uint16Val, uint16Val };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Int32 int32Val, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Int32;
            m_int32Val = new Int32[] { int32Val, int32Val };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(UInt32 uint32Val, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.UInt32;
            m_uint32Val = new UInt32[] { uint32Val, uint32Val };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Int64 int64Val, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Int64;
            m_int64Val = new Int64[] { int64Val, int64Val };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(UInt64 uint64Val, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.UInt64;
            m_uint64Val = new UInt64[] { uint64Val, uint64Val };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Single fVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Single;
            m_fVal = new Single[] { fVal, fVal };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Double dVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Double;
            m_dVal = new Double[] { dVal, dVal };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(Decimal decVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.Decimal;
            m_decVal = new Decimal[] { decVal, decVal };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(DateTime dtVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.DateTime;
            m_dtVal = new DateTime[] { dtVal, dtVal };
            m_arrRow = new int[] { iRow, iRow };
        }
        public CVariant(String strVal, int iRow) : this(false)
        {
            m_TypeCode = TypeCode.String;
            m_strVal = new String[] { strVal, strVal };
            m_arrRow = new int[] { iRow, iRow };
        }
        public override string ToString()
        {
            return CellValue;
        }
        public override int GetHashCode()
        {
            return Utility.GetHashCode(ToString());
        }
        public int CompareTo(CVariant? rhs)
        {
            int iRet;

            switch (m_TypeCode)
            {
                case TypeCode.Boolean:
                    Boolean boolLhs = m_boolVal[0];
                    Boolean boolRhs = rhs.m_boolVal[0];
                    iRet = Global.g_bSortOrder ? (boolLhs == true && boolRhs == false ? -1 : (boolLhs == boolRhs ? 0 : 1)) : (boolLhs == true && boolRhs == false ? 1 : (boolLhs == boolRhs ? 0 : -1));
                    break;

                case TypeCode.Byte:
                    Byte bLhs = m_byteVal[0];
                    Byte bRhs = rhs.m_byteVal[0];
                    iRet = Global.g_bSortOrder ? (bLhs < bRhs ? -1 : (bLhs == bRhs ? 0 : 1)) : (bLhs < bRhs ? 1 : (bLhs == bRhs ? 0 : -1));
                    break;

                case TypeCode.SByte:
                    SByte sbLhs = m_sbyteVal[0];
                    SByte sbRhs = rhs.m_sbyteVal[0];
                    iRet = Global.g_bSortOrder ? (sbLhs < sbRhs ? -1 : (sbLhs == sbRhs ? 0 : 1)) : (sbLhs < sbRhs ? 1 : (sbLhs == sbRhs ? 0 : -1));
                    break;

                case TypeCode.Char:
                    Char cLhs = m_cVal[0];
                    Char cRhs = rhs.m_cVal[0];
                    iRet = Global.g_bSortOrder ? (cLhs < cRhs ? -1 : (cLhs == cRhs ? 0 : 1)) : (cLhs < cRhs ? 1 : (cLhs == cRhs ? 0 : -1));
                    break;

                case TypeCode.Int16:
                    Int16 i16Lhs = m_int16Val[0];
                    Int16 i16Rhs = rhs.m_int16Val[0];
                    iRet = Global.g_bSortOrder ? (i16Lhs < i16Rhs ? -1 : (i16Lhs == i16Rhs ? 0 : 1)) : (i16Lhs < i16Rhs ? 1 : (i16Lhs == i16Rhs ? 0 : -1));
                    break;

                case TypeCode.UInt16:
                    UInt16 ui16Lhs = m_uint16Val[0];
                    UInt16 ui16Rhs = rhs.m_uint16Val[0];
                    iRet = Global.g_bSortOrder ? (ui16Lhs < ui16Rhs ? -1 : (ui16Lhs == ui16Rhs ? 0 : 1)) : (ui16Lhs < ui16Rhs ? 1 : (ui16Lhs == ui16Rhs ? 0 : -1));
                    break;

                case TypeCode.Int32:
                    Int32 i32Lhs = m_int32Val[0];
                    Int32 i32Rhs = rhs.m_int32Val[0];
                    iRet = Global.g_bSortOrder ? (i32Lhs < i32Rhs ? -1 : (i32Lhs == i32Rhs ? 0 : 1)) : (i32Lhs < i32Rhs ? 1 : (i32Lhs == i32Rhs ? 0 : -1));
                    break;

                case TypeCode.UInt32:
                    UInt32 ui32Lhs = m_uint32Val[0];
                    UInt32 ui32Rhs = rhs.m_uint32Val[0];
                    iRet = Global.g_bSortOrder ? (ui32Lhs < ui32Rhs ? -1 : (ui32Lhs == ui32Rhs ? 0 : 1)) : (ui32Lhs < ui32Rhs ? 1 : (ui32Lhs == ui32Rhs ? 0 : -1));
                    break;

                case TypeCode.Int64:
                    Int64 i64Lhs = m_int64Val[0];
                    Int64 i64Rhs = rhs.m_int64Val[0];
                    iRet = Global.g_bSortOrder ? (i64Lhs < i64Rhs ? -1 : (i64Lhs == i64Rhs ? 0 : 1)) : (i64Lhs < i64Rhs ? 1 : (i64Lhs == i64Rhs ? 0 : -1));
                    break;

                case TypeCode.UInt64:
                    UInt64 ui64Lhs = m_uint64Val[0];
                    UInt64 ui64Rhs = rhs.m_uint64Val[0];
                    iRet = Global.g_bSortOrder ? (ui64Lhs < ui64Rhs ? -1 : (ui64Lhs == ui64Rhs ? 0 : 1)) : (ui64Lhs < ui64Rhs ? 1 : (ui64Lhs == ui64Rhs ? 0 : -1));
                    break;

                case TypeCode.Single:
                    Single fLhs = m_fVal[0];
                    Single fRhs = rhs.m_fVal[0];
                    iRet = Global.g_bSortOrder ? (fLhs < fRhs ? -1 : (fLhs == fRhs ? 0 : 1)) : (fLhs < fRhs ? 1 : (fLhs == fRhs ? 0 : -1));
                    break;

                case TypeCode.Double:
                    Double dLhs = m_dVal[0];
                    Double dRhs = rhs.m_dVal[0];
                    iRet = Global.g_bSortOrder ? (dLhs < dRhs ? -1 : (dLhs == dRhs ? 0 : 1)) : (dLhs < dRhs ? 1 : (dLhs == dRhs ? 0 : -1));
                    break;

                case TypeCode.Decimal:
                    Decimal decLhs = m_decVal[0];
                    Decimal decRhs = rhs.m_decVal[0];
                    iRet = Global.g_bSortOrder ? (decLhs < decRhs ? -1 : (decLhs == decRhs ? 0 : 1)) : (decLhs < decRhs ? 1 : (decLhs == decRhs ? 0 : -1));
                    break;

                case TypeCode.DateTime:
                    DateTime dtLhs = m_dtVal[0];
                    DateTime dtRhs = rhs.m_dtVal[0];
                    iRet = Global.g_bSortOrder ? (dtLhs < dtRhs ? -1 : (dtLhs == dtRhs ? 0 : 1)) : (dtLhs < dtRhs ? 1 : (dtLhs == dtRhs ? 0 : -1));
                    break;

                case TypeCode.String:
                    string strLhs = m_strVal[0];
                    string strRhs = rhs.m_strVal[0];
                    iRet = Global.g_bSortOrder ? string.Compare(strLhs, strRhs, false) : string.Compare(strRhs, strLhs, false);
                    break;

                case TypeCode.Empty:
                    iRet = 0;
                    break;

                default:
                    iRet = 0;
                    break;
            }
            return iRet;
        }
        int IComparable.CompareTo(object? rhs)
        {
            if (!(rhs is CVariant))
                throw new InvalidOperationException("CompareTo: Not a CVariant");
            return CompareTo((CVariant)rhs);
        }
        public static bool operator <(CVariant lhs, CVariant rhs) => lhs.CompareTo(rhs) < 0;
        public static bool operator >(CVariant lhs, CVariant rhs) => lhs.CompareTo(rhs) > 0;
        public bool Equals(CVariant? rhs)
        {
            return CompareTo(rhs) == 0;
        }
        public override bool Equals(object? rhs)
        {
            if (!(rhs is CVariant))
                return false;
            return Equals((CVariant)rhs);
        }
        public static bool operator ==(CVariant lhs, CVariant rhs) => lhs.Equals(rhs);
        public static bool operator !=(CVariant lhs, CVariant rhs) => !(lhs == rhs);

        public void Copy(CVariant rhs, int iFrom, int iTo)
        {
            m_bNull[iTo] = rhs.m_bNull[iFrom];
            switch (m_TypeCode)
            {
                case TypeCode.Boolean:
                    m_boolVal[iTo] = rhs.m_boolVal[iFrom];
                    break;

                case TypeCode.Char:
                    m_cVal[iTo] = rhs.m_cVal[iFrom];
                    break;

                case TypeCode.Byte:
                    m_byteVal[iTo] = rhs.m_byteVal[iFrom];
                    break;

                case TypeCode.SByte:
                    m_sbyteVal[iTo] = rhs.m_sbyteVal[iFrom];
                    break;

                case TypeCode.Int16:
                    m_int16Val[iTo] = rhs.m_int16Val[iFrom];
                    break;

                case TypeCode.UInt16:
                    m_uint16Val[iTo] = rhs.m_uint16Val[iFrom];
                    break;

                case TypeCode.Int32:
                    m_int32Val[iTo] = rhs.m_int32Val[iFrom];
                    break;

                case TypeCode.UInt32:
                    m_uint32Val[iTo] = rhs.m_uint32Val[iFrom];
                    break;

                case TypeCode.Int64:
                    m_int64Val[iTo] = rhs.m_int64Val[iFrom];
                    break;

                case TypeCode.UInt64:
                    m_uint64Val[iTo] = rhs.m_uint64Val[iFrom];
                    break;

                case TypeCode.Single:
                    m_fVal[iTo] = rhs.m_fVal[iFrom];
                    break;

                case TypeCode.Double:
                    m_dVal[iTo] = rhs.m_dVal[iFrom];
                    break;

                case TypeCode.Decimal:
                    m_decVal[iTo] = rhs.m_decVal[iFrom];
                    break;

                case TypeCode.DateTime:
                    m_dtVal[iTo] = rhs.m_dtVal[iFrom];
                    break;

                case TypeCode.String:
                    m_strVal[iTo] = rhs.m_strVal[iFrom];
                    break;

                case TypeCode.Empty:
                    break;

                default:
                    break;
            }
        }
        public void UpdateRow(int iRow)
        {
            m_arrRow[0] = iRow;
            m_arrRow[1] = iRow;
        }
        public string CellValue
        {
            get
            {
                string strCellValue = string.Empty;
                if (!m_bNull[0])
                {
                    switch (m_TypeCode)
                    {
                        case TypeCode.String:
                            if (m_strVal != null)
                                strCellValue = m_strVal[0];
                            break;

                        case TypeCode.Boolean:
                            if (m_boolVal != null)
                                strCellValue = m_boolVal[0].ToString();
                            break;

                        case TypeCode.Byte:
                            if (m_byteVal != null)
                                strCellValue = m_byteVal[0].ToString();
                            break;

                        case TypeCode.SByte:
                            if (m_sbyteVal != null)
                                strCellValue = m_sbyteVal[0].ToString();
                            break;

                        case TypeCode.Char:
                            if (m_cVal != null)
                                strCellValue = m_cVal[0].ToString();
                            break;

                        case TypeCode.Int16:
                            if (m_int16Val != null)
                                strCellValue = m_int16Val[0].ToString();
                            break;

                        case TypeCode.UInt16:
                            if (m_uint16Val != null)
                                strCellValue = m_uint16Val[0].ToString();
                            break;

                        case TypeCode.Int32:
                            if (m_int32Val != null)
                                strCellValue = m_int32Val[0].ToString();
                            break;

                        case TypeCode.UInt32:
                            if (m_uint32Val != null)
                                strCellValue = m_uint32Val[0].ToString();
                            break;

                        case TypeCode.Int64:
                            if (m_int64Val != null)
                                strCellValue = m_int64Val[0].ToString();
                            break;

                        case TypeCode.UInt64:
                            if (m_uint64Val != null)
                                strCellValue = m_uint64Val[0].ToString();
                            break;

                        case TypeCode.Single:
                            if (m_fVal != null)
                                strCellValue = m_fVal[0].ToString();
                            break;

                        case TypeCode.Double:
                            if (m_dVal != null)
                                strCellValue = m_dVal[0].ToString();
                            break;

                        case TypeCode.Decimal:
                            if (m_decVal != null)
                                strCellValue = m_decVal[0].ToString();
                            break;

                        case TypeCode.DateTime:
                            if (m_dtVal != null)
                                strCellValue = m_dtVal[0].ToString();
                            break;

                        case TypeCode.Empty:
                            break;
                    }
                }
                else
                    strCellValue = "NULL";
                return strCellValue;
            }
        }

        public int Row
        {
            get { return m_arrRow[0]; }
        }
    }
}
