using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hotel_App
{

    public class Client
    {
        public int Room { get; set; }

        public string? Name { get; set; }

        public DateTime CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
    }
}

