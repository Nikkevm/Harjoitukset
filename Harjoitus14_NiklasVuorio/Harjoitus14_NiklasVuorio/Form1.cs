using System.IO;

namespace Harjoitus14_NiklasVuorio
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// string variable to save the path of the diary file so it can be used in the program
        /// </summary>
        string diary_path = "../../../kirja.txt";
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(diary_path)) //check if file exists if not create it
            {
                var file = File.CreateText(diary_path);
                file.Close();
            }
            string text = File.ReadAllText(diary_path);
            inputTB.Text = text;
        }

        /// <summary>
        /// Saves the diary into the file adding date and time to the users input
        /// </summary>
        /// <param name="sender">object that triggered this</param>
        /// <param name="e">event arguments</param>
        private void SaveBT_Click(object sender, EventArgs e)
        {
            string text = "";
            text += inputTB.Text;
            text += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter TW_text = new StreamWriter(diary_path);
            TW_text.Write(text);
            TW_text.Close();
            Application.Exit();
        }
    }
}