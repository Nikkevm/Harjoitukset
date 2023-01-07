namespace Harjoitus17_NiklasVuorio
{
    partial class NotepadForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TextTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.FontTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTSMI,
            this.OpenTSMI,
            this.SaveTSMI,
            this.toolStripMenuItem1,
            this.ExitTSMI});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.tiedostoToolStripMenuItem.Text = "&Tiedosto";
            // 
            // FontTSMI
            // 
            this.FontTSMI.Name = "FontTSMI";
            this.FontTSMI.Size = new System.Drawing.Size(67, 20);
            this.FontTSMI.Text = "&Muotoile";
            this.FontTSMI.Click += new System.EventHandler(this.FontTSMI_Click);
            // 
            // NewTSMI
            // 
            this.NewTSMI.Name = "NewTSMI";
            this.NewTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewTSMI.Size = new System.Drawing.Size(157, 22);
            this.NewTSMI.Text = "Uusi";
            this.NewTSMI.Click += new System.EventHandler(this.NewTSMI_Click);
            // 
            // OpenTSMI
            // 
            this.OpenTSMI.Name = "OpenTSMI";
            this.OpenTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenTSMI.Size = new System.Drawing.Size(157, 22);
            this.OpenTSMI.Text = "Avaa";
            this.OpenTSMI.Click += new System.EventHandler(this.OpenTSMI_Click);
            // 
            // SaveTSMI
            // 
            this.SaveTSMI.Name = "SaveTSMI";
            this.SaveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveTSMI.Size = new System.Drawing.Size(157, 22);
            this.SaveTSMI.Text = "Tallenna";
            this.SaveTSMI.Click += new System.EventHandler(this.SaveTSMI_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitTSMI.Size = new System.Drawing.Size(157, 22);
            this.ExitTSMI.Text = "Lopeta";
            this.ExitTSMI.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // TextTB
            // 
            this.TextTB.Location = new System.Drawing.Point(12, 27);
            this.TextTB.Name = "TextTB";
            this.TextTB.Size = new System.Drawing.Size(776, 411);
            this.TextTB.TabIndex = 1;
            this.TextTB.Text = "";
            // 
            // NotepadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NotepadForm";
            this.Text = "Muistio";
            this.Load += new System.EventHandler(this.NotepadForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem NewTSMI;
        private ToolStripMenuItem OpenTSMI;
        private ToolStripMenuItem SaveTSMI;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem ExitTSMI;
        private ToolStripMenuItem FontTSMI;
        private RichTextBox TextTB;
    }
}