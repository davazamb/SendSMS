using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookComputing.XmlRpc;
using System.Configuration;

namespace SendSMSXmlRpc
{
    public class SmsAccion
    {
        private readonly ISmsProxy _smsService = XmlRpcProxyGen.Create<ISmsProxy>();
        private readonly string _usuarioSms = ConfigurationManager.AppSettings["SmsUsuario"];
        private readonly string _claveSms = ConfigurationManager.AppSettings["SmsClave"];

        public SmsAccion()
        {
            _smsService.Url = ConfigurationManager.AppSettings["SmsUrl"];
        }
        
        public ResultadoAccion Enviar(string usuario, string clave, string remitente, string destinatario, string mensaje)
        {
            var resultado = new ResultadoAccion(0, "Acción exitosa.");
            try
            {                                     
                var resultadoEnvio = _smsService.Enviar(_usuarioSms, _claveSms, remitente, destinatario, mensaje);    

                resultado.Codigo = resultadoEnvio.Code;
                resultado.Mensaje = resultadoEnvio.Code == 0 ? "Operación exitosa" : resultadoEnvio.Message;
            }
            catch (Exception exc)
            {                                            
                resultado.Codigo = -1;
                resultado.Mensaje = "Error inesperado al realizar la operación.";
                resultado.Extra = exc.ToString();
            }
            return resultado;
        }


    }
}


