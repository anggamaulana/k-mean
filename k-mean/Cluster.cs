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
    public partial class Cluster : Form
    {

        private DataIterasi[] di;
        private int Iterasi=0;

        public Cluster(DataIterasi[] di)
        {
            InitializeComponent();
            this.di = di;
        }



        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cluster_Load(object sender, EventArgs e)
        {

            populateTable(); 
            
           
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int max = this.di.GetLength(0);
            if (Iterasi < max-1)
            {
                Iterasi++;
                populateTable();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (Iterasi > 0)
            {
                Iterasi--;
                populateTable();
            }
        }

        private void populateTable()
        {
            DataTable dt = new DataTable();
            int kolom = this.di[Iterasi].data.GetLength(1);
            int baris = this.di[Iterasi].data.GetLength(0);

            for (int i = 0; i < kolom; i++)
            {
                dt.Columns.Add("Feature"+i);
            }
            for (int i = 0; i < this.di[Iterasi].cluster; i++)
            {
                dt.Columns.Add("Cluster" + i);
            }
            for (int i = 0; i < this.di[Iterasi].cluster; i++)
            {
                dt.Columns.Add("Jarak ke Cluster-" + i);
            }
            //-----------------------------------------------------------
            for (int i = 0; i < baris; i++)
            {
                Object[] obj = new Object[kolom + this.di[Iterasi].cluster*2];
                int k = 0;
                for (int j = 0; j < kolom; j++)
                {
                    obj[k] = this.di[Iterasi].data[i, j];
                    k++;
                }

                for (int l = 0; l < this.di[Iterasi].cluster; l++)
                {
                    if (this.di[Iterasi].fungsiKeanggotaan[i, l] == 1)
                        obj[k] = "*";
                    else
                        obj[k] = "";
                    k++;
                }

                for (int m = 0; m < this.di[Iterasi].cluster; m++)
                {
                    obj[k] = this.di[Iterasi].distance[i, m];
                    k++;
                }

                dt.Rows.Add(obj);

            }



            dg_cluster.DataSource = dt;

            lbl_iterasi.Text = Convert.ToString(this.Iterasi);
            String centroid = "";
            for (int i = 0; i < this.di[Iterasi].centroid.GetLength(0); i++)
            {
                centroid += "Cluster"+i+": {";
                for (int j = 0; j < this.di[Iterasi].centroid.GetLength(1); j++)
                {
                    centroid += this.di[Iterasi].centroid[i, j];
                    if (j < this.di[Iterasi].centroid.GetLength(1)-1)
                        centroid += ";";
                }
                centroid += "}  ";
            }

            lbl_centroid.Text = centroid;
            lbl_perpindahan.Text = Convert.ToString(this.di[Iterasi].pergantianCluster);
            lbl_subjektif.Text=Convert.ToString(this.di[Iterasi].fungsisubjektif);
            lb_delta.Text = Convert.ToString(this.di[Iterasi].delta);

        }
    }
}
