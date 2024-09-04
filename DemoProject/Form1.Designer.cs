namespace DemoProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDeneme2 = new System.Windows.Forms.Button();
            this.btnDeneme1 = new System.Windows.Forms.Button();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chboxStatus = new System.Windows.Forms.CheckBox();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeneme2
            // 
            this.btnDeneme2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(114)))), ((int)(((byte)(166)))));
            this.btnDeneme2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeneme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeneme2.Location = new System.Drawing.Point(131, 82);
            this.btnDeneme2.Name = "btnDeneme2";
            this.btnDeneme2.Size = new System.Drawing.Size(60, 45);
            this.btnDeneme2.TabIndex = 0;
            this.btnDeneme2.Text = "İndirim Uygula";
            this.btnDeneme2.UseVisualStyleBackColor = false;
            this.btnDeneme2.Click += new System.EventHandler(this.btnDeneme2_Click);
            // 
            // btnDeneme1
            // 
            this.btnDeneme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(250)))), ((int)(((byte)(193)))));
            this.btnDeneme1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeneme1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeneme1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeneme1.Location = new System.Drawing.Point(42, 82);
            this.btnDeneme1.Name = "btnDeneme1";
            this.btnDeneme1.Size = new System.Drawing.Size(61, 45);
            this.btnDeneme1.TabIndex = 1;
            this.btnDeneme1.Text = "Veri Gönder";
            this.btnDeneme1.UseVisualStyleBackColor = false;
            this.btnDeneme1.Click += new System.EventHandler(this.btnDeneme1_Click);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(42, 47);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(149, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad";
            // 
            // chboxStatus
            // 
            this.chboxStatus.AutoSize = true;
            this.chboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chboxStatus.Location = new System.Drawing.Point(197, 49);
            this.chboxStatus.Name = "chboxStatus";
            this.chboxStatus.Size = new System.Drawing.Size(112, 17);
            this.chboxStatus.TabIndex = 4;
            this.chboxStatus.Text = "Aktiflik Durumu";
            this.chboxStatus.UseVisualStyleBackColor = true;
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(257, 72);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(40, 20);
            this.numDiscount.TabIndex = 5;
            this.numDiscount.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(318, 278);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.chboxStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.btnDeneme1);
            this.Controls.Add(this.btnDeneme2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlk Uygulamam";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeneme2;
        private System.Windows.Forms.Button btnDeneme1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chboxStatus;
        private System.Windows.Forms.NumericUpDown numDiscount;
    }
}

