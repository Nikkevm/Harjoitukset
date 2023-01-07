namespace Harjoitus4_NiklasVuorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SyntymaAikaDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuosinaLB.Text = Math.Floor(erotus / 365.25) + " vuotta";
            KuukausinaLB.Text = Math.Floor(erotus * 12 / 365.25) + " kuukautta";
            PaivinaLB.Text = erotus + " p‰iv‰‰";
            TunteinaLB.Text = erotus * 24 + " tunteina";
            MinuutteinaLB.Text = erotus * 24 * 60 + " minuutteina";
            SekunteinaLB.Text = erotus * 24 * 3600 + " sekunteina";
            VuosinaLB.Visible = true;
            KuukausinaLB.Visible = true;
            PaivinaLB.Visible = true;
            TunteinaLB.Visible = true;
            MinuutteinaLB.Visible = true;
            SekunteinaLB.Visible = true;
        }
    }
}