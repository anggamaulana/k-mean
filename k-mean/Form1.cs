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
    public partial class Form1 : Form
    {

        private OpenFileDialog fd;
        private tambahData td;
        private Cluster cl;
        private int kolomTabel;
        private int clusterTabel;
        private kmeans km;
        private double[,] data;
        private int[] init;
        private String TabelExcel;
        private String path;
        private System.Data.OleDb.OleDbConnection con;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            this.fd = new OpenFileDialog();

            this.fd.Filter = "Excel 2003 (*.xls)|*.xls";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                String path = fd.FileName;
                lbl_file.Text = path;
                this.path = path;
                openCon(path);
                if (this.con.State == ConnectionState.Closed)
                {
                    this.con.Open();
                }
                PilihTabel pt = new PilihTabel(this.con,this);
                pt.ShowDialog();
            }



        }


        public void setTabelExcel(String tabel)
        {
            this.TabelExcel = tabel;
        }

        public void setTabelFromExcel()
        {
            dg_data.DataSource = null;
            DataTable dt = getDataTable(this.path, this.TabelExcel);

            this.kolomTabel = dt.Columns.Count;
            for (int i = 0; i < this.clusterTabel; i++)
            {
                dt.Columns.Add(new DataColumn("Cluster"+i,typeof(bool)));
            }
               
            dg_data.DataSource = dt;
        }

        private DataTable getDataTable(String path,String tabel)
        {

            openCon(path);
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
           
            
            System.Data.OleDb.OleDbDataAdapter q = new System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [" + tabel + "]", this.con);
            System.Data.DataSet ds = new System.Data.DataSet();          
            q.Fill(ds);
            return ds.Tables[0];
        }


        private void openCon(String path)
        {
            if(this.con==null)
                this.con = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + path + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
        }


        private void btn_manual_Click(object sender, EventArgs e)
        {
            td = new tambahData(this);
            td.ShowDialog();

        }

        public void setKolom(int kolom)
        {
            this.kolomTabel = kolom;
        }

        public void setCluster(int cluster)
        {
            this.clusterTabel = cluster;
        }

        public void setTabel()
        {

            this.dg_data.DataSource = null;
            DataTable dt = new DataTable();
            int index=0;
            for (int i = 1; i <= this.kolomTabel; i++)
            {                
                DataColumn cl =  new DataColumn("Feature" + i,typeof(double));                
                dt.Columns.Add(cl);
                dt.Columns["Feature" + i].SetOrdinal(index);
                index++;
            }

            for (int i = 1; i <= this.clusterTabel; i++)
            {
                DataColumn cl =  new DataColumn("Cluster" + i,typeof(bool));
               
                dt.Columns.Add(cl);
                dt.Columns["Cluster" + i].SetOrdinal(index);
                index++;
                
            }

           
             this.dg_data.DataSource = dt;
            
            

            
           
        }

        private void btn_cluster_Click(object sender, EventArgs e)
        {

            try
            {
                initData();

                double thres = 0.1;

                if (!this.tb_threshold.Text.Equals(""))
                    thres = Convert.ToDouble(tb_threshold.Text);

                km = new kmeans(this.clusterTabel, this.data, thres, this.init);
                this.km.proses();
                cl = new Cluster(this.km.getdataiterasi());
                cl.ShowDialog();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Input Data tidak valid");
            }
            catch (OverflowException OE)
            {
                MessageBox.Show("Input Data tidak valid");
            }
            catch (Exception E)
            {
                MessageBox.Show("Terjadi Kesalahan Pembacaan data "+E.Message);
            }

           
           
        }

        private void initData()
        {
            int baris = dg_data.Rows.Count-1;
            this.data = new double[baris,this.kolomTabel];
            this.init = new int[baris];
            
            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < this.kolomTabel; j++)
                {
                    this.data[i,j] = Convert.ToDouble(this.dg_data.Rows[i].Cells[j].Value);

                }
            }

            for (int i = 0; i < baris; i++)
            {
               int k =0;
                for (int j = this.kolomTabel; j < (this.kolomTabel+this.clusterTabel); j++)
                {

                    bool cek = false;
                    if (this.dg_data.Rows[i].Cells[j].Value!=DBNull.Value)
                    cek = Convert.ToBoolean(this.dg_data.Rows[i].Cells[j].Value);

                    if (cek == true)
                    {
                        this.init[i] = k;
                    }
                    k++;

                }
            }




        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("K-Means Algorithm : github.com/anggamaulana/k-mean");
        }
    }
}
