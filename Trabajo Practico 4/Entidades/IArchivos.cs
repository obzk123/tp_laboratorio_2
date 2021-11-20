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
        public T AbrirTxt(string path);

        public T AbrirJSON(string path);

        public T AbrirXML(string path);

        public bool GuardarTxt(string path, T dato);

        public bool GuardarJSON(string path, T dato);

        public bool GuardarXML(string path, T dato);

    }
}
