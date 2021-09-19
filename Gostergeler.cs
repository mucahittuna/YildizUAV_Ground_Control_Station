using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Net.Sockets;
using GMap.NET.WindowsForms.Markers;
using System.Threading;
using System.Xaml;

namespace UI_Prototype_1
{
    public partial class Gostergeler : Form
    {
        #region Drag Dll's
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion


        //11(irtifa),20(hız),360(yaw),10(roll),15(pitch),90(batarya yüzdesi)
        // 10*12*230*7*8*70
        public List<string> Datalar = new List<string>();
        public static string ipNum;
        public static int portNum;
        int altitude = 0;
        int speed = 0;
        int yaw = 0;
        double roll=0;
        double pitch=0;
        int battery = 0;
        
    
        //public Array datalar = new Array[5];
        List<string> Component_Datas= new List<string>();


        public Gostergeler(string ip, int port)
        {
            InitializeComponent();

            timer1.Start();
            timer2.Start();
            ipNum = ip;
            portNum = port;
            this.gMap.CacheLocation = System.Windows.Forms.Application.StartupPath;//Specify the map cache storage path
            this.gMap.MapProvider = GMapProviders.BingHybridMap;//Specify the map type
            this.gMap.Manager.Mode = AccessMode.ServerAndCache;//map loading mode
            this.gMap.MinZoom = 1; //minimum ratio
            this.gMap.MaxZoom = 23; //Maximum ratio
            this.gMap.Zoom = 15; //current ratio
            this.gMap.ShowCenter = false; //Do not display the center cross point
            this.gMap.DragButton = System.Windows.Forms.MouseButtons.Middle;//Left and drag the map
            this.gMap.Position = new PointLatLng(ConvertLat("41,05149"), ConvertLongt("29,01191"));

        }

       

        private double ConvertLat(string Lat) //Enlemi stringe çevirir
        {

            return Convert.ToDouble(Lat);

        }
        private double ConvertLongt(string longt) //Boylamı stringe çevirir
        {

            return Convert.ToDouble(longt);


        }
        private void Gostergeler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void gps_gosterge(double Lat, double Lng)
        {
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(Lat, Lng), GMarkerGoogleType.green_pushpin
            );
        }
        public void HeadingParameters(int yon)
        {
            headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(yon);
            
        }
        public void AttitudeParameters(double pitch, double roll)
        {
            attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(pitch, roll);
        }
        //private void irtifa(int irtifa)
        //{
        //    if (irtifa < 20)
        //    {
        //        pictureBox1.Location = new Point(850, 436-irtifa*10);
        //        lblIrtifa.Text = irtifa.ToString() + " mt";
        //    }
        //    else
        //        irtifa = 10;

        //}


        
        //11(irtifa),20(hız),360(yaw),10(roll),15(pitch),90(batarya yüzdesi)

        //private void Hiz(int hiz)
        //{
        //    lblSpeed.Text = hiz.ToString() + " mt/s";
        //    SpeedProgressbar.Value = hiz;

        //}
        private void batarya(int batarya)
        {
            //batteryProgressbar.Value = batarya;
            //lblBatteryPercent.Text = batarya.ToString()+" %";
           
        }
        public void DataParse(string ResponseData)
        {
            float roll_rx, pitch_rx, yaw_rx;




            //float roll_f = float.Parse(datas[0]);
            //float pitch_f = float.Parse(datas[1]);

            //yaw =   Convert.ToInt32(datas[2]);

            //altitude = Convert.ToInt32(ResponseData.Substring(0, 2)); 
            //speed = Convert.ToInt32(ResponseData.Substring(2, 2));
            //yaw = Convert.ToInt32(ResponseData.Substring(10, 5));

            // roll = Convert.ToDouble(ResponseData.Substring(0, 3));
            //pitch= Convert.ToDouble(ResponseData.Substring(5, 3));
            //battery= Convert.ToInt32(ResponseData.Substr5ng(11, 2));
        }

        public void dataoku()
        {
            try
            {
                while (true)
                {
                    TcpClient client = new TcpClient(ipNum, portNum);
                    Byte[] data = new Byte[256];
                    Control.CheckForIllegalCrossThreadCalls = false;
                    NetworkStream stream = client.GetStream();
                    //String responseData = String.Empty;
                    stream.Read(data, 0, data.Length);
                    //responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    //txtRead.AppendText(data.ToString());
                    //DataParse(responseData);
                    Telemetry(data);
                    //irtifa(altitude);
                    HeadingParameters(yaw);
                    
                    batarya(battery);
                    //Hiz(speed);
                    //gps_gosterge(ConvertLat("41,05149"), ConvertLongt("29,01191"));
                    client.Close();
                   // await Task.Delay(2000);

                }
            }
            catch (Exception)
            {
               
            }

   

        }

        byte[] roll_temp = new byte[4];
        byte[] pitch_temp = new byte[4];
        byte[] yaw_temp = new byte[4];


        public void Telemetry(Byte[] data)
        {
            
            roll_temp[0] = data[0];
            roll_temp[1] = data[1];
            roll_temp[2] = data[2];
            roll_temp[3] = data[3];

            pitch_temp[0] = data[4];
            pitch_temp[1] = data[5];
            pitch_temp[2] = data[6];
            pitch_temp[3] = data[7];

            yaw_temp[0] = data[8];
            yaw_temp[1] = data[9];
            yaw_temp[2] = data[10];
            yaw_temp[3] = data[11];

            Single roll_single = BitConverter.ToSingle(roll_temp,0);
            Single pitch_single = BitConverter.ToSingle(pitch_temp, 0);
            Single yaw_single = BitConverter.ToSingle(yaw_temp, 0);

            roll = Convert.ToDouble(roll_single);
            pitch = Convert.ToDouble(pitch_single);
            yaw = Convert.ToInt32(yaw_single);

            if (roll > 60) roll = 60;
            if (roll < -60) roll = -60;
        }

        public void Delayed(int delay, Action action)
        {

            timer1.Interval = delay;
            timer1.Tick += (s, e) => {
                try
                {
                    Thread thread = new Thread(new ThreadStart(dataoku));
                    thread.Start();
                }
                catch (Exception)
                {

                    MessageBox.Show("Thread Başlatılamadı");
                };
                timer1.Stop();
            };
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                timer1.Interval=500;

                Thread thread = new Thread(new ThreadStart(dataoku));
                thread.Start();
                
                
            }
            catch (Exception)
            {

                MessageBox.Show("Thread Başlatılamadı");
            };


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Visible = false;

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int i = 100;
        private void DataTimer_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            i += 2;
                rand.Next(10,20).ToString();
                altitude = rand.Next(10,20);
                speed = rand.Next(10,27);
                yaw = rand.Next(100,360);
                roll = rand.Next(10,25);
                pitch = rand.Next(10,20);
                battery = 98-i;
                //11(irtifa),20(hız),360(yaw),10(roll),15(pitch),90(batarya yüzdesi)
            
        }

        double roll_error = 0;
        double roll_error_1 = 0;
        double last_roll = 0;
        double estimated_roll = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            double ki = 0.01;
            double Ts = 50;
            double c = ki * (Ts / 2);

            roll_error = roll - last_roll;
            estimated_roll = last_roll + c * (roll_error + roll_error_1);

            roll_error_1 = roll_error;
            last_roll = roll;
            AttitudeParameters(pitch, estimated_roll);
        }
    }
}
