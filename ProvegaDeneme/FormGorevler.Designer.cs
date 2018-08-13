namespace ProvegaDeneme
{
    partial class FormGorevler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGorevler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewGorevler = new System.Windows.Forms.DataGridView();
            this.btnGorEkle = new System.Windows.Forms.Button();
            this.btnGorSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGorKisiEkle = new System.Windows.Forms.TextBox();
            this.txtGorKonuEkle = new System.Windows.Forms.TextBox();
            this.dateTimeGorev = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 217);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewGorevler
            // 
            this.dataGridViewGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGorevler.Location = new System.Drawing.Point(-3, 209);
            this.dataGridViewGorevler.Name = "dataGridViewGorevler";
            this.dataGridViewGorevler.Size = new System.Drawing.Size(646, 207);
            this.dataGridViewGorevler.TabIndex = 1;
            // 
            // btnGorEkle
            // 
            this.btnGorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGorEkle.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnGorEkle.Location = new System.Drawing.Point(126, 469);
            this.btnGorEkle.Name = "btnGorEkle";
            this.btnGorEkle.Size = new System.Drawing.Size(140, 23);
            this.btnGorEkle.TabIndex = 2;
            this.btnGorEkle.Text = "Görev Ekle";
            this.btnGorEkle.UseVisualStyleBackColor = true;
            this.btnGorEkle.Click += new System.EventHandler(this.btnGorEkle_Click);
            // 
            // btnGorSil
            // 
            this.btnGorSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGorSil.ForeColor = System.Drawing.Color.Lime;
            this.btnGorSil.Location = new System.Drawing.Point(339, 469);
            this.btnGorSil.Name = "btnGorSil";
            this.btnGorSil.Size = new System.Drawing.Size(140, 23);
            this.btnGorSil.TabIndex = 3;
            this.btnGorSil.Text = "Görev Sil";
            this.btnGorSil.UseVisualStyleBackColor = true;
            this.btnGorSil.Click += new System.EventHandler(this.btnGorSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Görev Kişisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Görev Konusu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Görev Son Tarihi";
            // 
            // txtGorKisiEkle
            // 
            this.txtGorKisiEkle.Location = new System.Drawing.Point(59, 440);
            this.txtGorKisiEkle.Name = "txtGorKisiEkle";
            this.txtGorKisiEkle.Size = new System.Drawing.Size(100, 20);
            this.txtGorKisiEkle.TabIndex = 7;
            // 
            // txtGorKonuEkle
            // 
            this.txtGorKonuEkle.Location = new System.Drawing.Point(244, 443);
            this.txtGorKonuEkle.Name = "txtGorKonuEkle";
            this.txtGorKonuEkle.Size = new System.Drawing.Size(100, 20);
            this.txtGorKonuEkle.TabIndex = 8;
            // 
            // dateTimeGorev
            // 
            this.dateTimeGorev.Location = new System.Drawing.Point(414, 443);
            this.dateTimeGorev.Name = "dateTimeGorev";
            this.dateTimeGorev.Size = new System.Drawing.Size(200, 20);
            this.dateTimeGorev.TabIndex = 9;
            // 
            // FormGorevler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 493);
            this.Controls.Add(this.dateTimeGorev);
            this.Controls.Add(this.txtGorKonuEkle);
            this.Controls.Add(this.txtGorKisiEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGorSil);
            this.Controls.Add(this.btnGorEkle);
            this.Controls.Add(this.dataGridViewGorevler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGorevler";
            this.Text = "FormGorevler";
            this.Load += new System.EventHandler(this.FormGorevler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewGorevler;
        private System.Windows.Forms.Button btnGorEkle;
        private System.Windows.Forms.Button btnGorSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGorKisiEkle;
        private System.Windows.Forms.TextBox txtGorKonuEkle;
        private System.Windows.Forms.DateTimePicker dateTimeGorev;
    }
}