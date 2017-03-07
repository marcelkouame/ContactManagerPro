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
using ContactManagementSystem.Entities;

namespace ContactManagementSystem
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

        //Menu Items
        //View All Contacts Menu Item
        private void View_All_Contacts_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new ViewAllContactsWindow();
            newWindow.Show();
        }

        //Add New Contacts Menu Item
        private void Add_New_Contact_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new AddContactsWindow();
            newWindow.Show();
        }

        private void About_Contact_Manager_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new About();
            newWindow.Show();
        }

        //Main Page Buttons
        //View Contacts Button
        private void View_Contacts_Button_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new ViewAllContactsWindow();
            newWindow.Show();
        }

        //Add Contacts Button
        private void Add_Contact_Button_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new AddContactsWindow();
            newWindow.Show();
        }
    }
}
