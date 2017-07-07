using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSXmlRpc
{
    public class ResultadoAccion
    {

        public int Codigo { get; set; } 
        public string Mensaje { get; set; }
        public string Extra { get; set; }

        public ResultadoAccion(int codigo, string mensaje)
        {
            Codigo = codigo;
            Mensaje = mensaje;
            Extra = "";
        }
    }
}
       