using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace UI_Prototype_1
{
    /// <summary>
    /// Interaction logic for BatteryStatus.xaml
    /// </summary>
    public partial class BatteryStatus : UserControl
    {
        

        public BatteryStatus()
        {
            InitializeComponent();
           
            
        }
        public void ChangeValue(double value)
        {
          

                GridLengthConverter gridLengthConverter = new GridLengthConverter();
                status.Height = (GridLength)gridLengthConverter.ConvertFrom(value);

                if (value <= 50 && value >= 20)
                {
                    StatusBorder.Background = System.Windows.Media.Brushes.Yellow;
                }
                else if (value <= 25)
                {
                    StatusBorder.Background = System.Windows.Media.Brushes.Red;
                }
                else
                    StatusBorder.Background = System.Windows.Media.Brushes.Green;
           

        }
    }
}
