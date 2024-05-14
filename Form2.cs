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

namespace Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public static string users;
        private void btnNext_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;

            if (username == string.Empty)
            {
                MessageBox.Show("Please enter username!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                StreamWriter sw = File.CreateText(@"..\usernames.txt");
                try
                {
                    sw.Write(textBox1.Text);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sw.Close();
                }
            }

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
        }

        private void rbTTT_Click(object sender, EventArgs e)
        {
           
            string username = textBox1.Text;
            this.Hide();
            if (rbTTT.Checked)
            {
                if (username == string.Empty)
                {
                    MessageBox.Show("Please enter username!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form2 frm2 = new Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075.Form2();
                    frm2.Show();
                }
                else
                {
                    users = textBox1.Text;
                    TTT frm4 = new Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075.TTT();
                    frm4.Show();
                }

            }
        }

        private void rbRPS_CheckedChanged(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            this.Hide();
            if (rbRPS.Checked)
            {
                if (username == string.Empty)
                {
                    MessageBox.Show("Please enter username!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form2 frm2 = new Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075.Form2();
                    frm2.Show();
                }
                else
                {
                    users = textBox1.Text;
                    RPS frm3 = new Vesela_Apostolova_2101681070__Deyan_Guzelev_2101681075.RPS();
                    frm3.ShowDialog();
                   
                }
                
            }
           
        }
    }
}
