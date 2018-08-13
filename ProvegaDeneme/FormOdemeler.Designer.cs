namespace ProvegaDeneme
{
    partial class FormOdemeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOdemeler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewOdemeler = new System.Windows.Forms.DataGridView();
            this.btnOdeEkle = new System.Windows.Forms.Button();
            this.btnOdeSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOdemeYeriEkle = new System.Windows.Forms.TextBox();
            this.txtOdemeTutariEkle = new System.Windows.Forms.TextBox();
            this.dateTimeOdeme = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 214);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewOdemeler
            // 
            this.dataGridViewOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdemeler.Location = new System.Drawing.Point(-6, 208);
            this.dataGridViewOdemeler.Name = "dataGridViewOdemeler";
            this.dataGridViewOdemeler.Size = new System.Drawing.Size(646, 218);
            this.dataGridViewOdemeler.TabIndex = 1;
            // 
            // btnOdeEkle
            // 
            this.btnOdeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdeEkle.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnOdeEkle.Location = new System.Drawing.Point(168, 479);
            this.btnOdeEkle.Name = "btnOdeEkle";
            this.btnOdeEkle.Size = new System.Drawing.Size(141, 23);
            this.btnOdeEkle.TabIndex = 2;
            this.btnOdeEkle.Text = "Ödeme Ekle";
            this.btnOdeEkle.UseVisualStyleBackColor = true;
            this.btnOdeEkle.Click += new System.EventHandler(this.btnOdeEkle_Click);
            // 
            // btnOdeSil
            // 
            this.btnOdeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdeSil.ForeColor = System.Drawing.Color.Lime;
            this.btnOdeSil.Location = new System.Drawing.Point(324, 479);
            this.btnOdeSil.Name = "btnOdeSil";
            this.btnOdeSil.Size = new System.Drawing.Size(141, 23);
            this.btnOdeSil.TabIndex = 3;
            this.btnOdeSil.Text = "Ödeme Sil";
            this.btnOdeSil.UseVisualStyleBackColor = true;
            this.btnOdeSil.Click += new System.EventHandler(this.btnOdeSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ödeme Yeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ödeme Son Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödeme Tutarı";
            // 
            // txtOdemeYeriEkle
            // 
            this.txtOdemeYeriEkle.Location = new System.Drawing.Point(56, 453);
            this.txtOdemeYeriEkle.Name = "txtOdemeYeriEkle";
            this.txtOdemeYeriEkle.Size = new System.Drawing.Size(100, 20);
            this.txtOdemeYeriEkle.TabIndex = 8;
            // 
            // txtOdemeTutariEkle
            // 
            this.txtOdemeTutariEkle.Location = new System.Drawing.Point(260, 453);
            this.txtOdemeTutariEkle.Name = "txtOdemeTutariEkle";
            this.txtOdemeTutariEkle.Size = new System.Drawing.Size(100, 20);
            this.txtOdemeTutariEkle.TabIndex = 9;
            // 
            // dateTimeOdeme
            // 
            this.dateTimeOdeme.Location = new System.Drawing.Point(416, 453);
            this.dateTimeOdeme.Name = "dateTimeOdeme";
            this.dateTimeOdeme.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOdeme.TabIndex = 10;
            // 
            // FormOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 504);
            this.Controls.Add(this.dateTimeOdeme);
            this.Controls.Add(this.txtOdemeTutariEkle);
            this.Controls.Add(this.txtOdemeYeriEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdeSil);
            this.Controls.Add(this.btnOdeEkle);
            this.Controls.Add(this.dataGridViewOdemeler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormOdemeler";
            this.Text = "FormOdemeler";
            this.Load += new System.EventHandler(this.FormOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewOdemeler;
        private System.Windows.Forms.Button btnOdeEkle;
        private System.Windows.Forms.Button btnOdeSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOdemeYeriEkle;
        private System.Windows.Forms.TextBox txtOdemeTutariEkle;
        private System.Windows.Forms.DateTimePicker dateTimeOdeme;
    }
}