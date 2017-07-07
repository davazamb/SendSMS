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

namespace SendSMSXmlRpc
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
            SmsAccion sms = new SmsAccion();
            sms.Enviar(textUserName.Text, textPassword.Text, textPhone.Text, textPhone.Text, textMessage.Text);  

        }         
       
    }
}
