using System;

namespace task3
{
    class DoubleMatr
    {
        Random rand = new Random();

        private double[,] _matr;
        public int RowCount => _matr.GetLength(0);
        public int ColumnCount => _matr.GetLength(1);

        public double this[int i, int j] // индексатор
        {
            get
            {
                return _matr[i, j];
            }
        }
        public DoubleMatr(double[,] matr)
        {
            _matr = matr;
        }
        public DoubleMatr(int rowCount, int columnCount)
        {
            _matr = new double[rowCount, columnCount];
        }

        public static DoubleMatr operator +(DoubleMatr currentMatr, DoubleMatr addMatr) // оператор + матр
        {
            double[,] result = new double[currentMatr.RowCount, currentMatr.ColumnCount];
            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    result[i, j] = currentMatr[i, j] + addMatr[i, j];
                }
            }
            return new DoubleMatr(result);
        }
        public static DoubleMatr operator -(DoubleMatr currentMatr, DoubleMatr substrMatr) // оператор - матр
        {
            double[,] result = new double[currentMatr.RowCount, currentMatr.ColumnCount];

            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    result[i, j] = currentMatr[i, j] - substrMatr[i, j];
                }
            }
            return new DoubleMatr(result);
        }
        public static DoubleMatr operator -(DoubleMatr currentMatr, int substrInt) // оператор - число
        {
            double[,] result = new double[currentMatr.RowCount, currentMatr.ColumnCount];

            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    result[i, j] = currentMatr[i, j] - substrInt;
                }
            }
            return new DoubleMatr(result);
        }
        public static DoubleMatr operator + (DoubleMatr currentMatr, int addInt) // оператор + число
        {
            double[,] result = new double[currentMatr.RowCount, currentMatr.ColumnCount];

            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    result[i, j] = currentMatr[i, j] + addInt;
                }
            }
            return new DoubleMatr(result);
        }
        public static bool operator ==(DoubleMatr currentMatr, DoubleMatr addMatr) // оператор ==
        {
            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    if (currentMatr[i,j]!=addMatr[i,j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(DoubleMatr currentMatr, DoubleMatr addMatr) // оператор - матр

        {
            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    if (currentMatr[i, j] != addMatr[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void Info()
        {
            for (int i = 0; i < _matr.GetLength(0); i++)
            {
                for (int j = 0; j < _matr.GetLength(1); j++)
                {
                    Console.Write($"{_matr[i, j],-7 :F2}");
                }
                Console.WriteLine();
            }
        }
        public void Fill()
        {
            for (int i = 0; i < _matr.GetLength(0); i++)
            {
                for (int j = 0; j < _matr.GetLength(1); j++)
                {
                    _matr[i, j] = rand.NextDouble();
                }
            }
        }

    }
}

