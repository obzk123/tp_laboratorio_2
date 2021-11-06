using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos <T>
        where T : Torneo
    {
        public T AbrirTxt(string path, T dato);

        public T AbrirJSON(string path, T dato);

        public T AbrirXML(string path, T dato);

        public bool GuardarTxt(string path, T dato);

        public bool GuardarJSON(string path, T dato);

        public bool GuardarXML(string path, T dato);

    }
}
