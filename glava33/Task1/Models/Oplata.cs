using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace Task1.Models
{
    [Table(Name = "Оплата")]

    public class Oplata
    {
        [Column(Name = "Код_оплаты", IsPrimaryKey = true, IsDbGenerated = true)]

        public int IdPutevki { get; set; }
        [Column(Name = "Код путевки")]

        public int DataOplata { get; set; }
        [Column(Name = "Дата оплаты")]

        public int Amount { get; set; }
        [Column(Name = "Сумма")]

        public string LastName { get; set; }
    }
}
