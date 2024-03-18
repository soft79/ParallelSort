namespace Sort
{
    class CArray
    {
        private readonly CValue[][] m_oData;
        private readonly int m_nRows;
        private readonly int m_nCols;
        public CArray(int nRows, int nCols)
        {
            m_oData = new CValue[nCols][];
            for (int iCol = 0; iCol < nCols; ++iCol)
                m_oData[iCol] = new CValue[nRows];
            m_nRows = nRows;
            m_nCols = nCols;
        }
        public CValue[] this[int iCol]
        {
            get { return m_oData[iCol]; }
        }

        public void Sort(int iCol)
        {
            Array.Sort(m_oData[iCol]);

            for (int i = 0; i < m_nCols; ++i)
            {
                if (i == iCol)
                    continue;

                for (int j = 0, j2; j < m_nRows; ++j)
                {
                    j2 = m_oData[iCol][j].Row;
                    if (j == j2)
                        continue;
                    m_oData[i][j].Row2 = m_oData[i][j2].Row;
                    m_oData[i][j].Value2 = m_oData[i][j2].Value;
                }

                for (int j = 0; j < m_nRows; ++j)
                {
                    m_oData[i][j].Row = m_oData[i][j].Row2;
                    m_oData[i][j].Value = m_oData[i][j].Value2;
                }
            }

            for (int i = 0; i < m_nCols; ++i)
                for (int j = 0; j < m_nRows; ++j)
                    m_oData[i][j].Row = j;
        }

        public void ParallelSort(int iCol)
        {
            Array.Sort(m_oData[iCol]);

            Parallel.For(0, m_nCols, i =>
            {
                if (i != iCol)
                {
                    for (int j = 0, j2; j < m_nRows; ++j)
                    {
                        j2 = m_oData[iCol][j].Row;
                        if (j == j2)
                            continue;
                        m_oData[i][j].Row2 = m_oData[i][j2].Row;
                        m_oData[i][j].Value2 = m_oData[i][j2].Value;
                    }

                    for (int j = 0; j < m_nRows; ++j)
                    {
                        m_oData[i][j].Row = m_oData[i][j].Row2;
                        m_oData[i][j].Value = m_oData[i][j].Value2;
                    }
                }
            });

            Parallel.For(0, m_nCols, i =>
            {
                for (int j = 0; j < m_nRows; ++j)
                    m_oData[i][j].Row = j;
            });
        }

        public int ColLength
        {
            get { return m_nCols; }
        }
        public int RowLength
        {
            get { return m_nRows; }
        }
    }
}
