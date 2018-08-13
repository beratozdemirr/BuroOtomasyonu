namespace ProvegaDeneme
{
    partial class FormPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersoneller));
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.btnPerEkle = new System.Windows.Forms.Button();
            this.btnPerSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPerAdEkle = new System.Windows.Forms.TextBox();
            this.txtPerSoyadEkle = new System.Windows.Forms.TextBox();
            this.txtPerTcEkle = new System.Windows.Forms.TextBox();
            this.txtPerSicilNoekle = new System.Windows.Forms.TextBox();
            this.txtPerAlanEkle = new System.Windows.Forms.TextBox();
            this.txtPerMaasEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(-1, 206);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.Size = new System.Drawing.Size(601, 168);
            this.dataGridViewPersonel.TabIndex = 0;
            // 
            // btnPerEkle
            // 
            this.btnPerEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerEkle.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnPerEkle.Location = new System.Drawing.Point(175, 428);
            this.btnPerEkle.Name = "btnPerEkle";
            this.btnPerEkle.Size = new System.Drawing.Size(119, 35);
            this.btnPerEkle.TabIndex = 1;
            this.btnPerEkle.Text = "Personel Ekle";
            this.btnPerEkle.UseVisualStyleBackColor = true;
            this.btnPerEkle.Click += new System.EventHandler(this.btnPerEkle_Click);
            // 
            // btnPerSil
            // 
            this.btnPerSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerSil.ForeColor = System.Drawing.Color.Lime;
            this.btnPerSil.Location = new System.Drawing.Point(328, 428);
            this.btnPerSil.Name = "btnPerSil";
            this.btnPerSil.Size = new System.Drawing.Size(119, 35);
            this.btnPerSil.TabIndex = 2;
            this.btnPerSil.Text = "Personel Sil";
            this.btnPerSil.UseVisualStyleBackColor = true;
            this.btnPerSil.Click += new System.EventHandler(this.btnPerSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 211);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtPerAdEkle
            // 
            this.txtPerAdEkle.Location = new System.Drawing.Point(12, 401);
            this.txtPerAdEkle.Name = "txtPerAdEkle";
            this.txtPerAdEkle.Size = new System.Drawing.Size(88, 20);
            this.txtPerAdEkle.TabIndex = 4;
            this.txtPerAdEkle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPerSoyadEkle
            // 
            this.txtPerSoyadEkle.Location = new System.Drawing.Point(109, 401);
            this.txtPerSoyadEkle.Name = "txtPerSoyadEkle";
            this.txtPerSoyadEkle.Size = new System.Drawing.Size(92, 20);
            this.txtPerSoyadEkle.TabIndex = 5;
            // 
            // txtPerTcEkle
            // 
            this.txtPerTcEkle.Location = new System.Drawing.Point(207, 401);
            this.txtPerTcEkle.Name = "txtPerTcEkle";
            this.txtPerTcEkle.Size = new System.Drawing.Size(100, 20);
            this.txtPerTcEkle.TabIndex = 6;
            // 
            // txtPerSicilNoekle
            // 
            this.txtPerSicilNoekle.Location = new System.Drawing.Point(313, 401);
            this.txtPerSicilNoekle.Name = "txtPerSicilNoekle";
            this.txtPerSicilNoekle.Size = new System.Drawing.Size(100, 20);
            this.txtPerSicilNoekle.TabIndex = 7;
            // 
            // txtPerAlanEkle
            // 
            this.txtPerAlanEkle.Location = new System.Drawing.Point(419, 401);
            this.txtPerAlanEkle.Name = "txtPerAlanEkle";
            this.txtPerAlanEkle.Size = new System.Drawing.Size(100, 20);
            this.txtPerAlanEkle.TabIndex = 8;
            // 
            // txtPerMaasEkle
            // 
            this.txtPerMaasEkle.Location = new System.Drawing.Point(525, 401);
            this.txtPerMaasEkle.Name = "txtPerMaasEkle";
            this.txtPerMaasEkle.Size = new System.Drawing.Size(75, 20);
            this.txtPerMaasEkle.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Personel Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Personel Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel TC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Personel Sicil No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Personel Alan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Peronel Maas";
            // 
            // FormPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 475);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPerMaasEkle);
            this.Controls.Add(this.txtPerAlanEkle);
            this.Controls.Add(this.txtPerSicilNoekle);
            this.Controls.Add(this.txtPerTcEkle);
            this.Controls.Add(this.txtPerSoyadEkle);
            this.Controls.Add(this.txtPerAdEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPerSil);
            this.Controls.Add(this.btnPerEkle);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Name = "FormPersoneller";
            this.Text = "FormPersoneller";
            this.Load += new System.EventHandler(this.FormPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.Button btnPerEkle;
        private System.Windows.Forms.Button btnPerSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPerAdEkle;
        private System.Windows.Forms.TextBox txtPerSoyadEkle;
        private System.Windows.Forms.TextBox txtPerTcEkle;
        private System.Windows.Forms.TextBox txtPerSicilNoekle;
        private System.Windows.Forms.TextBox txtPerAlanEkle;
        private System.Windows.Forms.TextBox txtPerMaasEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}