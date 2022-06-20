using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Task1.Models
{
    [Table(Name = "Путевки")]

    public class Putevki
    {
        [Column(Name = "Код_путевки", IsPrimaryKey = true, IsDbGenerated = true)]

        public int IdTourists { get; set; }
        [Column(Name = "Код туриста")]

        public int IdSeasons { get; set; }
        [Column(Name = "Код сезона")]

        public string LastName { get; set; }
    }
}

