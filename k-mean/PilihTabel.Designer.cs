namespace k_mean
{
    partial class PilihTabel
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
            this.lb_tabel = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_cluster = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_tabel
            // 
            this.lb_tabel.FormattingEnabled = true;
            this.lb_tabel.Location = new System.Drawing.Point(10, 12);
            this.lb_tabel.Name = "lb_tabel";
            this.lb_tabel.Size = new System.Drawing.Size(252, 173);
            this.lb_tabel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "PIlih";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jumlah Cluster";
            // 
            // tb_cluster
            // 
            this.tb_cluster.Location = new System.Drawing.Point(110, 209);
            this.tb_cluster.Name = "tb_cluster";
            this.tb_cluster.Size = new System.Drawing.Size(100, 20);
            this.tb_cluster.TabIndex = 3;
            // 
            // PilihTabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 324);
            this.Controls.Add(this.tb_cluster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_tabel);
            this.Name = "PilihTabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PilihTabel";
            this.Load += new System.EventHandler(this.PilihTabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_tabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_cluster;
    }
}