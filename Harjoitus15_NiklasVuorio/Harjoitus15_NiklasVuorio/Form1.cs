using System.Diagnostics;

namespace Harjoitus15_NiklasVuorio
{
    public partial class Stopwatch_Form : Form
    {
        private Stopwatch stopWatch;
        public Stopwatch_Form()
        {
            InitializeComponent();
        }
        private void StartBT_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void StopTB_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void ResetTB_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void Stopwatch_Form_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void TimerTM_Tick(object sender, EventArgs e)
        {
            TimeLB.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }
    }
}