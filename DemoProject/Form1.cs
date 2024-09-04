using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            txtAdSoyad.Text = "Lütfen AdSoyad Giriniz.";
        }

        private void btnDeneme1_Click(object sender, EventArgs e)
        {
            decimal indirimOrani = numDiscount.Value;
            MessageBox.Show($"{indirimOrani}");
            //DialogResult dg = MessageBox.Show($"{txtAdSoyad.Text}", "Bilgilendirme", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            //DemoIsSinifi demo = new DemoIsSinifi();
            //demo.DialogResultChoose(dg);

        }

        private void btnDeneme2_Click(object sender, EventArgs e)
        {
            //txtAdSoyad.Visible = false;
            //txtAdSoyad.Enabled = false;
            //btnDeneme1.Visible = false;
            //txtAdSoyad.Text = "Ben Çinden Geliyorum.";
            //if (chboxStatus.Checked)
            //{
            //    txtAdSoyad.BackColor = Color.Red;
            //}
            //else
            //{
            //    txtAdSoyad.BackColor= Color.Blue;
            //    txtAdSoyad.ForeColor = Color.White;
            //}
            numDiscount.Visible = true;
        }
    }
}
