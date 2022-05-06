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
    public partial class Form3 : Form
    {
        FileStream fs;
        public Form3()
        {
            InitializeComponent();
        }

        private void btncreatefolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\TestFolder";
                DirectoryInfo dir = new DirectoryInfo(path);

                if (dir.Exists)
                {
                    MessageBox.Show("Folder Already exits");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    dir.Create();

                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btncreatefile_Click(object sender, EventArgs e)
        {
            

            try
            {
                string path = @"D:\TestFolder\FirstFile.txt";
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    MessageBox.Show("File already exists");
                }
                else
                {
                    fi.Create();
                    MessageBox.Show("File created");
                }
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                string name = txtName.Text;
                string location = txtLocation.Text;
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
                bw.Close();
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

        private void btnfile_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtId.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtLocation.Text = br.ReadString();
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
    
    

