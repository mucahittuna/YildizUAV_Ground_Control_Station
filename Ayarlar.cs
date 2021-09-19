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
using System.Runtime.InteropServices;


namespace UI_Prototype_1
{
    public partial class Ayarlar : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public static string ipNum;
        public static int portNum;
       

        public Ayarlar(string hostName,int port)
        {
            ipNum = hostName;
            portNum = port;
            InitializeComponent();
           
        }
        public void HeadingParameters(int yon)
        {
            headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(yon);
           
        }
     

        public void dataoku()   // Hava aracı sürekli bu methoddan dinleniyor
        {
           
               

                try
                {

                    while (true)
                    {
                        TcpClient client = new TcpClient(ipNum, portNum);
                        Byte[] data = new Byte[256];
                        Control.CheckForIllegalCrossThreadCalls = false;
                        NetworkStream stream = client.GetStream();
                        String responseData = String.Empty;
                        Int32 bytes = stream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                        HeadingParameters(Convert.ToInt32(responseData));
                        txtRead.AppendText("Data : " + responseData + Environment.NewLine);
                        Thread.Sleep(1000);
                    
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Drone Haberleşmeyi Durdurdu");
                }
            
          
            


        }

     
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Ayarlar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100000;
            
            Thread thread = new Thread(new ThreadStart(dataoku));
            thread.Start();
            timer1.Stop();
            
            

            //TcpClient client = new TcpClient(ipNum, portNum);
            //Byte[] data = new Byte[256];  
            //NetworkStream stream = client.GetStream();
            //String responseData = String.Empty;
            //Int32 bytes = stream.Read(data, 0, data.Length);
            //responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
            //HeadingParameters(Convert.ToInt32(responseData));
            //txtRead.AppendText("Data : " + responseData + Environment.NewLine);
        }
    }

   

}
