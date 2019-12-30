using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCD_App
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Name = textBox1.Text,
                Address = textBox2.Text,
                Phone = textBox3.Text,
                Email = textBox4.Text,
                Bust = int.Parse(textBox5.Text == "" ? "0" : textBox5.Text)
            };

            Main.customers.Add(customer);
            Main.Instance.RefreshList();
            Close();

        }
    }
}
