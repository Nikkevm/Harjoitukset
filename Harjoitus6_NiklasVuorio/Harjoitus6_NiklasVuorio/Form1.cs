namespace Harjoitus6_NiklasVuorio
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Niklas" && SalasanaTB.Text == "salasana123")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;
            }
            else
            {
                VirheviestiLB.Text = "K�ytt�j�tunnus tai salasana on virheellinen";
                VirheviestiLB.Visible = true;
            }
        }
    }
}