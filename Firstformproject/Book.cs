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

namespace Firstformproject
{
    
    public partial class Book : Form
    {
        FileStream fs;
        public Book()
        {
            InitializeComponent();
        }
        //Binary Write
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               
                Book1 book = new Book1();
               book.Id = Convert.ToInt32(txtid.Text);
                book.Name = txtname.Text;
                book.Authorname =txtaname.Text;
                book.Price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"D:\TestFolder\Book", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
                MessageBox.Show("Done");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                Book1 book = new Book1();
                fs = new FileStream(@"D:/TestFolder/Book", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                book = (Book1)binary.Deserialize(fs);
                txtid.Text = book.Id.ToString();
                txtname.Text = book.Name;
                txtaname.Text = book.Authorname;
                txtprice.Text = book.Price.ToString();
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
        //Soap Write
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 book = new Book1();
                book.Id = Convert.ToInt32(txtid.Text);
                book.Name = txtname.Text;
                book.Authorname = txtaname.Text;
                book.Price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"D:/TestFolder/Book", FileMode.Create, FileAccess.Write);
                SoapFormatter binary = new SoapFormatter();
                binary.Serialize(fs, book);
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
        //Soap read
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 book = new Book1();
                fs = new FileStream(@"D:/TestFolder/Book", FileMode.Open, FileAccess.Read);
                SoapFormatter binary = new SoapFormatter();
                book = (Book1)binary.Deserialize(fs);
                txtid.Text = book.Id.ToString();
                txtname.Text = book.Name;
                txtaname.Text = book.Authorname;
                txtprice.Text = book.Price.ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine( ex.Message);
            }
            finally
            {
                fs.Close();
            }

        }
        //XML write
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 book = new Book1();
                book.Id = Convert.ToInt32(txtid.Text);
                book.Name = txtaname.Text;
                book.Authorname = txtaname.Text;
                book.Price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"D:/TestFolder/Book", FileMode.Create, FileAccess.Write);
                XmlSerializer binary = new XmlSerializer(typeof(Book1));
                binary.Serialize(fs, book);
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
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 book = new Book1();
                fs = new FileStream(@"D:/TestFolder/Book", FileMode.Open, FileAccess.Read);
                XmlSerializer binary = new XmlSerializer(typeof(Book1));
                book = (Book1)binary.Deserialize(fs);
                txtid.Text = book.Id.ToString();
                txtname.Text = book.Name;
                txtaname.Text = book.Authorname;
                txtprice.Text = book.Price.ToString();
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
        //Json Write
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                Book1 book = new Book1();
                book.Id = Convert.ToInt32(txtid.Text);
                book.Name = txtname.Text;
                book.Authorname = txtaname.Text;
                book.Price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"D:/TestFolder/Book", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
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
        //JSon Read
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Book1 book = new Book1();
                fs = new FileStream(@"D:/TestFolder/Book", FileMode.Open, FileAccess.Read);
                book = JsonSerializer.Deserialize<Book1>(fs);
                txtid.Text = book.Id.ToString();
                txtname.Text = book.Name;
                txtaname.Text = book.Authorname;
                txtprice.Text = book.Price.ToString();
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
    }
}
