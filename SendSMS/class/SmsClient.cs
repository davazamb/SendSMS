using System;
using System.IO;
using System.Net;

namespace SmsClient
{
    public class SendSms
    {
        public string send(string clientId, string clientPassword, string ani, string dnis, string msg)
        {
            string result = null;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string.Concat(new string[]
                {
                    "http://ubaid.tk/sms/sms.aspx?uid=",
                    clientId,
                    "&pwd=",
                    clientPassword,
                    "&msg=",
                    ani,
                    "&phone=",
                    dnis,
                    "&provider=way2sms",
                    msg,
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