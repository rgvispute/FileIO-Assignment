using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstformproject
{
    [Serializable]
    public class Product1
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public string Catname { get; set; }
        public int Price { get; set; }
    }
    
}
