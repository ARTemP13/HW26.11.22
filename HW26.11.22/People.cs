using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW26._11._22
{
    internal class People
    {
        public string name { get; set; }
        public string[] hobby { get; set; }
        public string phrase { get; set; }
        public People(string name, string phrase)
        {
            this.name = name;
            this.phrase = phrase;
        }
    }
}
