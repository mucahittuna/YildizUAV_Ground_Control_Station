using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using UI_Prototype_1.Menuitems;
using System.Runtime.InteropServices;
using System.Net.Sockets;
using System.Threading;
using MetroFramework;
using System.Xaml;
using System.IO;
using System.Reflection;
using System.Net.Mail;

namespace UI_Prototype_1
{
    public partial class Form1 : Form
    {
        #region DragDll's


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public static string ipNum;
        public static int portNum;
        bool iscollapse = false;
        homePage home_page = new homePage();
        aboutUs about_us = new aboutUs();
        missions missions = new missions();
        settings Settings = new settings();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
           
        }
        #region GETTER

        public string getIpNum()
        {

            //return txtHost.Text.ToString();
            // 192.168.56.1
            return "192.168.43.217";
            //192.168.43.217
        }
        public int getPortNum()
        {
            
         //return Convert.ToInt32(txtPort.Text);
         return 8080;
        } 
        #endregion

        
        
        #region menubar
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if (iscollapse == false)
            {
                bunifuGradientPanel2.Width = 70;
                iscollapse = true;
            }
            else
            {
                bunifuGradientPanel2.Width = 300;
                iscollapse = false;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            //bunifuGradientPanel3.Controls.Remove(home_page);
            //bunifuGradientPanel3.Controls.Remove(missions);
            //bunifuGradientPanel3.Controls.Remove(about_us);
            //bunifuGradientPanel3.Controls.Remove(Settings);

        }
        private void btnMissions_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
           
            bunifuGradientPanel3.Controls.Add(missions);
            bunifuGradientPanel3.Controls.Remove(home_page);
            bunifuGradientPanel3.Controls.Remove(about_us);
            bunifuGradientPanel3.Controls.Remove(Settings);
        }

        public void btnSettings_Click(object sender, EventArgs e)
        {
            //settings settings = new settings();
            //bunifuGradientPanel3.Controls.Add(Settings);
            //bunifuGradientPanel3.Controls.Remove(home_page);
            //bunifuGradientPanel3.Controls.Remove(missions);
            //bunifuGradientPanel3.Controls.Remove(about_us);
           

            //Ayarlar settings = new Ayarlar(getIpNum(), getPortNum());
            //Control.CheckForIllegalCrossThreadCalls = false;
            //Thread thread;
            //thread = new Thread(new ThreadStart(settings.dataoku));
            //thread.Start();
            //settings.Show();
            Gostergeler gostergeler = new Gostergeler(getIpNum(),getPortNum());
            gostergeler.Show();



        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
           
            //bunifuGradientPanel3.Controls.Add(about_us);
            //bunifuGradientPanel3.Controls.Remove(home_page);
            //bunifuGradientPanel3.Controls.Remove(missions);
            //bunifuGradientPanel3.Controls.Remove(Settings);
        }


        #endregion
      
       
        private void btnConnect_Click(object sender, EventArgs e)
        {
           
            try
            {
               getIpNum();
               getPortNum();
               btnConnect.BackgroundImage = Image.FromFile(@"icons\connected_52px.png");
               lblStatus.Text = "Bağlandı - "+ getIpNum().ToString()+ " : "+ getPortNum().ToString();
            }
            catch (Exception)
            {
                lblStatus.Text = "Bağlantı Aranıyor...";
                MessageBox.Show("Bağlantı Sağlanamadı");
            }

        }

       
        double value = 100;
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (value > 0)
            {
                value = value - 10;
               
            }
            else
                value = 100;
            
        }

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.Size = new System.Drawing.Size(300, 90);
        }
    }

        
    }



    

