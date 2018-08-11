using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasarimPrensipOdev1
{
    public class Resim : Medya
    {
        public string RenkDagilimi { get; set; }
        public string ResmiCeken { get; set; }
        public override string Play()
        {
            return "resim slaytı oynatılıyor";
        }

        public override string Stop()
        {
            return "resim slaytı durduruldu";
        }
    }
}
