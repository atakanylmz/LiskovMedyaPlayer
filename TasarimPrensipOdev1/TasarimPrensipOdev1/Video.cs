using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasarimPrensipOdev1
{
    public class Video : Medya
    {
        public uint Sure { get; set; }
        public float IbdbPuani { get; set; }
        public override string Play()
        {
            return "video oynatılıyor";
        }

        public override string Stop()
        {
            return "video durduruldu";
        }
    }
}
