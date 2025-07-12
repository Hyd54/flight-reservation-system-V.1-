using System.Linq.Expressions;

namespace Uçak_Bilet_Rezarvasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Uçuş Bilgileri:   " + "Nereden: " + comboBox1.Text + " - Nereye: " + comboBox2.Text + " - Tarih: " + dateTimePicker1.Text + " - Zaman: " + maskedTextBox2.Text);
            listBox1.Items.Add("Yolcu Bilgileri:  " + "Ad - Soyad: " + textBox1.Text + " - TC Kimlik Numarası: " + maskedTextBox1.Text + " - Telefon Numarası: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı!!\nİyi Yolculuklar Dileriz :)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label10.Text;
        }
    }
}
