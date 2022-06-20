using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Task1.Models
{
    [Table(Name = "Туристы")]

    public class Tourists
    {
        [Column(Name = "Код_туриста", IsPrimaryKey = true, IsDbGenerated = true)]

        public string Id { get; set; }
        [Column(Name = "Имя")]

        public string FiratName { get; set; }
        [Column(Name = "Отчество")]

        public string MiddleName { get; set; }
        [Column(Name = "Фамилия")]

        public string LastName { get; set; }
    }
}
