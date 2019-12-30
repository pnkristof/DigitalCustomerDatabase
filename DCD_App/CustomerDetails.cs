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
    public partial class CustomerDetails : Form
    {
        public CustomerDetails(Customer customer)
        {
            InitializeComponent();
            FillDetails(customer);
        }

        public void FillDetails(Customer customer)
        {
            label_Name.Text = customer.Name.ToString();
            label_Address.Text = customer.Address.ToString();
            label_Phone.Text = customer.Phone.ToString();
            label_Email.Text = customer.Email.ToString();

            label_Bust.Text = customer.Bust.ToString();
            label_Waistline.Text = customer.Waistline.ToString();
            label_Hip.Text = customer.Hip.ToString();
            label_OuterLength.Text = customer.OuterLength.ToString();
            label_InnerLength.Text = customer.InnerLength.ToString();
            label_SleeveLength.Text = customer.SleeveLength.ToString();
            label_FullLength.Text = customer.FullLength.ToString();
            label_ShoulderWidth.Text = customer.ShoulderWidth.ToString();
            label_BackWidth.Text = customer.BackWidth.ToString();
            label_ThighCircumference.Text = customer.ThighCircumference.ToString();
            label_KneeCircumference.Text = customer.KneeCircumference.ToString();
            label_TrousersBottomCircumference.Text = customer.TrousersBottomCircumference.ToString();
            label_KneeHeight.Text = customer.KneeHeight.ToString();
            label_AbdomenCircumference.Text = customer.AbdomenCircumference.ToString();
            label_WaistHeight.Text = customer.WaistHeight.ToString();
            label_BodyHeight.Text = customer.BodyHeight.ToString();
        }
    }
}
