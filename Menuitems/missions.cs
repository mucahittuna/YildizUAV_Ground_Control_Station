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

namespace UI_Prototype_1.Menuitems
{
    public partial class missions : UserControl
    {
        #region Variables&References
        public string IpNum;
        public int portNum;
        public GMapOverlay overlay = new GMapOverlay("Marker");
        List<PointLatLng> list = new List<PointLatLng>();  // Harita üzerinden işaretlenen koordinatlar burada listede tutulup rota oluşturulmaktadır.
        List<string> StringData = new List<string>(); //Drone'a gönderilecek data..
        Byte[] SendingData = new Byte[256];
        #endregion


        #region LoadEvents
        public missions()
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
            this.gMap.ShowCenter = false; //Do not display the center cross point
            this.gMap.DragButton = System.Windows.Forms.MouseButtons.Middle;//Left and drag the map
            this.gMap.Position = new PointLatLng(23, 113);
            ConvertLat(txtLattitude.Text);
            ConvertLongt(txtLongtitude.Text);
            gMap.Position = new GMap.NET.PointLatLng(ConvertLat(txtLattitude.Text), ConvertLongt(txtLongtitude.Text));

        }

        public TcpClient Client()
        {
            TcpClient client = new TcpClient(IpNum, portNum);

            return client;
        }

        private void btnLoad_Click(object sender, EventArgs e )
        {
            ConvertLat(txtLattitude.Text);
            ConvertLongt(txtLongtitude.Text);
            gMap.Position = new GMap.NET.PointLatLng(ConvertLat(txtLattitude.Text), ConvertLongt(txtLongtitude.Text));
           
        }

        #endregion


        #region Methods

        public void DataGonder(string message)  // Data gönderme methodu
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

        private double ConvertLat(string Lat) //Enlemi stringe çevirir
        {
            
                return Convert.ToDouble(txtLattitude.Text);
                
        } 
        private double ConvertLongt(string longt) //Boylamı stringe çevirir
        {
                
            return Convert.ToDouble(txtLongtitude.Text);
           

        }

        private void ClearDataList() // Çizdirilen rotayı sıfırlar
        {
            list.Clear();
            overlay.Clear();

        }
        #endregion


        #region MouseEvents

        private void gMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            try
            {
                if(e.Button==MouseButtons.Right)
                {
                    list.RemoveAt(list.Count - 1);
                    
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Rota Oluşturulamadı");
            }

        }  //Double Click yapılınca listeden son elemanını siler.

        private void gMap_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;

            try
            {
                if(e.Button==MouseButtons.Left) //Sadece sol tıkla konum seçebilmek için. 
                {
                    PointLatLng p = this.gMap.FromLocalToLatLng(e.X, e.Y);//Convert mouse click point coordinates to latitude and longitude coordinates
                    GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.arrow); /*GMarkerGoogleType.yellow_pushpin*/ //Bitmap(@"icons\drone_40px_beyaz.png"
                    marker.ToolTipText = gMap.FromLocalToLatLng(e.X, e.Y).ToString();
                    this.overlay.Markers.Add(marker); 
                    overlay.Routes.Clear();
                    
                    list.Add(p);
                   // StringData.Add(p.Lat.ToString() + "," + p.Lng.ToString());   //Verileri String'e döndürme işlemi (Drone Haberleşirken Kullanılacak)
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

        } // haritadan konum işaretler

        private void BtnRouteClearClick(object sender, EventArgs e)
        {
            ClearDataList();
        }  // çizilen rotayı siler

        private void PolygonCreate(object sender, EventArgs e)
        {
            GMapPolygon polygon = new GMapPolygon(list, "polygon");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));

            polygon.Stroke = new Pen(Color.Blue, 2);
            polygon.IsHitTestVisible = true;
            overlay.Polygons.Add(polygon);
        } // İhtiyaca göre Rota çizdirmek için kullanılabilir

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            Harita harita = new Harita(form.getIpNum(), form.getPortNum());
            harita.Show();
        } // Büyük Haritayı açar

        private void BtnRouteSend_Click(object sender, EventArgs e) //Datayı dronea gönderir
        {
            DataGonder(string.Join("||", StringData));
        }

        #endregion


    }
}
