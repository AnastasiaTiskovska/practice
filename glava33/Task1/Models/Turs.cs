using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Task1.Models
{
    [Table(Name = "Туры")]

    public class Turs
    {
        [Column(Name = "Код_тура", IsPrimaryKey = true, IsDbGenerated = true)]

        public string Name { get; set; }
        [Column(Name = "Название")]

        public int Price { get; set; }
        [Column(Name = "Цена")]

        public string Info { get; set; }
        [Column(Name = "Информация")]

        public string LastName { get; set; }
    }
}
