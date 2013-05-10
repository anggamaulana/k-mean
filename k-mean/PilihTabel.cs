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
    public partial class PilihTabel : Form
    {
        private System.Data.OleDb.OleDbConnection con;
        private Form1 main;

        public PilihTabel(System.Data.OleDb.OleDbConnection con,Form1 main)
        {
            InitializeComponent();
            this.con = con;
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String tbl = lb_tabel.SelectedItem.ToString();
                this.main.setCluster(Convert.ToInt32(tb_cluster.Text));                
                this.main.setTabelExcel(tbl);
                this.main.setTabelFromExcel();
                this.Dispose();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Input angka harus valid");
            }
            catch (NullReferenceException ne)
            {
                MessageBox.Show("Anda Belum memilih");
            }
        }

        private void PilihTabel_Load(object sender, EventArgs e)
        {
            
            DataTable dt = this.con.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);

           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String tabel = dt.Rows[i]["TABLE_NAME"].ToString();

                lb_tabel.Items.Add(tabel);
                
            }

           
            
        }
    }
}
