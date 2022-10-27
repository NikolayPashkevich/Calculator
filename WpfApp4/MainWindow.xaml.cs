using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (UIElement el in ha.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += ButtonClick;
                }

            }

        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string texbutton = ((Button)e.OriginalSource).Content.ToString();
                if (texbutton == "C")
                {
                    text.Content = "";

                }

                else if (texbutton == "=")
                {
                    text.Content = new DataTable().Compute(Convert.ToString(text.Content), null).ToString();

                }
                else if (texbutton == "√")
                {
                    double a =Convert.ToDouble( text.Content);
                    text.Content = Convert.ToString(Math.Sqrt(a));
                    
                }
                else text.Content += texbutton;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
