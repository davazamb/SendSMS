using System;
using System.IO;
using System.Net;

namespace SmsClient
{
    public class SendSms
    {
        public string send(string usuario, string clave, string remitente, string destinatario, string mensaje)
        {
            string result = null;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
                {
                    "http://localhost:40143/Service1.svc",
                    usuario,
                    "&pwd=",
                    clave,
                    "&msg=",
                    remitente,
                    "&phone=",
                    destinatario,
                    "&provider=way2sms",
                    mensaje,
                    "&provider=way2sms",
                }));
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                result = streamReader.ReadToEnd();
                streamReader.Close();
                httpWebResponse.Close();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}