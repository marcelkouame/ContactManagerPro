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
using ContactManagementSystemBL;
using ContactManagementSystemEntities;

namespace ContactManagementSystem
{
    /// <summary>
    /// Interaction logic for ViewAllContactsWindow.xaml
    /// </summary>
    public partial class ViewAllContactsWindow : Window
    {
        public ViewAllContactsWindow()
        {
            InitializeComponent();
            InitializeState();
        }
        
        private void InitializeState()
        {
            List<Contact> newContactList = new List<Contact>();
            Contact newContact = new Contact();
            ViewAllContactsGridUpdate();
        }

        private List<Contact> UpdateGrid()
        {
            ProcessContactBL newContactBL = new ProcessContactBL();
            List<Contact> newContactsList = new List<Contact>();
            newContactsList = newContactBL.GetAllContacts();
            return newContactsList;
        }

        public void ViewAllContactsGridUpdate()
        {
            ViewAllContactsGrid.DataContext = UpdateGrid();
        }

        //Menu Controls

        //File > View All Contacts
        private void View_All_Contacts_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new ViewAllContactsWindow();
            newWindow.Show();
        }

        //File > Add New Contact
        private void Add_New_Contact_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new AddContactsWindow();
            newWindow.Show();
        }

        //About > About Contact Manager
        private void About_Contact_Manager_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var newWindow = new About();
            newWindow.Show();
        }
    }
}
