using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace k_mean
{
    public partial class tambahData : Form
    {
        private Form1 main;
        public tambahData(Form1 main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void tambahData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.main.setKolom(Convert.ToInt32(tb_kolom.Text));
                this.main.setCluster(Convert.ToInt32(tb_cluster.Text));
                this.main.setTabel();
                this.Dispose();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Input harus angka valid");
            }
            
        }
    }
}
