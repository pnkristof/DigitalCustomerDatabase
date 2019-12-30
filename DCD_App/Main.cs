using Logic;
using System;
using System.Windows.Forms;

namespace DCD_App
{
    public partial class Main : Form
    {

        public static Main Instance { get; set; }

        public static Customers customers;
        public static Customer SelectedCustomer;
        public Main()
        {
            InitializeComponent();
            customers = new Customers();
            SelectedCustomer = new Customer();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox compListView = ((ListBox)sender);

            if (compListView.SelectedIndices.Count > 0)
            {
                SelectedCustomer = compListView.SelectedItem as Customer;
                label_Name.Text = SelectedCustomer.Name;
                label_Address.Text = SelectedCustomer.Address;
                label_Phone.Text = SelectedCustomer.Phone;
                label_Email.Text = SelectedCustomer.Email;
            }

        }

        public void RefreshList()
        {
            listBox1.Items.Clear();
            
            foreach (var customer in Customers.CustomerList)
            {
                listBox1.Items.Add(customer);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataManager.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            RefreshList();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            customers.Remove(SelectedCustomer.Id);
            RefreshList();
        }
    }
}
