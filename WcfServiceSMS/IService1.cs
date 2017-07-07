using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceSMS
{          
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
[ServiceContract]
    public interface IService1
    {

        [OperationContract]                               
        ParametroSMS SendSMS(string envioSMS);      

        // TODO: Add your service operations here
    }    


    [DataContract]
    public class ParametroSMS : BaseResponse
    {
        string usuario;
        string clave;
        string remitente;
        string destinatario;
        string mensaje;

        [DataMember]
        public string Usuario { get => usuario; set => usuario = value; }
        [DataMember]
        public string Clave { get => clave; set => clave = value; }
        [DataMember]
        public string Remitente { get => remitente; set => remitente = value; }
        [DataMember]
        public string Destinatario { get => destinatario; set => destinatario = value; }
        [DataMember]
        public string Mensaje { get => mensaje; set => mensaje = value; }


        //[DataMember]
        //public string clientId { get; set; }

        //[DataMember]
        //public string clientPassword { get; set; }

        //[DataMember]
        //public string ani { get; set; }
        //[DataMember]
        //public string dnis { get; set; }
        //[DataMember]
        //public string msg { get; set; }

    }

    [DataContract]
    public class BaseResponse
    {

        [DataMember]
        public string MensajeOK { get; set; }

        [DataMember]
        public string MensajeError { get; set; }            
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
