using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstformproject
{
    [Serializable]
    public class Batch1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Startd { get; set; }
        public int Endd { get; set; }
        public string Location { get; set; }
        public string Tname { get; set; }
    }

}