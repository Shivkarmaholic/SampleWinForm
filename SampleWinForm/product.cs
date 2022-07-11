using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWinForm
{
    [Serializable] // Attribute in C#
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }

}
