using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firstformproject
{
    
    public partial class Batch : Form
    {
        FileStream fs;
        public Batch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Batch1 bat = new Batch1();
                bat.Id = Convert.ToInt32(txtid.Text);
                bat.Name = txtname.Text;
                bat.Startd = Convert.ToInt32(txtsdate.Text);
                bat.Endd = Convert.ToInt32(txtedate.Text);
                bat.Location = txtlocation.Text;
                bat.Tname = txttname.Text;
                fs = new FileStream(@"D:\TestFolder\Batch", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, bat);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Batch1 bat = new Batch1();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Batch", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                bat = (Batch1)binary.Deserialize(fs);
                txtid.Text = bat.Id.ToString();
                txtname.Text = bat.Name;
                txtsdate.Text = bat.Startd.ToString();
                txtedate.Text = bat.Endd.ToString();
                txtlocation.Text = bat.Location;
                txttname.Text = bat.Tname;

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
    }
}
