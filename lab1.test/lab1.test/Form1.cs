using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1.test
{
    public partial class Form1 : Form
    {
        private List<Product> products;
        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            products = new List<Product>
            {
                new Macbook13("Macbook Air 13 inch", 134990, "Description: Chip M2, 8C CPU/8C GPU, 2023, 8ГБ, 256ГБ SSD, сияющая звезда"),
                new Macbook14("Macbook Pro 14 inch", 269990, "Description: Chip M3 Pro 11C CPU, 14C GPU, 2023 18 ГБ, 512 ГБ SSD, чёрный космос"),
                new Macbook16("Macbook Pro 16 inch", 334990, "Description: Chip M3 Pro 12C CPU, 18C GPU, 2023 18 ГБ, 512 ГБ SSD, серебристый")
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product type = products[1];
            label2.Text = type.Description;
            label3.Text = type.Name;
            label4.Text = "Price: " + type.Price.ToString();
            picturePro14.Visible = true;
            pictureAir.Visible = false;
            picturePro16.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product type = products[2];
            label2.Text = type.Description;
            label3.Text = type.Name;
            label4.Text = "Price: " + type.Price.ToString();
            picturePro16.Visible = true;
            pictureAir.Visible = false;
            picturePro14.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product type = products[0];
            label2.Text = type.Description;
            label3.Text = type.Name;
            label4.Text = "Price: " + type.Price.ToString();
            pictureAir.Visible = true;
            picturePro14.Visible = false;
            picturePro16.Visible = false;
        }
    }
    public abstract class Product
    {
        public string Name { get; }
        public double Price { get; }
        public string Description { get; }
        public Product(string name, double price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }
    }
    public class Macbook13 : Product
    {
        public Macbook13(string name, double price, string description) : base(name, price, description) { }
    }
    public class Macbook14 : Product
    {
        public Macbook14(string name, double price, string description) : base(name, price, description) { }
    }
    public class Macbook16 : Product
    {
        public Macbook16(string name, double price, string description) : base(name, price, description) { }
    }
}
