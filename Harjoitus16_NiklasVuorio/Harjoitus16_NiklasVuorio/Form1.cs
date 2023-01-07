using System.Diagnostics;

namespace Harjoitus16_NiklasVuorio
{
    public partial class AjastinForm : Form
    {
        private int totaltime;
        public AjastinForm()
        {
            InitializeComponent();
        }

        private void AjastinForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for(int i = 0; i < 60; i++)
            {
                MinuteCB.Items.Add(i.ToString());
                SecondCB.Items.Add(i.ToString());
            }
            MinuteCB.SelectedIndex = 30;
            SecondCB.SelectedIndex = 0;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minutes = int.Parse(MinuteCB.SelectedIndex.ToString());
            int seconds = int.Parse(SecondCB.SelectedIndex.ToString());
            totaltime = (minutes * 60) + seconds;
            TimerTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            totaltime = 0;
            TimerTM.Enabled = false;
            TimeLB.Text = "00:00";
        }

        private void TimerTM_Tick(object sender, EventArgs e)
        {
            if(totaltime > 0)
            {
                totaltime--;
                int minutes = totaltime / 60;
                int seconds = totaltime - (minutes * 60);
                TimeLB.Text = minutes.ToString() + ":" + seconds.ToString();
            }
            else
            {
                TimerTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}