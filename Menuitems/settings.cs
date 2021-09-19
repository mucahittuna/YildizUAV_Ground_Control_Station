using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Security.Cryptography.X509Certificates;
using UI_Prototype_1;
using System.Security.Permissions;
using System.Reflection;
using System.IO;
using System.Globalization;


namespace UI_Prototype_1.Menuitems
{
    public partial class settings : UserControl
    {


        // TcpClient Classından obje oluşturup settings classında  obje üzerinedn methodlara ulaşıyoruz
        //Form1 form = new Form1();
        //public const string IpNum = "192.168.0.10";
        //public const int PortNum = 8080;

        public settings()
        {
     
            InitializeComponent();
            //Form1 form = new Form1();
         
        }


        //TcpClient client = new TcpClient();
        //Byte[] data = new Byte[256];
       

        //TcpClient client = new TcpClient("192.168.0.10", 8080); // haberleşilecek IP ve Port adresleri (Bu IP ve Port adreslerinde herhngi bi sunucu olmadan program çalışmamaktadır)
        //Byte[] data = new Byte[256];
        // haberleşilecek IP ve Port adresleri (Bu IP ve Port adreslerinde herhngi bi sunucu olmadan program çalışmamaktadır)

        public void dataoku()   // Hava aracı sürekli bu methoddan dinleniyor
        {

            try
            {
               
                //TcpClient client = new TcpClient(form.getIpNum(), form.getPortNum());
                Byte[] data = new Byte[256];
                while (true)
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    //NetworkStream stream = client.GetStream();
                    String responseData = String.Empty;
                    //Int32 bytes = stream.Read(data, 0, data.Length);
                    //responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    txtRead.AppendText("Data : " + responseData + Environment.NewLine);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Drone Haberleşmeyi Durdurdu");
            }


        }

      

        public void btnSend_Click(object sender, EventArgs e) //Veri göndermek için kullanılan method **Güncellenecek
        {
           
            
            try
            {

                ////TcpClient client = new TcpClient(form.getIpNum(), form.getPortNum());
                //string message;
                //message = txtSend.Text.ToString();
                //Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                //NetworkStream stream = client.GetStream();
                //stream.Write(data, 0, data.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("Drone Haberleşmeyi Durdurdu");
            }

        }
    }
}
