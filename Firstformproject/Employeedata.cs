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
    public partial class Employeedata : Form

    {
        FileStream fs;
        public Employeedata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtname.Text;
                int id = Convert.ToInt32(txtid.Text);
                int salary = Convert.ToInt32(txtsalary.Text);
                string department = txtdept.Text;
                string degination = txtdegi.Text;
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(name);
                bw.Write(id);
                bw.Write(salary);
                bw.Write(department);
                bw.Write(degination);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtname.Text = br.ReadString();
                txtid.Text = br.ReadInt32().ToString();
                txtsalary.Text = br.ReadInt32().ToString();
                txtdept.Text = br.ReadString();
                txtdegi.Text = br.ReadString();
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
