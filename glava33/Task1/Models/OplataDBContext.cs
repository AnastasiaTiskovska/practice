using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Task1.Models
{
    public class OplataDBContext : DataContext
    {
        public OplataDBContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }
        public Table<Oplata> Oplatas { get; set; }
    }
}
