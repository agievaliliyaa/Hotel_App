using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel_App
{
   
   
    public class Client
    {
        public int Room { get; set; }

        public string Name { get; set; }

        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public int Status { get; set; }
    }
}
