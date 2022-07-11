using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

namespace SampleWinForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent(); 
        }

        private void btn_binary_wr_Click(object sender, EventArgs e)
        {
            try
            {

                Product p1 = new Product();
                p1.id = Convert.ToInt32(txt_product_id.Text);
                p1.name = txt_product_name.Text;
                p1.price = Convert.ToInt32(txt_product_price.Text);

                FileStream fs = new FileStream("d:\\product", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, p1);
                fs.Close();
                MessageBox.Show("Hurrayyyyy!!!!   Binary Write Completed");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_binary_rd_Click(object sender, EventArgs e)
        {
            Product prod=new Product();
            FileStream fs = new FileStream("d:\\product", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            prod=(Product)bf.Deserialize(fs);
            txt_product_id.Text = prod.id.ToString();
            txt_product_name.Text = prod.name;
            txt_product_price.Text = prod.price.ToString();
            fs.Close ();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_product_id.Clear();
            txt_product_name.Clear();
            txt_product_price.Clear();
        }

        private void btn_xml_wr_Click(object sender, EventArgs e)
        {
            try
            {

                Product p1 = new Product();
                p1.id = Convert.ToInt32(txt_product_id.Text);
                p1.name = txt_product_name.Text;
                p1.price = Convert.ToInt32(txt_product_price.Text);

                FileStream fs = new FileStream("d:\\productxml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs=new XmlSerializer(typeof(Product));
                
                xs.Serialize(fs, p1);
                fs.Close();
                MessageBox.Show("Hurrayyyyy!!!!   XML Write Completed");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_xml_rd_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            FileStream fs = new FileStream("d:\\productxml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs=new XmlSerializer (typeof(Product));

            prod = (Product)xs.Deserialize(fs);
            txt_product_id.Text = prod.id.ToString();
            txt_product_name.Text = prod.name;
            txt_product_price.Text = prod.price.ToString();
            fs.Close();
        }

        private void btn_soap_wr_Click(object sender, EventArgs e)
        {
            try
            {

                Product p1 = new Product();
                p1.id = Convert.ToInt32(txt_product_id.Text);
                p1.name = txt_product_name.Text;
                p1.price = Convert.ToInt32(txt_product_price.Text);

                FileStream fs = new FileStream("d:\\productsoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf=new SoapFormatter();

                sf.Serialize(fs, p1);
                fs.Close();
                MessageBox.Show("Hurrayyyyy!!!!   SOAP Write Completed");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_soap_rd_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            FileStream fs = new FileStream("d:\\productsoap", FileMode.Open, FileAccess.Read);
            SoapFormatter sf= new SoapFormatter();

            prod = (Product)sf.Deserialize(fs);
            txt_product_id.Text = prod.id.ToString();
            txt_product_name.Text = prod.name;
            txt_product_price.Text = prod.price.ToString();
            fs.Close();
        }

        private void btn_json_wr_Click(object sender, EventArgs e)
        {
            try
            {

                Product p1 = new Product();
                p1.id = Convert.ToInt32(txt_product_id.Text);
                p1.name = txt_product_name.Text;
                p1.price = Convert.ToInt32(txt_product_price.Text);

                FileStream fs = new FileStream("d:\\productjson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs,p1);

                fs.Close();
                MessageBox.Show("Hurrayyyyy!!!!  JSON Write Completed");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btn_json_rd_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            FileStream fs = new FileStream("d:\\productjson", FileMode.Open, FileAccess.Read);
            SoapFormatter sf = new SoapFormatter();

            prod = JsonSerializer.Deserialize<Product>(fs);
            txt_product_id.Text = prod.id.ToString();
            txt_product_name.Text = prod.name;
            txt_product_price.Text = prod.price.ToString();
            fs.Close();
        }
    }
    
}
