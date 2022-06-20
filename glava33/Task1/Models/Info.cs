using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Task1.Models
{
    [Table(Name = "Информация о туристах")]

    public class Info
    {
        [Column(Name = "Код_туриста", IsPrimaryKey = true, IsDbGenerated = true)]

        public string Passporti { get; set; }
        [Column(Name = "Серия паспорта")]

        public string City { get; set; }
        [Column(Name = "Город")]

        public string Country { get; set; }
        [Column(Name = "Странна")]

        public int Telephone { get; set; }
        [Column(Name = "Телефон")]

        public int Index { get; set; }
        [Column(Name = "Индекс")]

        public string LastName { get; set; }
    }
}
