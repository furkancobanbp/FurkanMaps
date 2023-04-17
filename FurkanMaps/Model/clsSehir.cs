using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurkanMaps.Model
{
    [PrimaryKey(nameof(id))]
    public class clsSehir
    {
        public int id { get; set; } 
        public string SehirAdi { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
    }
}
