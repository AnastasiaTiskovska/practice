using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Task1.Models
{
    [Table(Name = "Сезоны")]

    public class Seasons
    {
        [Column(Name = "Код_сезона", IsPrimaryKey = true, IsDbGenerated = true)]

        public int IdTur { get; set; }
        [Column(Name = "Код тура")]

        public int Beginning { get; set; }
        [Column(Name = "Дата начала")]

        public int End { get; set; }
        [Column(Name = "Дата конца")]

        public bool Closed { get; set; }
        [Column(Name = "Сезон закрыт")]

        public int Places { get; set; }
        [Column(Name = "Количество мест")]

        public string LastName { get; set; }
    }
}
