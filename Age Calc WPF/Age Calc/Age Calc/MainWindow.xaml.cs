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


namespace Age_Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow :Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Initialize the date as Today's Date
            datePick1.SelectedDate = DateTime.Today.Date;
            datePick2.SelectedDate = DateTime.Today.Date;
        }

        private void calcAge(object sender, RoutedEventArgs e)
        {
            try
            {
                string date1 = datePick1.SelectedDate.ToString();
                string date2 = datePick2.SelectedDate.ToString();

                CalcClass c = new CalcClass(date1, date2);

                string s = c.getAge();

                ageBox.Text = s;
            }

            catch (Exception x)
            {
                MessageBoxResult r = MessageBox.Show("Please select a date!!", "Attention!!!!");
            }
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Do you wish to quit?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }

            else
            {
                // do nothing
                // let the application carry on
            }
        }
    }
}
