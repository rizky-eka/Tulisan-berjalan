namespace TulisanBerjalan
{
    partial class frmTulisanBerjalan
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
            this.components = new System.ComponentModel.Container();
            this.lblTulisanBerjalan = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTulisanBerjalan
            // 
            this.lblTulisanBerjalan.AutoSize = true;
            this.lblTulisanBerjalan.Location = new System.Drawing.Point(130, 69);
            this.lblTulisanBerjalan.Name = "lblTulisanBerjalan";
            this.lblTulisanBerjalan.Size = new System.Drawing.Size(82, 13);
            this.lblTulisanBerjalan.TabIndex = 0;
            this.lblTulisanBerjalan.Text = "Tulisan Berjalan";
            this.lblTulisanBerjalan.Click += new System.EventHandler(this.lblTulisanBerjalan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(236, 116);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTulisanBerjalan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.lblTulisanBerjalan);
            this.Name = "frmTulisanBerjalan";
            this.Text = "TulisanBerjalan";
            this.Load += new System.EventHandler(this.frmTulisanBerjalan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTulisanBerjalan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Timer timer1;
    }
}

