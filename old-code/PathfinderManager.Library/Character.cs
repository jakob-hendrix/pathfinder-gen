using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderManager.Library
{
    public class Character
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
    }
}
