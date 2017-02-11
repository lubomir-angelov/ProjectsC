using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Classes : School
    {
        private string textIdentifier = "Default";
        private string textBlock = "Default";

        public string TextIdentifier
        {
            get { return this.textIdentifier; }
        }
        public string TextBlock
        { get { return this.textBlock; } }
    }
}
