namespace proje
{
    partial class ÜrünDüzenle
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunDuzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextAgırlık = new System.Windows.Forms.TextBox();
            this.TextAdet = new System.Windows.Forms.TextBox();
            this.TextFiyat = new System.Windows.Forms.TextBox();
            this.TextModel = new System.Windows.Forms.TextBox();
            this.Textmark = new System.Windows.Forms.TextBox();
            this.UrunGuncel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Location = new System.Drawing.Point(33, -66);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 39);
            this.panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(122, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(602, 391);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.HeaderText = "Ürünün Markası";
            this.Column2.MinimumWidth = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 126;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ürünün Modeli";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ürünün Fiyatı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ürün Adedi";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ağırlığı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // UrunDuzenle
            // 
            this.UrunDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunDuzenle.Location = new System.Drawing.Point(495, 467);
            this.UrunDuzenle.Margin = new System.Windows.Forms.Padding(4);
            this.UrunDuzenle.Name = "UrunDuzenle";
            this.UrunDuzenle.Size = new System.Drawing.Size(201, 46);
            this.UrunDuzenle.TabIndex = 24;
            this.UrunDuzenle.Text = "Ürünü Düzenle";
            this.UrunDuzenle.UseVisualStyleBackColor = true;
            this.UrunDuzenle.Click += new System.EventHandler(this.UrunDuzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(253, 552);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ağırlığı";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(336, 498);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Adedi";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(161, 491);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fiyatı";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(329, 441);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Modeli";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(161, 441);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Markası";
            this.label1.Visible = false;
            // 
            // TextAgırlık
            // 
            this.TextAgırlık.Location = new System.Drawing.Point(228, 575);
            this.TextAgırlık.Margin = new System.Windows.Forms.Padding(4);
            this.TextAgırlık.Name = "TextAgırlık";
            this.TextAgırlık.Size = new System.Drawing.Size(132, 22);
            this.TextAgırlık.TabIndex = 18;
            this.TextAgırlık.Visible = false;
            // 
            // TextAdet
            // 
            this.TextAdet.Location = new System.Drawing.Point(308, 521);
            this.TextAdet.Margin = new System.Windows.Forms.Padding(4);
            this.TextAdet.Name = "TextAdet";
            this.TextAdet.Size = new System.Drawing.Size(132, 22);
            this.TextAdet.TabIndex = 17;
            this.TextAdet.Visible = false;
            // 
            // TextFiyat
            // 
            this.TextFiyat.Location = new System.Drawing.Point(143, 521);
            this.TextFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TextFiyat.Name = "TextFiyat";
            this.TextFiyat.Size = new System.Drawing.Size(132, 22);
            this.TextFiyat.TabIndex = 16;
            this.TextFiyat.Visible = false;
            // 
            // TextModel
            // 
            this.TextModel.Location = new System.Drawing.Point(308, 467);
            this.TextModel.Margin = new System.Windows.Forms.Padding(4);
            this.TextModel.Name = "TextModel";
            this.TextModel.Size = new System.Drawing.Size(132, 22);
            this.TextModel.TabIndex = 15;
            this.TextModel.Visible = false;
            // 
            // Textmark
            // 
            this.Textmark.Location = new System.Drawing.Point(143, 468);
            this.Textmark.Margin = new System.Windows.Forms.Padding(4);
            this.Textmark.Name = "Textmark";
            this.Textmark.Size = new System.Drawing.Size(132, 22);
            this.Textmark.TabIndex = 14;
            this.Textmark.Visible = false;
            // 
            // UrunGuncel
            // 
            this.UrunGuncel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunGuncel.Location = new System.Drawing.Point(495, 521);
            this.UrunGuncel.Margin = new System.Windows.Forms.Padding(4);
            this.UrunGuncel.Name = "UrunGuncel";
            this.UrunGuncel.Size = new System.Drawing.Size(201, 46);
            this.UrunGuncel.TabIndex = 13;
            this.UrunGuncel.Text = "Ürünü Güncelle";
            this.UrunGuncel.UseVisualStyleBackColor = true;
            this.UrunGuncel.Visible = false;
            this.UrunGuncel.Click += new System.EventHandler(this.UrunGuncel_Click);
            // 
            // ÜrünDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(861, 605);
            this.Controls.Add(this.UrunDuzenle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextAgırlık);
            this.Controls.Add(this.TextAdet);
            this.Controls.Add(this.TextFiyat);
            this.Controls.Add(this.TextModel);
            this.Controls.Add(this.Textmark);
            this.Controls.Add(this.UrunGuncel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜrünDüzenle";
            this.Text = "ÜrünDüzenle";
            this.Load += new System.EventHandler(this.ÜrünDüzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button UrunDuzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextAgırlık;
        private System.Windows.Forms.TextBox TextAdet;
        private System.Windows.Forms.TextBox TextFiyat;
        private System.Windows.Forms.TextBox TextModel;
        private System.Windows.Forms.TextBox Textmark;
        private System.Windows.Forms.Button UrunGuncel;
    }
}