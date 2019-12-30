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
                Bust = int.Parse(textBox_Bust.Text == "" ? "0" : textBox_Bust.Text),
                Waistline = int.Parse(textBox_Waistline.Text == "" ? "0" : textBox_Waistline.Text),
                Hip = int.Parse(textBox_Hip.Text == "" ? "0" : textBox_Hip.Text),
                OuterLength = int.Parse(textBox_OuterLength.Text == "" ? "0" : textBox_OuterLength.Text),
                InnerLength = int.Parse(textBox_InnerLength.Text == "" ? "0" : textBox_InnerLength.Text),
                SleeveLength = int.Parse(textBox_SleeveLength.Text == "" ? "0" : textBox_SleeveLength.Text),
                FullLength = int.Parse(textBox_FullLength.Text == "" ? "0" : textBox_FullLength.Text),
                BackWidth = int.Parse(textBox_BackWidth.Text == "" ? "0" : textBox_BackWidth.Text),
                ShoulderWidth = int.Parse(textBox_ShoulderWidth.Text == "" ? "0" : textBox_ShoulderWidth.Text),
                ThighCircumference = int.Parse(textBox_ThighCircumference.Text == "" ? "0" : textBox_ThighCircumference.Text),
                KneeCircumference = int.Parse(textBox_KneeCircumference.Text == "" ? "0" : textBox_KneeCircumference.Text),
                TrousersBottomCircumference = int.Parse(textBox_TrousersBottomCircumference.Text == "" ? "0" : textBox_TrousersBottomCircumference.Text),
                KneeHeight = int.Parse(textBox_KneeHeight.Text == "" ? "0" : textBox_KneeHeight.Text),
                AbdomenCircumference = int.Parse(textBox_AbdomenCircumference.Text == "" ? "0" : textBox_AbdomenCircumference.Text),
                WaistHeight = int.Parse(textBox_WaistHeight.Text == "" ? "0" : textBox_WaistHeight.Text),
                BodyHeight = int.Parse(textBox_BodyHeight.Text == "" ? "0" : textBox_BodyHeight.Text)
            };

            Main.customers.Add(customer);
            Main.Instance.RefreshList();
            Close();

        }
    }
}
