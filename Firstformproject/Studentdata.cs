using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Firstformproject
{
    public partial class Studentdata : Form
    {
        FileStream fs;
        public Studentdata()
        {
            InitializeComponent();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                int rollno = Convert.ToInt32(txtroll.Text);
                string stream = txtstream.Text;
                string city = txtcity.Text;
                float percentage = Convert.ToInt32(txtpercentage.Text);
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(name);
                bw.Write(rollno);
                bw.Write(stream);
                bw.Write(city);
                bw.Write(percentage);
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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtname.Text = br.ReadString();
                txtroll.Text = br.ReadInt32().ToString();
                txtstream.Text = br.ReadString();
                txtcity.Text = br.ReadString();
                txtpercentage.Text = br.ReadInt32().ToString();
                br.Close();
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
