using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SMSWebService
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //ServiceReference1.SendSMS_Advanced5Request msg = new ServiceReference1.SendSMS_Advanced5Request();          
            //msg.UserName = textUserName.Text;
            //msg.PassWord = textPassword.Text;
            //msg.Msg = textMessage.Text;
            //msg.Tel = 56990512688;

            //ServiceReference1.CPAWebServiceSoapClient sms = new SMSWebService.ServiceReference1.CPAWebServiceSoapClient();
            //string retorno = sms.SendSMS_Advanced5();   

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var conex = textIdent.Text;

            using (WSSms.Service1Client client = new WSSms.Service1Client())
            {
                var buscar = client.SendSMS(conex);
                var usuario = buscar.Usuario;

            }
        }
    }
}
