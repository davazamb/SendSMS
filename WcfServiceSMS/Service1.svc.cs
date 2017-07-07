using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WcfServiceSMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public ParametroSMS SendSMS(string envioSMS)
        {
            if (envioSMS == "0")
            {
                return new ParametroSMS()
                { Usuario = "Juan@gmail.com", Clave = "1234", Remitente = "56990512688", Destinatario = "56990512688", Mensaje = "Hola Bienvenido"};
            }
            else if (envioSMS == "1")
            {
                return new ParametroSMS()
                { Usuario = "Pedro@gmail.com", Clave = "1234", Remitente = "56990512688", Destinatario = "56990512688", Mensaje = "Hola Bienvenido" };

            }
            else if (envioSMS == "2")
            {
                return new ParametroSMS()
                { Usuario = "Maria@gmail.com", Clave = "1234", Remitente = "56990512688", Destinatario = "56990512688", Mensaje = "Hola Bienvenido" };

            }
            else
            {
                return new ParametroSMS() { MensajeError = "Mensaje no se envio!" };
            }
        }


        //public ParametroSMS SendSMS(string Identificacion)
        //{
        //    if (Identificacion == "0")
        //    {
        //        return new Persona() { Nombre = "Felipe", Edad = 99 };
        //    }
        //    else if (Identificacion == "1")
        //    {
        //        return new Persona() { Nombre = "Pepe", Edad = 30 };
        //    }
        //    else
        //    {
        //        return new Persona() { MensajeError = "Persona no se encontró!" };
        //    }
        //}


        //string ctx = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //public string SendSMS(ParametroSMS envioSms)
        //{
        //    int res = 0;
        //    try
        //    {
        //        SqlConnection cnn = new SqlConnection(ctx);
        //        cnn.Open();
        //        SqlCommand cmd = new SqlCommand("", cnn);

        //        cnn.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception("Error al insertar", ex);
        //    }
        //}
    }      
    
}
