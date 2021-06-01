using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibilityPrinciple
{
    //FORM: Kullanıcıyı karşıla
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             *  Bir nesne, sadece bir iş yapıyor olmalı.
             *  Bir nesne içinde değişiklik yapmak için BİRDEN FAZLA SEBEBİNİZ VARSA prensibe UYMUYORSUNUZ demektir!
             */

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string productName = textBoxName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            ProductBusiness productBusiness = new ProductBusiness();
            int result = productBusiness.AddProduct(productName,price);
            string message = result > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
        }

        
    }
}
