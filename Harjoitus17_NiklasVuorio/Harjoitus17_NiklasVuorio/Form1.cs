namespace Harjoitus17_NiklasVuorio
{
    public partial class NotepadForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public NotepadForm()
        {
            InitializeComponent();
        }

        private void NewFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(TextTB.Text))
                {
                    MessageBox.Show("Sinun pitää tallentaa ensin");
                }
                else
                {
                    TextTB.Text = string.Empty;
                    Text = "Nimetön";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void SaveFile()
        {
            try
            {
                if (!string.IsNullOrEmpty(TextTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Tekstitiedoso | *.txt | Rich Text Format | *.rtf";
                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, TextTB.Text);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void OpenFile()
        {
            try
            {
                openFileDialog = new OpenFileDialog();

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }
            }
            catch
            {
                MessageBox.Show("Virhe avattaessa tiedostoa!");
            }
        }

        private void NewTSMI_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OpenTSMI_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void SaveTSMI_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void ExitTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(TextTB.Text))
                {
                    SaveFile();
                }
                else
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void FontTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                if(fontDialog.ShowDialog() == DialogResult.OK)
                {
                    TextTB.Font = fontDialog.Font;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe: " + ex);
            }
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }
    }
}