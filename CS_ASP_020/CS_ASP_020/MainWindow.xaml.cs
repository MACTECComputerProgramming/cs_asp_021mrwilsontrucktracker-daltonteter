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

namespace CS_ASP_020
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Print Driver Ticket
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            driverLabel.Content = $"Driver Name: {driverTextBox.Text}";

            //Convert Text into Numbers

            double ss = double.Parse(socialTextBox.Text);

            //Print Numbers

            socialLabel.Content = string.Format("Social Security Number: {0:000-00-0000}", ss);

            double pn = double.Parse(phoneTextBox.Text);

            phoneLabel.Content = string.Format("Phone Number: {0:(000)000-0000}", pn);

            //Subtract the Miles

            int miles = Convert.ToInt32(endMilesTextBox.Text) - Convert.ToInt32(startMilesTextBox.Text);

            //Print Numbers

            totalMilesLabel.Content = $"Total Miles: {miles}";

            //Subtracts Days to Get Days Remaining

            int days = Convert.ToInt32((calendarReturn.SelectedDate.Value - calendarLeft.SelectedDate.Value).Days);

            tDOLabel.Content = $"Days Out:{days}";

            //Tells you if the load is refrigerated and needs more pay

            double pay = (fridgeCheck.IsChecked == true) ? miles * .37 : miles * .25;

            payDueLabel.Content = string.Format("Pay Due: {0:c}", pay);

            //Get Vacation

            int vac = days / 5;

            vacationDaysLabel.Content = $"Vacation Earned: {vac} Days";
        }
    }
}
