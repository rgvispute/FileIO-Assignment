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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Firstformproject
{
    public partial class Product : Form
    {
        FileStream fs;
        public Product()
        {
            InitializeComponent();
        }
        //Binary Write
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                prod.Id = Convert.ToInt32(txtid.Text);
                prod.Name = txtname.Text;
                prod.Catname = txtcategory.Text;
                prod.Price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"D:/TestFolder/Product",FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }



        }
        //Binary Read
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                fs = new FileStream(@"D:/TestFolder/Product", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product1)binary.Deserialize(fs);
                txtid.Text = prod.Id.ToString();
                txtname.Text = prod.Name;
                txtcategory.Text = prod.Catname;
                txtprice.Text = prod.Price.ToString();
                


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        //XML WRITE
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                prod.Id = Convert.ToInt32(txtid.Text);
                prod.Name = txtname.Text;
                prod.Catname = txtcategory.Text;
                prod.Price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"D:/TestFolder/Product", FileMode.Create, FileAccess.Write);
                XmlSerializer binary = new XmlSerializer(typeof(Product1));
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }


        }
        //XML Read
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                fs = new FileStream(@"D:/TestFolder/Product",FileMode.Open, FileAccess.Read);
                XmlSerializer binary = new XmlSerializer(typeof(Product1));
                prod = (Product1)binary.Deserialize(fs);
                txtid.Text = prod.Id.ToString();
                txtname.Text = prod.Name;
                txtcategory.Text = prod.Catname;
                txtprice.Text = prod.Price.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        //Soap Write
        private void button5_Click(object sender, EventArgs e)
        {
            try
            { 
            Product1 prod = new Product1();
            prod.Id = Convert.ToInt32(txtid.Text);
            prod.Name = txtname.Text;
            prod.Catname = txtcategory.Text;
            prod.Price=Convert.ToInt32(txtprice.Text);
           
            
                
                fs = new FileStream(@"D:/TestFolder/Product", FileMode.Create, FileAccess.Write);
                SoapFormatter binary = new SoapFormatter();
                binary.Serialize(fs, prod);
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                fs = new FileStream(@"D:/TestFolder/Product", FileMode.Open, FileAccess.Read);
                SoapFormatter binary = new SoapFormatter();
                prod = (Product1)binary.Deserialize(fs);
                txtid.Text = prod.Id.ToString();
                txtname.Text = prod.Name;
                txtcategory.Text =prod.Catname;
                txtprice.Text = prod.Price.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                prod.Id = Convert.ToInt32(txtid.Text);
                prod.Name = txtname.Text;
                prod.Catname = txtcategory.Text;
                prod.Price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"D:/TestFolder/Product", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, prod);
               
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Product1 prod = new Product1();
                fs = new FileStream(@"D:/TestFolder/Product", FileMode.Open, FileAccess.Read);
                
                prod = JsonSerializer.Deserialize<Product1>(fs);
                txtid.Text = prod.Id.ToString();
                txtname.Text = prod.Name;
                txtcategory.Text = prod.Catname;
                txtprice.Text = prod.Price.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
