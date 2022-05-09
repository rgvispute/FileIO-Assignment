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
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
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
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Department)binary.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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

        
        //XML Write
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
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
        //soap write
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                SoapFormatter binary = new SoapFormatter();
                binary.Serialize(fs, dept);
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
        //soap read
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Open, FileAccess.Read);
                SoapFormatter binary = new SoapFormatter();
                dept = (Department)binary.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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
        //XML Read
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\DeptXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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
        //Json write
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.Id = Convert.ToInt32(txtId.Text);
                dept.Name = txtName.Text;
                dept.Location = txtLocation.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Create, FileAccess.Write);
                 JsonSerializer.Serialize(fs,dept);
               
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
        //Json Read
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"D:\TestFolder\Dept", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Department>(fs);
                
                txtId.Text = dept.Id.ToString();
                txtName.Text = dept.Name;
                txtLocation.Text = dept.Location;
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

        
    
    


    
    

