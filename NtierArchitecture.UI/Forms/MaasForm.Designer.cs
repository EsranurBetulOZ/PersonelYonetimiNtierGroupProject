﻿namespace NtierArchitecture.UI.Formlar
{
	partial class MaasForm
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lstPersonelozlukBilgileri = new ListBox();
            comboBox1 = new ComboBox();
            txtNameSurname = new TextBox();
            textBox2 = new TextBox();
            lstupdate = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(175, 21);
            label1.TabIndex = 0;
            label1.Text = "Maaş İşlemleri Ve Özlük";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(140, 21);
            label2.TabIndex = 1;
            label2.Text = "Departman Seçiniz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 305);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 3;
            label4.Text = "Yeni Maaş Atama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(610, 118);
            label5.Name = "label5";
            label5.Size = new Size(76, 21);
            label5.TabIndex = 4;
            label5.Text = "TC Giriniz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(585, 220);
            label6.Name = "label6";
            label6.Size = new Size(346, 21);
            label6.TabIndex = 5;
            label6.Text = "Personel Adı, Departmanı ve İzin Durum Bilgileri ";
            // 
            // lstPersonelozlukBilgileri
            // 
            lstPersonelozlukBilgileri.FormattingEnabled = true;
            lstPersonelozlukBilgileri.ItemHeight = 21;
            lstPersonelozlukBilgileri.Location = new Point(576, 292);
            lstPersonelozlukBilgileri.Name = "lstPersonelozlukBilgileri";
            lstPersonelozlukBilgileri.Size = new Size(586, 319);
            lstPersonelozlukBilgileri.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(221, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(299, 29);
            comboBox1.TabIndex = 7;
            // 
            // txtNameSurname
            // 
            txtNameSurname.Location = new Point(805, 115);
            txtNameSurname.Name = "txtNameSurname";
            txtNameSurname.Size = new Size(343, 29);
            txtNameSurname.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(306, 29);
            textBox2.TabIndex = 9;
            // 
            // lstupdate
            // 
            lstupdate.Location = new Point(169, 416);
            lstupdate.Name = "lstupdate";
            lstupdate.Size = new Size(181, 55);
            lstupdate.TabIndex = 10;
            lstupdate.Text = "Güncelle";
            lstupdate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(973, 170);
            button1.Name = "button1";
            button1.Size = new Size(175, 39);
            button1.TabIndex = 11;
            button1.Text = "Personel getir";
            button1.UseVisualStyleBackColor = true;
            // 
            // MaasForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1174, 645);
            Controls.Add(button1);
            Controls.Add(lstupdate);
            Controls.Add(textBox2);
            Controls.Add(txtNameSurname);
            Controls.Add(comboBox1);
            Controls.Add(lstPersonelozlukBilgileri);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.DarkRed;
            Margin = new Padding(4);
            Name = "MaasForm";
            Text = "MaasForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private Label label2;
		private Label label4;
		private Label label5;
		private Label label6;
		private ListBox lstPersonelozlukBilgileri;
		private ComboBox comboBox1;
		private TextBox txtNameSurname;
		private TextBox textBox2;
		private Button lstupdate;
        private Button button1;
    }
}