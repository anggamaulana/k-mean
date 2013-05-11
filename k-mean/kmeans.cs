using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k_mean
{
    class kmeans
    {
        private int[,] fungsiKeanggotaan;
        private int[] titikKeCluster;
        private double[,] distance;
        private double fungsisubjektif=0;
        private double deltafungsiSubjektif=0;
        private double[,] data;
        private int cluster;        
        private double[,] centroid;
        private double threshold;
        private List<DataIterasi> di;
        private int pergantianCluster=0;
        
        public kmeans(int cluster,double[,] data,double threshold)
        {
            this.cluster = cluster;
            this.data = data;
            this.threshold = threshold;
        }


        public kmeans(int cluster, double[,] data, double threshold,int[] titikKeCluster)
        {
            this.cluster = cluster;
            this.data = data;
            this.threshold = threshold;
            this.titikKeCluster = titikKeCluster;
            this.centroid = new double[cluster,data.GetLength(1)];
            this.distance = new double[data.GetLength(0), this.cluster];
            di = new List<DataIterasi>();
            

            int length=data.GetLength(0);
            this.fungsiKeanggotaan = new int[length,cluster];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < cluster; j++)
                {
                    if (j == titikKeCluster[i])
                    {
                        fungsiKeanggotaan[i,j] = 1;
                    }
                    else
                    {
                        fungsiKeanggotaan[i,j] = 0;
                    }
                }
            }

            

        }



       

        public void proses()
        {
          
            
           
            
            
            do{
                
                

               

                //record iteration
                //Untuk Mencatat perubahan iterasi bukan pemroses
                DataIterasi dit = new DataIterasi();
                dit.fungsiKeanggotaan = new int[this.fungsiKeanggotaan.GetLength(0), this.fungsiKeanggotaan.GetLength(1)];
                dit.data = new double[this.data.GetLength(0), this.data.GetLength(1)];
                dit.distance = new double[this.distance.GetLength(0), this.distance.GetLength(1)];
                dit.centroid = new double[this.centroid.GetLength(0), this.centroid.GetLength(1)];
                Array.Copy(this.fungsiKeanggotaan, 0, dit.fungsiKeanggotaan, 0, this.fungsiKeanggotaan.Length);
                Array.Copy(this.data, 0, dit.data, 0, this.data.Length);
                dit.pergantianCluster = this.pergantianCluster;
                //----------------------

                
                //proses utama
                hitungCentroid();
                alokasiDataKeCluster();
                hitungFungsiSubjektif();
                //---------------------

                //record iteration
                //Untuk Mencatat perubahan iterasi bukan pemroses
                Array.Copy(this.distance, 0, dit.distance, 0, this.distance.Length);
                Array.Copy(this.centroid, 0, dit.centroid, 0, this.centroid.Length);
                
                dit.cluster = this.cluster;
                dit.fungsisubjektif = this.fungsisubjektif;
                di.Add(dit);
                //-----------------

               
            } while (deltafungsiSubjektif >= threshold) ;
            
        }

     

        private void hitungCentroid(){

            
            List<int>[] grouping = new List<int>[this.cluster];
           
            //pengelompokkan index data berdasarkan cluster
            for (int i = 0; i < this.cluster; i++)
            {
                List<int> indexData = new List<int>();
                for (int j = 0; j < this.titikKeCluster.Length; j++)
                {
                    if (titikKeCluster[j] == i)
                    {
                        indexData.Add(j);
                    }
                }

                grouping[i] = indexData;
            }

            //pencarian nilai mean untuk setiap feature
            for (int i = 0; i < this.cluster; i++)
            {
                int[] group = grouping[i].ToArray();
                int length = group.Length;
                
                    //perulangan untuk index feature
                    for (int k = 0; k < this.data.GetLength(1); k++)
                    {
                        double[] feature = new double[length];
                        //perulangan untuk index data
                        for (int j = 0; j < length; j++)
                        {
                            feature[j] = this.data[group[j],k];
                        }
                        this.centroid[i,k] = Mean(feature);
                    }
                

            }

            
            
        }

        private void alokasiDataKeCluster()
        {
            //perulangan data
            for (int i = 0; i < this.data.GetLength(0); i++)
            {
                double[] distanceEachCluster = new double[this.cluster];
                double[] titikX = new double[this.data.GetLength(1)];
                //memasukkan feature data ke i sebagai titikX
                for (int j = 0; j < this.data.GetLength(1); j++)
                {
                    titikX[j] = this.data[i,j];
                }


                //mencari jarak dari titik xi ke masing2 cluster
                for (int j = 0; j < this.cluster; j++)
                {
                    double[] titikCentroid = new double[this.data.GetLength(1)];
                    //memasukkan titik feature centroid untuk cluster ke j ke var titikCentroid
                    for (int k = 0; k < this.data.GetLength(1); k++)
                        {
                            titikCentroid[k] = this.centroid[j,k];
                        }
                    distanceEachCluster[j] = euclidean(titikCentroid,titikX);
                    this.distance[i, j] = distanceEachCluster[j];
                }

                int indexCluster = min(distanceEachCluster);

                titikKeCluster[i] = indexCluster;

                //ganti fungsiKeanggotaan
                int pergantiancluster = 0;
                for (int l = 0; l < this.cluster; l++)
                {
                    if (l == indexCluster)
                    {
                        //hitung pergantian cluster
                        if (this.fungsiKeanggotaan[i, l] == 0)
                            pergantiancluster++;
                        //-------------------------

                        this.fungsiKeanggotaan[i,l] = 1;
                        
                    }
                    else
                    {
                       
                        this.fungsiKeanggotaan[i, l] = 0;
                    }
                }
                this.pergantianCluster=pergantiancluster;



            }
        }

        private void hitungFungsiSubjektif()
        {
            double fs=0;
            for (int i = 0; i < this.data.GetLength(0); i++)
            {
                for (int j = 0; j < this.cluster; j++)
                {
                    fs += this.fungsiKeanggotaan[i, j] * this.distance[i, j]; 
                }
            }
            this.deltafungsiSubjektif = fs - this.fungsisubjektif;
            this.fungsisubjektif = fs;
        }

        private double euclidean(double[] awal,double[] akhir){
            int length = awal.Length;
            double distance=0;
            for(int i=0;i<length;i++){
                distance+=Math.Pow(awal[i]-akhir[i],2);
            }
            
            return Math.Sqrt(distance);
        }


        private double Mean(double[] data){
            int length = data.Length;
            double result=0;
            for(int i=0;i<length;i++){
                result+=data[i];
            }
            return result/length;            
        }


        private int min(double[] data){
            int length = data.Length;
            int index=0;
            for(int i=0;i<length;i++){
                if(data[index]>data[i]){
                    index=i;
                }
            }
            return index;
        }


        public int[,] getFungsiKeanggotaan()
        {
            return this.fungsiKeanggotaan;
        }

        public double[,] getDistance()
        {
           return this.distance;
        }

        public double[,] getCentroid()
        {
            return this.centroid;
        }

        public DataIterasi[] getdataiterasi()
        {
            return this.di.ToArray();
        }


        
    }
}
