using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glava3_Task3
{/// <summary>
 /// creating an array of words and working with them
 /// </summary>
    class WordMatr
    {
        private string[,] _matr;
        public int RowCount => _matr.GetLength(0);
        public int ColumnCount => _matr.GetLength(1);
        /// <summary>
        /// class indexer with array of words
        /// </summary>
        public string this[int i, int j]
        {
            get
            {
                return _matr[i, j];
            }
        }
        /// <summary>
        /// class constructor
        /// </summary>
        public WordMatr(string[,] matr)
        {
            _matr = matr;
        }
        /// <summary>
        /// class constructor
        /// </summary>
        public WordMatr(int rowCount, int columnCount)
        {
            _matr = new string[rowCount, columnCount];
        }
        /// <summary>
        /// overloading the + operator to add arrays of words
        /// </summary>
        public static WordMatr operator +(WordMatr currentMatr, WordMatr addMatr)
        {
            string[,] result = new string[currentMatr.RowCount, currentMatr.ColumnCount];
            for (int i = 0; i < currentMatr.RowCount; i++)
            {
                for (int j = 0; j < currentMatr.ColumnCount; j++)
                {
                    result[i, j] = currentMatr[i, j] + " " + addMatr[i, j];
                }
            }
            return new WordMatr(result);
        }
        /// <summary>
        /// get array contetn on console
        /// </summary>
        public void Info()
        {
            for (int i = 0; i < _matr.GetLength(0); i++)
            {
                for (int j = 0; j < _matr.GetLength(1); j++)
                {
                    Console.Write($"{_matr[i, j],-20}");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// filling frray with randomness names
        /// </summary>
        public void Fill()
        {
            for (int i = 0; i < _matr.GetLength(0); i++)
            {
                for (int j = 0; j < _matr.GetLength(1); j++)
                {
                    _matr[i, j] = Faker.Name.First();
                }
            }
        }

    }
}
