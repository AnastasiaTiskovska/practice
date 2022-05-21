using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public struct Train
    {
        public int Id { get; init; }
        public string Destination { get; init; }
        public DateTime Date { get; init; }

        public Train(int id, string destination, DateTime date)
        {
            Id = id;
            Destination = destination;
            Date = date;
        }
    }
}
