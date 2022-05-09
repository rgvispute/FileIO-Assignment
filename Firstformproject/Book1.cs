using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstformproject
{
    [Serializable]
    public class Book1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Authorname { get; set; }
        public int Price { get; set; }
    }
}
