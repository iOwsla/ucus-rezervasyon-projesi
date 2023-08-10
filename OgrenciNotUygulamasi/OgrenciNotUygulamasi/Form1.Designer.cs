namespace OgrenciNotUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            ad = new TextBox();
            soyad = new TextBox();
            sinav1 = new TextBox();
            sinav2 = new TextBox();
            proje = new TextBox();
            pictureBox1 = new PictureBox();
            ortalamalar = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(40, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 73);
            label2.Name = "label2";
            label2.Size = new Size(67, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 148);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 2;
            label3.Text = "Proje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 148);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 3;
            label4.Text = "Sınav 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 148);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 4;
            label5.Text = "Sınav 1";
            // 
            // button1
            // 
            button1.Location = new Point(324, 384);
            button1.Name = "button1";
            button1.Size = new Size(113, 36);
            button1.TabIndex = 5;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ad
            // 
            ad.Location = new Point(76, 12);
            ad.Name = "ad";
            ad.Size = new Size(220, 29);
            ad.TabIndex = 6;
            // 
            // soyad
            // 
            soyad.Location = new Point(76, 67);
            soyad.Name = "soyad";
            soyad.Size = new Size(220, 29);
            soyad.TabIndex = 7;
            // 
            // sinav1
            // 
            sinav1.Location = new Point(12, 174);
            sinav1.Name = "sinav1";
            sinav1.Size = new Size(95, 29);
            sinav1.TabIndex = 8;
            // 
            // sinav2
            // 
            sinav2.Location = new Point(181, 174);
            sinav2.Name = "sinav2";
            sinav2.Size = new Size(96, 29);
            sinav2.TabIndex = 9;
            // 
            // proje
            // 
            proje.Location = new Point(341, 174);
            proje.Name = "proje";
            proje.Size = new Size(96, 29);
            proje.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(344, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ortalamalar
            // 
            ortalamalar.FormattingEnabled = true;
            ortalamalar.ItemHeight = 23;
            ortalamalar.Location = new Point(9, 213);
            ortalamalar.Name = "ortalamalar";
            ortalamalar.Size = new Size(428, 165);
            ortalamalar.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 428);
            Controls.Add(ortalamalar);
            Controls.Add(pictureBox1);
            Controls.Add(proje);
            Controls.Add(sinav2);
            Controls.Add(sinav1);
            Controls.Add(button1);
            Controls.Add(soyad);
            Controls.Add(ad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox ad;
        private TextBox soyad;
        private TextBox sinav1;
        private TextBox sinav2;
        private TextBox proje;
        private PictureBox pictureBox1;
        private ListBox ortalamalar;
    }
}