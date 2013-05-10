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
            }



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


                km = new kmeans(this.clusterTabel, this.data, 0.1, this.init);
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
    }
}
