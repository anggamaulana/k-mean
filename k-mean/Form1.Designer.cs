namespace k_mean
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dg_data = new System.Windows.Forms.DataGridView();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_manual = new System.Windows.Forms.Button();
            this.lbl_file = new System.Windows.Forms.Label();
            this.btn_cluster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clustering dengan K-Mean";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dg_data
            // 
            this.dg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data.Location = new System.Drawing.Point(15, 100);
            this.dg_data.Name = "dg_data";
            this.dg_data.Size = new System.Drawing.Size(733, 357);
            this.dg_data.TabIndex = 1;
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(15, 45);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(155, 23);
            this.btn_excel.TabIndex = 2;
            this.btn_excel.Text = "Import Excel(*.xls)";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_manual
            // 
            this.btn_manual.Location = new System.Drawing.Point(194, 45);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(165, 23);
            this.btn_manual.TabIndex = 3;
            this.btn_manual.Text = "Isi data Manual";
            this.btn_manual.UseVisualStyleBackColor = true;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(19, 75);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(0, 13);
            this.lbl_file.TabIndex = 4;
            // 
            // btn_cluster
            // 
            this.btn_cluster.Location = new System.Drawing.Point(16, 473);
            this.btn_cluster.Name = "btn_cluster";
            this.btn_cluster.Size = new System.Drawing.Size(142, 23);
            this.btn_cluster.TabIndex = 5;
            this.btn_cluster.Text = "Hitung Clustering";
            this.btn_cluster.UseVisualStyleBackColor = true;
            this.btn_cluster.Click += new System.EventHandler(this.btn_cluster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 508);
            this.Controls.Add(this.btn_cluster);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.btn_manual);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "K-Mean Clustering";
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_data;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_manual;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.Button btn_cluster;
    }
}

