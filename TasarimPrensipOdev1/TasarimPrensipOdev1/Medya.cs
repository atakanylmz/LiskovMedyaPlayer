using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasarimPrensipOdev1
{
    public abstract class Medya
    {
        public string Ad { get; set; }
        public abstract string Play();
        public abstract string Stop();
    }
}
