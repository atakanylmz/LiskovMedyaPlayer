using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasarimPrensipOdev1
{
    public class Player
    {       
        public string Oynat(Medya Oynatilacak)
        {
            return Oynatilacak.Play();
        }
        public string Durdur(Medya Durdurulacak)
        {
            return Durdurulacak.Stop();
        }
    }
}
