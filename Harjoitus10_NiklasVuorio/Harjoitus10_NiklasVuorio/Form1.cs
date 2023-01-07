namespace Harjoitus10_NiklasVuorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BMIBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);
            if (bmi < 18.5)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Aqua;
                kuvausLB.Text = "Alipaino";
                kuvausLB.ForeColor = Color.Aqua;
                kuvausLB.Visible = true;
            }
            else if (bmi < 25)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Green;
                kuvausLB.Text = "Normaalipaino";
                kuvausLB.ForeColor = Color.Green;
                kuvausLB.Visible = true;
            }
            else if(bmi < 40)
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Gold;
                kuvausLB.Text = "Ylipaino";
                kuvausLB.ForeColor = Color.Gold;
                kuvausLB.Visible = true;
            }
            else
            {
                BmiLB.Text = "Painoindeksisi on: " + bmi;
                BmiLB.ForeColor = Color.Red;
                kuvausLB.Text = "Huomattava ylipaino";
                kuvausLB.ForeColor = Color.Red;
                kuvausLB.Visible = true;
            }
        }
    }
}