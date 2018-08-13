namespace ProvegaDeneme
{
    partial class FormToplatilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToplatilar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewToplantilar = new System.Windows.Forms.DataGridView();
            this.btnTopEkle = new System.Windows.Forms.Button();
            this.btnTopSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTopYapilacakKisiEkle = new System.Windows.Forms.TextBox();
            this.txtTopYeriEkle = new System.Windows.Forms.TextBox();
            this.dateTimeTopZamani = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToplantilar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewToplantilar
            // 
            this.dataGridViewToplantilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToplantilar.Location = new System.Drawing.Point(-1, 210);
            this.dataGridViewToplantilar.Name = "dataGridViewToplantilar";
            this.dataGridViewToplantilar.Size = new System.Drawing.Size(646, 195);
            this.dataGridViewToplantilar.TabIndex = 1;
            // 
            // btnTopEkle
            // 
            this.btnTopEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopEkle.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTopEkle.Location = new System.Drawing.Point(146, 464);
            this.btnTopEkle.Name = "btnTopEkle";
            this.btnTopEkle.Size = new System.Drawing.Size(125, 26);
            this.btnTopEkle.TabIndex = 2;
            this.btnTopEkle.Text = "Toplantı Ekle";
            this.btnTopEkle.UseVisualStyleBackColor = true;
            this.btnTopEkle.Click += new System.EventHandler(this.btnTopEkle_Click);
            // 
            // btnTopSil
            // 
            this.btnTopSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopSil.ForeColor = System.Drawing.Color.Lime;
            this.btnTopSil.Location = new System.Drawing.Point(319, 464);
            this.btnTopSil.Name = "btnTopSil";
            this.btnTopSil.Size = new System.Drawing.Size(125, 26);
            this.btnTopSil.TabIndex = 3;
            this.btnTopSil.Text = "Toplantı Sil";
            this.btnTopSil.UseVisualStyleBackColor = true;
            this.btnTopSil.Click += new System.EventHandler(this.btnTopSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplantı Yapılacak Kişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toplantı Yeri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplantı Zamanı";
            // 
            // txtTopYapilacakKisiEkle
            // 
            this.txtTopYapilacakKisiEkle.Location = new System.Drawing.Point(40, 437);
            this.txtTopYapilacakKisiEkle.Name = "txtTopYapilacakKisiEkle";
            this.txtTopYapilacakKisiEkle.Size = new System.Drawing.Size(100, 20);
            this.txtTopYapilacakKisiEkle.TabIndex = 7;
            // 
            // txtTopYeriEkle
            // 
            this.txtTopYeriEkle.Location = new System.Drawing.Point(247, 438);
            this.txtTopYeriEkle.Name = "txtTopYeriEkle";
            this.txtTopYeriEkle.Size = new System.Drawing.Size(100, 20);
            this.txtTopYeriEkle.TabIndex = 8;
            // 
            // dateTimeTopZamani
            // 
            this.dateTimeTopZamani.Location = new System.Drawing.Point(426, 435);
            this.dateTimeTopZamani.Name = "dateTimeTopZamani";
            this.dateTimeTopZamani.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTopZamani.TabIndex = 9;
            // 
            // FormToplatilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 502);
            this.Controls.Add(this.dateTimeTopZamani);
            this.Controls.Add(this.txtTopYeriEkle);
            this.Controls.Add(this.txtTopYapilacakKisiEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTopSil);
            this.Controls.Add(this.btnTopEkle);
            this.Controls.Add(this.dataGridViewToplantilar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormToplatilar";
            this.Text = "FormToplatilar";
            this.Load += new System.EventHandler(this.FormToplatilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToplantilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewToplantilar;
        private System.Windows.Forms.Button btnTopEkle;
        private System.Windows.Forms.Button btnTopSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTopYapilacakKisiEkle;
        private System.Windows.Forms.TextBox txtTopYeriEkle;
        private System.Windows.Forms.DateTimePicker dateTimeTopZamani;
    }
}