﻿namespace CekilisProgrami
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtAdaylar = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgList = new System.Windows.Forms.DataGridView();
            this.btnCekilis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.nMiktar = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCekilisSayi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(79, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇEKİLİŞ PROGRAMI";
            // 
            // rtxtAdaylar
            // 
            this.rtxtAdaylar.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtAdaylar.Location = new System.Drawing.Point(480, 49);
            this.rtxtAdaylar.Name = "rtxtAdaylar";
            this.rtxtAdaylar.Size = new System.Drawing.Size(263, 310);
            this.rtxtAdaylar.TabIndex = 1;
            this.rtxtAdaylar.Text = "";
            this.rtxtAdaylar.TextChanged += new System.EventHandler(this.rtxtAdaylar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(544, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ÇEKİLİŞ LİSTESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(503, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Her satıra bir isim gelecek şekilde doldurun";
            // 
            // dtgList
            // 
            this.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgList.Location = new System.Drawing.Point(13, 85);
            this.dtgList.Name = "dtgList";
            this.dtgList.Size = new System.Drawing.Size(462, 274);
            this.dtgList.TabIndex = 4;
            // 
            // btnCekilis
            // 
            this.btnCekilis.Location = new System.Drawing.Point(157, 47);
            this.btnCekilis.Name = "btnCekilis";
            this.btnCekilis.Size = new System.Drawing.Size(107, 23);
            this.btnCekilis.TabIndex = 5;
            this.btnCekilis.Text = "Çekilişi Başlat";
            this.btnCekilis.UseVisualStyleBackColor = true;
            this.btnCekilis.Click += new System.EventHandler(this.btnCekilis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(270, 47);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 23);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Yeni Çekiliş";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // nMiktar
            // 
            this.nMiktar.Location = new System.Drawing.Point(13, 49);
            this.nMiktar.Name = "nMiktar";
            this.nMiktar.Size = new System.Drawing.Size(138, 20);
            this.nMiktar.TabIndex = 7;
            this.nMiktar.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(391, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Katılan Sayısı";
            // 
            // lblCekilisSayi
            // 
            this.lblCekilisSayi.AutoSize = true;
            this.lblCekilisSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCekilisSayi.Location = new System.Drawing.Point(412, 45);
            this.lblCekilisSayi.Name = "lblCekilisSayi";
            this.lblCekilisSayi.Size = new System.Drawing.Size(24, 25);
            this.lblCekilisSayi.TabIndex = 9;
            this.lblCekilisSayi.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(755, 371);
            this.Controls.Add(this.lblCekilisSayi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nMiktar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnCekilis);
            this.Controls.Add(this.dtgList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtAdaylar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Çekiliş Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtAdaylar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgList;
        private System.Windows.Forms.Button btnCekilis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.NumericUpDown nMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCekilisSayi;
    }
}

