using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;
using System.Globalization;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;

namespace UI_Prototype_1
{
    public partial class Harita : Form
    {
        #region DragDll's


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public string IpNum;
        public int portNum;

        public GMapOverlay overlay = new GMapOverlay("Marker");
        List<PointLatLng> list = new List<PointLatLng>();  // Harita üzerinden işaretlenen koordinatlar burada listede tutulup rota oluşturulmaktadır
        List<PointLatLng> poligonListe = new List<PointLatLng>();  // Harita üzerinden işaretlenen koordinatlar burada listede tutulup rota oluşturulmaktadır
        Byte[] SendingData = new Byte[256];
        List<string> StringData = new List<string>();
        List<int> IntData = new List<int>();
        //Drone'a gönderilecek data..

        public Harita(string ip,int port)
        {
            InitializeComponent();
            this.gMap.Overlays.Add(overlay);
            this.gMap.MouseClick += gMap_MouseClick;
            this.gMap.MouseDoubleClick += gMap_MouseDoubleClick;
            this.gMap.CacheLocation = System.Windows.Forms.Application.StartupPath;//Specify the map cache storage path
            this.gMap.MapProvider = GMapProviders.BingHybridMap;//Specify the map type
            this.gMap.Manager.Mode = AccessMode.ServerAndCache;//map loading mode
            this.gMap.MinZoom = 1; //minimum ratio
            this.gMap.MaxZoom = 23; //Maximum ratio
            this.gMap.Zoom = 15; //current ratio
            this.gMap.ShowCenter = true; //Do not display the center cross point
            this.gMap.DragButton = System.Windows.Forms.MouseButtons.Middle;//Left and drag the map
            this.gMap.Position = new PointLatLng(ConvertLat(txtLattitude.Text), ConvertLongt(txtLongtitude.Text)); 
            IpNum = ip;
            portNum = port;
            PoligonOlustur();
            direk_konumlari();
            koordinatlar();
           
        }
            
       
        public TcpClient Client()
        {
            TcpClient client = new TcpClient(IpNum, portNum);

            return client;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

            ConvertLat(txtLattitude.Text);
            ConvertLongt(txtLongtitude.Text);
            gMap.Position = new GMap.NET.PointLatLng(ConvertLat(txtLattitude.Text), ConvertLongt(txtLongtitude.Text));
            
        }
        private double ConvertLat(string Lat)
        {

            return Convert.ToDouble(txtLattitude.Text);

        }
        private double ConvertLongt(string longt)
        {

            return Convert.ToDouble(txtLongtitude.Text);

        }
        private void ClearDataList()
        {
           
            list.Clear();
            overlay.Clear();
            StringData.Clear();

        }
        private void gMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    list.RemoveAt(list.Count - 1);

                }


            }
            catch (Exception)
            {

                MessageBox.Show("Rota Oluşturulamadı");
            }

        }
        private void direk_konumlari()
        {  
            PointLatLng direk1 = new PointLatLng(40.2304456, 29.0093251);
            PointLatLng direk2 = new PointLatLng(40.2301413, 29.0088930);
            PointLatLng direk3 = new PointLatLng(40.2298156, 29.0093155);
            PointLatLng direk5 = new PointLatLng(40.2298248, 29.0093376);
            PointLatLng direk6 = new PointLatLng(40.2301520, 29.0089113);
            PointLatLng direk7 = new PointLatLng(40.2304491, 29.0093271);
            GMapMarker direk_marker1 = new GMarkerGoogle(direk1, GMarkerGoogleType.blue);
            GMapMarker direk_marker2 = new GMarkerGoogle(direk2, GMarkerGoogleType.blue);
            GMapMarker direk_marker3 = new GMarkerGoogle(direk3, GMarkerGoogleType.blue);
            GMapMarker direk_marker5 = new GMarkerGoogle(direk5, GMarkerGoogleType.red_pushpin);
            GMapMarker direk_marker6 = new GMarkerGoogle(direk6, GMarkerGoogleType.red_pushpin);
            GMapMarker direk_marker7 = new GMarkerGoogle(direk7, GMarkerGoogleType.red_pushpin);
            GMapOverlay direkler_markers = new GMapOverlay("direkler_markers");
            direkler_markers.Markers.Add(direk_marker1);
            direkler_markers.Markers.Add(direk_marker2);
            direkler_markers.Markers.Add(direk_marker3);
            direkler_markers.Markers.Add(direk_marker5);
            direkler_markers.Markers.Add(direk_marker6);
            direkler_markers.Markers.Add(direk_marker7);
            gMap.Overlays.Add(direkler_markers);

        }

        private void koordinatlar ()
        {
            PointLatLng konum1 = new PointLatLng(40.2305820, 29.0094799);
            PointLatLng konum2 = new PointLatLng(40.2305820, 29.0091527);
            PointLatLng konum3 = new PointLatLng(40.2301571, 29.0087396);
            PointLatLng konum4 = new PointLatLng(40.2300378, 29.0089193);
            PointLatLng konum5=  new PointLatLng(40.2301540, 29.0090749);
            PointLatLng konum6 = new PointLatLng(40.2302871, 29.0089086);
            PointLatLng konum7 = new PointLatLng(40.2301540, 29.0087382);
            PointLatLng konum8 = new PointLatLng(40.2296953, 29.0091848);
            PointLatLng konum9 = new PointLatLng(40.2296953, 29.0095201);

            GMapMarker konum_marker1 = new GMarkerGoogle(konum1, GMarkerGoogleType.white_small);
            GMapMarker konum_marker2 = new GMarkerGoogle(konum2, GMarkerGoogleType.white_small);
            GMapMarker konum_marker3 = new GMarkerGoogle(konum3, GMarkerGoogleType.white_small);
            GMapMarker konum_marker4 = new GMarkerGoogle(konum4, GMarkerGoogleType.white_small);
            GMapMarker konum_marker5 = new GMarkerGoogle(konum5, GMarkerGoogleType.white_small);
            GMapMarker konum_marker6 = new GMarkerGoogle(konum6, GMarkerGoogleType.white_small);
            GMapMarker konum_marker7 = new GMarkerGoogle(konum7, GMarkerGoogleType.white_small);
            GMapMarker konum_marker8 = new GMarkerGoogle(konum8, GMarkerGoogleType.white_small);
            GMapMarker konum_marker9 = new GMarkerGoogle(konum9, GMarkerGoogleType.white_small);
            GMapOverlay konumlar_markers = new GMapOverlay("direkler_markers");
            konumlar_markers.Markers.Add(konum_marker1);
            konumlar_markers.Markers.Add(konum_marker2);
            konumlar_markers.Markers.Add(konum_marker3);
            konumlar_markers.Markers.Add(konum_marker4);
            konumlar_markers.Markers.Add(konum_marker5);
            konumlar_markers.Markers.Add(konum_marker6);
            konumlar_markers.Markers.Add(konum_marker7);
            konumlar_markers.Markers.Add(konum_marker8);
            konumlar_markers.Markers.Add(konum_marker9);
            gMap.Overlays.Add(konumlar_markers);
        }
           




        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            try
            {
                if (e.Button == MouseButtons.Left) //Sadece sol tıkla konum seçebilmek için. 
                {
                    PointLatLng p = this.gMap.FromLocalToLatLng(e.X, e.Y);
                    //Convert mouse click point coordinates to latitude and longitude coordinates
                    PointLatLng direkler = this.gMap.FromLocalToLatLng(e.X, e.Y);//Convert mouse click point coordinates to latitude and longitude coordinates
                    GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.arrow); /*GMarkerGoogleType.yellow_pushpin*/ //Bitmap(@"icons\drone_40px_beyaz.png"
                     //Bitmap(@"icons\drone_40px_beyaz.png"
                    marker.ToolTipText = gMap.FromLocalToLatLng(e.X, e.Y).ToString();
                    this.overlay.Markers.Add(marker);
                    overlay.Routes.Clear();
                    list.Add(p);
                    p.Lat.ToString().Replace(',', ' ');
                    StringData.Add(p.Lat.ToString().Substring(0, 10).Replace(",",string.Empty)+p.Lng.ToString().Substring(0, 10).Replace(",",string.Empty));    //Verileri String'e döndürme işlemi (Drone Haberleşirken Kullanılacak)
                    GMapRoute route = new GMapRoute(list, "line");
                    route.Stroke.Color = Color.Red;
                    route.Stroke.Width = 2; //Set the painting
                    overlay.Routes.Add(route);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Rota Oluşturulamadı");
            }

        }

        private void BtnRouteClearClick(object sender, EventArgs e)
        {
           
            ClearDataList();
        }

        //private void PolygonCreate(object sender, EventArgs e)
        //{
        //    GMapOverlay polygons = new GMapOverlay("polygons");
        //    List<PointLatLng> points = new List<PointLatLng>();
        //    points.Add(new PointLatLng(41.866383,28.323575));
        //    points.Add(new PointLatLng(41.863868,28.321554));
        //    points.Add(new PointLatLng(41.861017,28.330030));
        //    points.Add(new PointLatLng(41.863727,28.331918));
        //    GMapPolygon polygon = new GMapPolygon(points, "Jardin des Tuileries");
        //    polygons.Polygons.Add(polygon);
        //    gMap.Overlays.Add(polygons);
        //} // İhtiyaca göre Rota çizdirmek için kullanılabilir

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ClearDataList();
        }

        private void ConvertByte(List<string>StringData)
        {
            for(int i=0;i<StringData.Count();i++)
            {
                Convert.ToByte(StringData[i]);
            }
        }
        private void ConvertInt(List<string>StringData)
        {
            
            for(int i=0;i<StringData.Count();i++)
            {
                IntData[i] = Convert.ToInt32(StringData[i]);
               
            }
        }
        
      private void PoligonOlustur()
        {
            GMapOverlay polygons = new GMapOverlay("polygons");
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(new PointLatLng(40.2308389, 29.0085271));
            points.Add(new PointLatLng(40.2308607, 29.0098506));
            points.Add(new PointLatLng(40.2293656, 29.0099020));
            points.Add(new PointLatLng(40.2293535, 29.0085305));
            GMapPolygon polygon = new GMapPolygon(points, "Jardin des Tuileries");
            polygons.Polygons.Add(polygon); 
            gMap.Overlays.Add(polygons);
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
        }
        private void SendTask(int id)
        {
            if (id==1)
            { 
               
                try
                {
                    for (int i = 0; i < StringData.Count; i++)
                    {
                        string message = "1" + (i + 1).ToString("00") + StringData[i];
                        //SendingData = System.Text.Encoding.ASCII.GetBytes(message);
                        // SendingData[i] = Convert.ToByte("0" + (i + 1).ToString() + StringData[i]);
                        NetworkStream stream = Client().GetStream();
                        SendingData = System.Text.Encoding.ASCII.GetBytes(message);
                        stream.Write(SendingData, 0, SendingData.Length);
                        //stream.Close();
                    }

                   

                }
                catch (Exception)
                {
                    MessageBox.Show("Drone Haberleşmeyi Durdurdu");
                }

            }
            ////********************* Diğer gönderilecek datalar alanı************************

            
                
        }
        

        private void BtnRouteSend_Click(object sender, EventArgs e)
        {
          
            SendTask(1);
       
        }

        public void DataGonder(string message)
        {
           
            try
            {
                
                NetworkStream stream = Client().GetStream();  
                SendingData = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(SendingData, 0, SendingData.Length);
                stream.Close();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Drone Haberleşmeyi Durdurdu");
            }
        }
        private void send_data(string message)
        {

            try
            {

                NetworkStream stream = Client().GetStream();
                SendingData = System.Text.Encoding.ASCII.GetBytes(message);
                stream.Write(SendingData, 0, SendingData.Length);
                stream.Write(SendingData, 0, SendingData.Length);
                stream.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Drone Haberleşmeyi Durdurdu");
            }

        }

        private void Harita_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Harita_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Harita_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHiz.Text = trackBar1.Value.ToString("00");
        }
    }
}
