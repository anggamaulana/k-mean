namespace k_mean
{
    partial class Cluster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_cluster = new System.Windows.Forms.DataGridView();
            this.lbl_iterasi = new System.Windows.Forms.Label();
            this.lbl_centroid = new System.Windows.Forms.Label();
            this.lbl_perpindahan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cluster)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(12, 22);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(110, 23);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "<<Previous Iteration";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(141, 22);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(108, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next Iteration >>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iterasi ke ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Centroid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jumlah Perpindahan";
            // 
            // dg_cluster
            // 
            this.dg_cluster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cluster.Location = new System.Drawing.Point(12, 148);
            this.dg_cluster.Name = "dg_cluster";
            this.dg_cluster.Size = new System.Drawing.Size(869, 387);
            this.dg_cluster.TabIndex = 5;
            // 
            // lbl_iterasi
            // 
            this.lbl_iterasi.AutoSize = true;
            this.lbl_iterasi.Location = new System.Drawing.Point(157, 60);
            this.lbl_iterasi.Name = "lbl_iterasi";
            this.lbl_iterasi.Size = new System.Drawing.Size(29, 13);
            this.lbl_iterasi.TabIndex = 6;
            this.lbl_iterasi.Text = "label";
            // 
            // lbl_centroid
            // 
            this.lbl_centroid.AutoSize = true;
            this.lbl_centroid.Location = new System.Drawing.Point(157, 92);
            this.lbl_centroid.Name = "lbl_centroid";
            this.lbl_centroid.Size = new System.Drawing.Size(35, 13);
            this.lbl_centroid.TabIndex = 7;
            this.lbl_centroid.Text = "label4";
            // 
            // lbl_perpindahan
            // 
            this.lbl_perpindahan.AutoSize = true;
            this.lbl_perpindahan.Location = new System.Drawing.Point(157, 122);
            this.lbl_perpindahan.Name = "lbl_perpindahan";
            this.lbl_perpindahan.Size = new System.Drawing.Size(35, 13);
            this.lbl_perpindahan.TabIndex = 8;
            this.lbl_perpindahan.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_perpindahan);
            this.Controls.Add(this.lbl_centroid);
            this.Controls.Add(this.lbl_iterasi);
            this.Controls.Add(this.dg_cluster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Name = "Cluster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cluster";
            this.Load += new System.EventHandler(this.Cluster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cluster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dg_cluster;
        private System.Windows.Forms.Label lbl_iterasi;
        private System.Windows.Forms.Label lbl_centroid;
        private System.Windows.Forms.Label lbl_perpindahan;
        private System.Windows.Forms.Button button1;
       
    }
}