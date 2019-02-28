namespace proje
{
    partial class PersonelEkle
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
            this.Kaydet = new System.Windows.Forms.Button();
            this.şifretxtb = new System.Windows.Forms.TextBox();
            this.kuladıtxtb = new System.Windows.Forms.TextBox();
            this.soyisimtxtb = new System.Windows.Forms.TextBox();
            this.isimtxtb = new System.Windows.Forms.TextBox();
            this.şifrelabel = new System.Windows.Forms.Label();
            this.kullanıcıadılabel = new System.Windows.Forms.Label();
            this.soyadlabel = new System.Windows.Forms.Label();
            this.adlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(340, 454);
            this.Kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(191, 38);
            this.Kaydet.TabIndex = 28;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // şifretxtb
            // 
            this.şifretxtb.Location = new System.Drawing.Point(477, 370);
            this.şifretxtb.Margin = new System.Windows.Forms.Padding(4);
            this.şifretxtb.Name = "şifretxtb";
            this.şifretxtb.Size = new System.Drawing.Size(132, 22);
            this.şifretxtb.TabIndex = 27;
            // 
            // kuladıtxtb
            // 
            this.kuladıtxtb.Location = new System.Drawing.Point(477, 289);
            this.kuladıtxtb.Margin = new System.Windows.Forms.Padding(4);
            this.kuladıtxtb.Name = "kuladıtxtb";
            this.kuladıtxtb.Size = new System.Drawing.Size(132, 22);
            this.kuladıtxtb.TabIndex = 26;
            // 
            // soyisimtxtb
            // 
            this.soyisimtxtb.Location = new System.Drawing.Point(477, 217);
            this.soyisimtxtb.Margin = new System.Windows.Forms.Padding(4);
            this.soyisimtxtb.Name = "soyisimtxtb";
            this.soyisimtxtb.Size = new System.Drawing.Size(132, 22);
            this.soyisimtxtb.TabIndex = 25;
            // 
            // isimtxtb
            // 
            this.isimtxtb.Location = new System.Drawing.Point(477, 148);
            this.isimtxtb.Margin = new System.Windows.Forms.Padding(4);
            this.isimtxtb.Name = "isimtxtb";
            this.isimtxtb.Size = new System.Drawing.Size(132, 22);
            this.isimtxtb.TabIndex = 24;
            // 
            // şifrelabel
            // 
            this.şifrelabel.AutoSize = true;
            this.şifrelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifrelabel.Location = new System.Drawing.Point(255, 361);
            this.şifrelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.şifrelabel.Name = "şifrelabel";
            this.şifrelabel.Size = new System.Drawing.Size(69, 29);
            this.şifrelabel.TabIndex = 23;
            this.şifrelabel.Text = "Şifre:";
            // 
            // kullanıcıadılabel
            // 
            this.kullanıcıadılabel.AutoSize = true;
            this.kullanıcıadılabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıadılabel.Location = new System.Drawing.Point(257, 284);
            this.kullanıcıadılabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kullanıcıadılabel.Name = "kullanıcıadılabel";
            this.kullanıcıadılabel.Size = new System.Drawing.Size(151, 29);
            this.kullanıcıadılabel.TabIndex = 22;
            this.kullanıcıadılabel.Text = "Kullanıcı Adı:";
            // 
            // soyadlabel
            // 
            this.soyadlabel.AutoSize = true;
            this.soyadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadlabel.Location = new System.Drawing.Point(256, 215);
            this.soyadlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.soyadlabel.Name = "soyadlabel";
            this.soyadlabel.Size = new System.Drawing.Size(207, 29);
            this.soyadlabel.TabIndex = 21;
            this.soyadlabel.Text = "Personel Soyisim:";
            // 
            // adlabel
            // 
            this.adlabel.AutoSize = true;
            this.adlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adlabel.Location = new System.Drawing.Point(257, 143);
            this.adlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(166, 29);
            this.adlabel.TabIndex = 20;
            this.adlabel.Text = "Personel İsim:";
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(861, 605);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.şifretxtb);
            this.Controls.Add(this.kuladıtxtb);
            this.Controls.Add(this.soyisimtxtb);
            this.Controls.Add(this.isimtxtb);
            this.Controls.Add(this.şifrelabel);
            this.Controls.Add(this.kullanıcıadılabel);
            this.Controls.Add(this.soyadlabel);
            this.Controls.Add(this.adlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.TextBox şifretxtb;
        private System.Windows.Forms.TextBox kuladıtxtb;
        private System.Windows.Forms.TextBox soyisimtxtb;
        private System.Windows.Forms.TextBox isimtxtb;
        private System.Windows.Forms.Label şifrelabel;
        private System.Windows.Forms.Label kullanıcıadılabel;
        private System.Windows.Forms.Label soyadlabel;
        private System.Windows.Forms.Label adlabel;
    }
}