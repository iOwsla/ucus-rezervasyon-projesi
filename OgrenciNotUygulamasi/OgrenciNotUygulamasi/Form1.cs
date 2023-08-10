namespace OgrenciNotUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            string soyad;
            int sinavI;
            int sinavII;
            int proje;
            double ortalama = 0.0;

            ad = this.ad.Text;
            soyad = this.soyad.Text;
            sinavI = Convert.ToInt32(this.sinav1.Text);
            sinavII = Convert.ToInt32(this.sinav2.Text);
            proje = Convert.ToInt32(this.proje.Text);

            ortalama = (sinavI + sinavII + proje) / 3;

            ortalamalar.Items.Add($"Ad: {ad} Soyad: {soyad} Ortalama: {ortalama}");


        }
    }
}