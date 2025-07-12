namespace Uçak_Bilet_Rezarvasyon_Sistemi
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox2 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 265);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 30);
            label9.Name = "label9";
            label9.Size = new Size(134, 28);
            label9.TabIndex = 11;
            label9.Text = "Yönü Değiştir";
            // 
            // button2
            // 
            button2.Location = new Point(317, 74);
            button2.Name = "button2";
            button2.Size = new Size(134, 35);
            button2.TabIndex = 4;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak", "" });
            comboBox1.Location = new Point(108, 45);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 54);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 9;
            label1.Text = "Nereden:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(108, 161);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 34);
            dateTimePicker1.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(108, 205);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(151, 34);
            maskedTextBox2.TabIndex = 7;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Ankara", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "İstanbul", "İzmir", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şanlıurfa", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak", "" });
            comboBox2.Location = new Point(108, 100);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 36);
            comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 211);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 3;
            label4.Text = "Zaman:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 161);
            label3.Name = "label3";
            label3.Size = new Size(60, 28);
            label3.TabIndex = 2;
            label3.Text = "Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 103);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(946, 28);
            label10.Name = "label10";
            label10.Size = new Size(74, 28);
            label10.TabIndex = 12;
            label10.Text = "label10";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(654, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 265);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(213, 200);
            button1.Name = "button1";
            button1.Size = new Size(215, 39);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(213, 103);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(215, 34);
            maskedTextBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 161);
            label7.Name = "label7";
            label7.Size = new Size(176, 28);
            label7.TabIndex = 9;
            label7.Text = "Telefon Numarası:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 103);
            label6.Name = "label6";
            label6.Size = new Size(193, 28);
            label6.TabIndex = 8;
            label6.Text = "TC Kimlik Numarası:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(213, 152);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(215, 34);
            maskedTextBox3.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 34);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 51);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 4;
            label5.Text = "Yolcu Ad - Soyad:";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(192, 255, 255);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(12, 422);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1076, 116);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 95);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(821, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.Location = new Point(3, 10);
            label8.Name = "label8";
            label8.Size = new Size(287, 46);
            label8.TabIndex = 0;
            label8.Text = "Uzay Hava Yolları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1100, 550);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "ss";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox2;
        private Label label5;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private ListBox listBox1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button2;
        private Label label10;
    }
}
