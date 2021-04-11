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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private List<Car> GetCars()
        //{
        //    return new List<Car>
        //    {
        //        new Car
        //        {
        //            Model="Grand Cherokee",
        //            Vendor="Jeep",
        //            Year=2020
        //        },
        //        new Car
        //        {
        //            Model="CX-5",
        //            Vendor="Mazda",
        //            Year=2020
        //        },
        //         new Car
        //        {
        //            Model="Evolution IX",
        //            Vendor="Mitsubishi",
        //            Year=2009
        //        }
        //    };
        //}
        public MainWindow()
        {
            InitializeComponent();
            //listbox.ItemsSource = GetCars();
        }

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var item = combobox.SelectedItem as ComboBoxItem;
        //    var stackpanel = item.Content as StackPanel;
        //    foreach (var element in stackpanel.Children)
        //    {
        //        if(element is TextBlock tb)
        //        {
        //            MessageBox.Show(tb.Text);
        //        }
        //    }
        //}

        //private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //var car = listbox.SelectedItem as Car;
        //    //if (car != null)
        //    //{
        //    //    ModelTxtbl.Text = car.Model;
        //    //    VendorTxtbl.Text = car.Vendor;
        //    //    YearTxtbl.Text = car.Year.ToString();
        //    //}
        //    ModelTxtbl.Text = "Model:";
        //    VendorTxtbl.Text = "Vendor:";
        //    YearTxtbl.Text = "Year:";
        //    var carsObjects = listbox.SelectedItems;
        //    foreach (var item in carsObjects)
        //    {
        //        if(item is Car car)
        //        {
        //            ModelTxtbl.Text += car.Model + " ";                   
        //            VendorTxtbl.Text += car.Vendor + " ";                   
        //            YearTxtbl.Text += car.Year + " ";                   
        //        }
        //    }
        //}

        ////private void upBtn_Click(object sender, RoutedEventArgs e)
        ////{
        ////    if (prgbar.Value < prgbar.Maximum)
        ////    {
        ////        ++prgbar.Value;
        ////    }
        ////}

        ////private void downBtn_Click(object sender, RoutedEventArgs e)
        ////{
        ////    if (prgbar.Value > prgbar.Minimum)
        ////    {
        ////        --prgbar.Value;
        ////    }

        ////}

        ////private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        ////{
        ////    txtblock.Text = Convert.ToInt32(slider.Value).ToString();
        ////    txtblock2.Text = Convert.ToInt32(slider.Value).ToString();

        ////}
    }
}
