using lab1.Domain;
using lab1.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab1.Form1;


namespace lab1
{
    public partial class Form1 : Form
    {
        private string MacType;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MacType = "1";
            IStoreFactory factory = GetFactory(MacType);
            IStore mac = factory.GetMac();
            label2.Text = mac.Description;
            label3.Text = mac.Name;
            label4.Text = "Price: " + mac.GetPrice().ToString();
            pictureAir.Visible = true;
            picturePro14.Visible = false;
            picturePro16.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MacType = "2";
            IStoreFactory factory = GetFactory(MacType);
            IStore mac = factory.GetMac();
            label3.Text = mac.Name;
            label2.Text = mac.Description;
            label4.Text = "Price: " + mac.GetPrice().ToString();
            picturePro14.Visible = true;
            pictureAir.Visible = false;
            picturePro16.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MacType = "3";
            IStoreFactory factory = GetFactory(MacType);
            IStore mac = factory.GetMac();
            label3.Text = mac.Name;
            label4.Text = "Price: " + mac.GetPrice().ToString();
            label2.Text = mac.Description;
            picturePro16.Visible = true;
            pictureAir.Visible = false;
            picturePro14.Visible = false;
        }

        private static IStoreFactory GetFactory(string MacType)
        {
            switch (MacType)
            {
                case "1":
                    return new MacbookAir13Factory(134990, "Description: Chip M2, 8C CPU/8C GPU, 2023, 8ГБ, 256ГБ SSD, сияющая звезда");
                case "2":
                    return new MacbookPro14Factory(269990, "Description: Chip M3 Pro 11C CPU, 14C GPU, 2023 18 ГБ, 512 ГБ SSD, чёрный космос");
                case "3":
                    return new MacbookPro16Factory(334990, "Description: Chip M3 Pro 12C CPU, 18C GPU, 2023 18 ГБ, 512 ГБ SSD, серебристый");
                default:
                    throw new ArgumentException("Invalid MacType");
            }
        }
    }
}


