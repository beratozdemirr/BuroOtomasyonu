namespace ProvegaDeneme
{
    partial class FormMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusteriler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.btnMusEkle = new System.Windows.Forms.Button();
            this.btnMusSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusAdEkle = new System.Windows.Forms.TextBox();
            this.txtMusSoyadEkle = new System.Windows.Forms.TextBox();
            this.txtMusTcEkle = new System.Windows.Forms.TextBox();
            this.txtMusFirmaEkle = new System.Windows.Forms.TextBox();
            this.txtMusVergiNoEkle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(597, 214);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(-3, 214);
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.Size = new System.Drawing.Size(597, 201);
            this.dataGridViewMusteri.TabIndex = 1;
            // 
            // btnMusEkle
            // 
            this.btnMusEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusEkle.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnMusEkle.Location = new System.Drawing.Point(140, 471);
            this.btnMusEkle.Name = "btnMusEkle";
            this.btnMusEkle.Size = new System.Drawing.Size(131, 29);
            this.btnMusEkle.TabIndex = 2;
            this.btnMusEkle.Text = "Müşteri Ekle";
            this.btnMusEkle.UseVisualStyleBackColor = true;
            this.btnMusEkle.Click += new System.EventHandler(this.btnMusEkle_Click);
            // 
            // btnMusSil
            // 
            this.btnMusSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusSil.ForeColor = System.Drawing.Color.Lime;
            this.btnMusSil.Location = new System.Drawing.Point(315, 471);
            this.btnMusSil.Name = "btnMusSil";
            this.btnMusSil.Size = new System.Drawing.Size(131, 29);
            this.btnMusSil.TabIndex = 3;
            this.btnMusSil.Text = "Müşteri Sil";
            this.btnMusSil.UseVisualStyleBackColor = true;
            this.btnMusSil.Click += new System.EventHandler(this.btnMusSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Musteri Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Musteri Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Musteri TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Musteri Firma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Musteri Vergi No";
            // 
            // txtMusAdEkle
            // 
            this.txtMusAdEkle.Location = new System.Drawing.Point(12, 448);
            this.txtMusAdEkle.Name = "txtMusAdEkle";
            this.txtMusAdEkle.Size = new System.Drawing.Size(100, 20);
            this.txtMusAdEkle.TabIndex = 9;
            // 
            // txtMusSoyadEkle
            // 
            this.txtMusSoyadEkle.Location = new System.Drawing.Point(129, 447);
            this.txtMusSoyadEkle.Name = "txtMusSoyadEkle";
            this.txtMusSoyadEkle.Size = new System.Drawing.Size(100, 20);
            this.txtMusSoyadEkle.TabIndex = 10;
            // 
            // txtMusTcEkle
            // 
            this.txtMusTcEkle.Location = new System.Drawing.Point(246, 447);
            this.txtMusTcEkle.Name = "txtMusTcEkle";
            this.txtMusTcEkle.Size = new System.Drawing.Size(100, 20);
            this.txtMusTcEkle.TabIndex = 11;
            // 
            // txtMusFirmaEkle
            // 
            this.txtMusFirmaEkle.Location = new System.Drawing.Point(364, 447);
            this.txtMusFirmaEkle.Name = "txtMusFirmaEkle";
            this.txtMusFirmaEkle.Size = new System.Drawing.Size(100, 20);
            this.txtMusFirmaEkle.TabIndex = 12;
            // 
            // txtMusVergiNoEkle
            // 
            this.txtMusVergiNoEkle.Location = new System.Drawing.Point(479, 448);
            this.txtMusVergiNoEkle.Name = "txtMusVergiNoEkle";
            this.txtMusVergiNoEkle.Size = new System.Drawing.Size(100, 20);
            this.txtMusVergiNoEkle.TabIndex = 13;
            // 
            // FormMusteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 501);
            this.Controls.Add(this.txtMusVergiNoEkle);
            this.Controls.Add(this.txtMusFirmaEkle);
            this.Controls.Add(this.txtMusTcEkle);
            this.Controls.Add(this.txtMusSoyadEkle);
            this.Controls.Add(this.txtMusAdEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMusSil);
            this.Controls.Add(this.btnMusEkle);
            this.Controls.Add(this.dataGridViewMusteri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMusteriler";
            this.Text = "FormMusteriler";
            this.Load += new System.EventHandler(this.FormMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewMusteri;
        private System.Windows.Forms.Button btnMusEkle;
        private System.Windows.Forms.Button btnMusSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusAdEkle;
        private System.Windows.Forms.TextBox txtMusSoyadEkle;
        private System.Windows.Forms.TextBox txtMusTcEkle;
        private System.Windows.Forms.TextBox txtMusFirmaEkle;
        private System.Windows.Forms.TextBox txtMusVergiNoEkle;
    }
}