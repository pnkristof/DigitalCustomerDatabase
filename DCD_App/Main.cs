using Logic;
using System;
using System.Windows.Forms;

namespace DCD_App
{
    public partial class Main : Form
    {

        public static Main Instance { get; set; }

        public static Customers customers = new Customers();
        public Main()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.Show();

            //string name = textBox1.Text;
            //string address = textBox2.Text;
            //string phone = textBox3.Text;
            //string email = textBox4.Text;

            //Customer customer = new Customer
            //{
            //    Name = name,
            //    Address = address,
            //    Phone = phone,
            //    Email = email,
            //    Brust = 123
            //};

            //customers.Add(customer);
            //RefreshList();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox compListView = ((ListBox)sender);

            if (compListView.SelectedIndices.Count > 0)
            {
                var selectedCustomer = customers.getCustomerById(compListView.SelectedIndices[0]);
                label1.Text = selectedCustomer.Name;
                label2.Text = selectedCustomer.Address;
                label3.Text = selectedCustomer.Phone;
                label4.Text = selectedCustomer.Email;
            }

        }

        public void RefreshList()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < customers.getLength(); i++)
            {
                listBox1.Items.Add(customers.getCustomerById(i));
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
