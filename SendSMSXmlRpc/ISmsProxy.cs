using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSXmlRpc
{
    [XmlRpcUrl("")]
    public interface ISmsProxy : IXmlRpcProxy
    {
        [XmlRpcMethod("submitMsg", StructParams = false)]
        SmsMsgResponseData Enviar(string usuario, string clave, string remitente, string destinatario, string mensaje);

    }
}        

