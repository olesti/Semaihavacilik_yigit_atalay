using System;
using System.Collections.Generic;
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

namespace Semaihavacılık_yigit_atalay
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        double act_x;
        double act_y;
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (combo_min.SelectedIndex >= 0)
            {

                txt_height_min.Text = combo_min.SelectedValue.ToString();
                txt_width_min.Text = combo_min.SelectedValue.ToString();
            }
            if (txt_height_max.Text != null)
            {
                sliderr_x.Minimum = int.Parse(txt_height_min.Text);
                sliderr_y.Minimum = int.Parse(txt_height_min.Text);
            }
        }

        private void combo_max_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combo_max.SelectedIndex >= 0)
            {

                txt_height_max.Text = combo_max.SelectedValue.ToString();
                txt_width_max.Text = combo_max.SelectedValue.ToString();
            }
            if (txt_height_max.Text != null)
            {
                sliderr_x.Maximum = int.Parse(txt_height_max.Text);
                sliderr_y.Maximum = int.Parse(txt_height_max.Text);
            }
        }

        private void sliderr_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
            x.Text = Convert.ToInt32(sliderr_x.Value).ToString();
            act_x =sliderr_x.Value / (sliderr_x.Maximum - sliderr_x.Minimum);
            //y_Copy1.Text = act_x.ToString();
            box.Width = act_x * 300;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //
            combo_min.Items.Add(0);
            combo_min.Items.Add(100);
            combo_min.Items.Add(300);
            combo_min.Items.Add(1000);
            //
            combo_max.Items.Add(100);
            combo_max.Items.Add(1000);
            combo_max.Items.Add(3000);
            combo_max.Items.Add(10000);
            //
            
            x.Text = Convert.ToInt32(sliderr_x.Value).ToString();
            y.Text = Convert.ToInt32(sliderr_y.Value).ToString();
        }

        private void sliderr_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            y.Text = Convert.ToInt32(sliderr_y.Value).ToString();
            act_y = sliderr_y.Value / (sliderr_y.Maximum - sliderr_y.Minimum);
            y_Copy.Text = act_y.ToString();
            box.Height = act_y * 300;
        }

        private void y_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (y.Text != "")
            {
                sliderr_y.Value = Convert.ToDouble(y.Text);

            }
        }

        private void x_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (x.Text != "")
            {
                sliderr_x.Value = Convert.ToDouble(x.Text);

            }
        }
    }
}

public class Comboitem
{
    public string Text { get; set; }
    public object Value { get; set; }

    public override string ToString()
    {
        return Text;
    }

}