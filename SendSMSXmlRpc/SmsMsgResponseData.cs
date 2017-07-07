using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendSMSXmlRpc
{
    public class SmsMsgResponseData
    {

        [XmlRpcMember("MESSAGE")]
        public string Message { get; set; }

        [XmlRpcMember("CODE")]
        public int Code { get; set; }

        [XmlRpcMember("ID")]
        public int Id { get; set; }

    }
}
