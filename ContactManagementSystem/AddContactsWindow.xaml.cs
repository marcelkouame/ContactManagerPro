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
using System.Windows.Forms;

namespace ContactManagementSystem
{
    /// <summary>
    /// Interaction logic for AddContactsWindow.xaml
    /// </summary>
    public partial class AddContactsWindow : Window
    {
        private Contact MyContact;
        public AddContactsWindow()
        {
            InitializeComponent();
            /*if (MyContact == null)
            {
                MyContact = new Contact();
            }*/
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

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            if ((FirstName.Text == "Enter First Name") && (LastName.Text == "Enter Last Name") && (Email.Text == "Enter E-Mail"))
            {
                System.Windows.Forms.MessageBox.Show("You must complete all fields marked with an asterisk '*'");
            }

            else if ((FirstName.Text == string.Empty) || (LastName.Text == string.Empty) || (Email.Text == string.Empty))
            {
                System.Windows.Forms.MessageBox.Show("You must complete all fields marked with an asterisk '*'");
            }
            else if ((FirstName.Text != "Enter First Name") && (LastName.Text != "Enter Last Name") && (Email.Text != "Enter E-Mail"))
            {
                if ((FirstName.Text != string.Empty) || (LastName.Text != string.Empty) || (Email.Text != string.Empty))
                {
                    Contact MyContact = new Contact()
                    {
                        FirstName = FirstName.Text,
                        LastName = LastName.Text,
                        Title = Title.Text,
                        Company = Company.Text,
                        Email = Email.Text,
                        Telephone = Telephone.Text
                    };

                    ProcessContactBL newProcessContactBL = new ProcessContactBL();
                    newProcessContactBL.ProcessInsertContact(MyContact);
                    /*System.Windows.Forms.MessageBox.Show("Contact Successfully Saved. If you Would like to view all contacts click 'View' below. Otherwise, click 'Ok'");*/
                    saveDataMessageBox();
                    ResetFormData();
                }
            }
        }

        private void saveDataMessageBox()
        {
            DialogResult saveDataMessageBoxResult =
                System.Windows.Forms.MessageBox.Show
                ("Contact Successfully Saved. If you Would like to View All Contacts click 'Yes'. Otherwise, click 'No'", 
                "Contact Data Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(saveDataMessageBoxResult == System.Windows.Forms.DialogResult.Yes)
                {
                    var newWindow = new ViewAllContactsWindow();
                    newWindow.Show();
                }
                else
                {
                    this.Show();
                }
        }

        private List<Contact> UpdateGrid()
        {
            ProcessContactBL newContactBL = new ProcessContactBL();
            List<Contact> newContactList = new List<Contact>();
            return newContactList;
        }


        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            ResetFormData();

        }

        private void ResetFormData()
        {
            FirstName.Text = "Enter First Name";
            LastName.Text = "Enter Last Name";
            Title.Text = "Enter Job Title";
            Company.Text = "Enter Company Name";
            Email.Text = "Enter Email";
            Telephone.Text = "Enter Number ex: 646-123-4567";
        }

        private void FirstName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FirstName.Text = string.Empty;
        }

        private void LastName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            LastName.Text = string.Empty;
        }

        private void Title_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Title.Text = string.Empty;
        }

        private void Company_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Company.Text = string.Empty;
        }

        private void Email_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Email.Text = string.Empty;
        }

        private void Telephone_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Telephone.Text = string.Empty;
        }

    }
}

