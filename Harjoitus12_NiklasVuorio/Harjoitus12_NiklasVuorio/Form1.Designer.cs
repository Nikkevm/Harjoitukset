namespace Harjoitus12_NiklasVuorio
{
    partial class Form1
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DRB = new System.Windows.Forms.RadioButton();
            this.CRB = new System.Windows.Forms.RadioButton();
            this.BRB = new System.Windows.Forms.RadioButton();
            this.ARB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KysymysLB.Location = new System.Drawing.Point(12, 9);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(212, 25);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(12, 121);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(76, 25);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DRB);
            this.groupBox1.Controls.Add(this.CRB);
            this.groupBox1.Controls.Add(this.BRB);
            this.groupBox1.Controls.Add(this.ARB);
            this.groupBox1.Location = new System.Drawing.Point(249, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            // 
            // DRB
            // 
            this.DRB.AutoSize = true;
            this.DRB.Location = new System.Drawing.Point(6, 97);
            this.DRB.Name = "DRB";
            this.DRB.Size = new System.Drawing.Size(33, 19);
            this.DRB.TabIndex = 3;
            this.DRB.Text = "D";
            this.DRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            this.CRB.AutoSize = true;
            this.CRB.Location = new System.Drawing.Point(6, 72);
            this.CRB.Name = "CRB";
            this.CRB.Size = new System.Drawing.Size(33, 19);
            this.CRB.TabIndex = 2;
            this.CRB.Text = "C";
            this.CRB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            this.BRB.AutoSize = true;
            this.BRB.Location = new System.Drawing.Point(6, 47);
            this.BRB.Name = "BRB";
            this.BRB.Size = new System.Drawing.Size(32, 19);
            this.BRB.TabIndex = 1;
            this.BRB.Text = "B";
            this.BRB.UseVisualStyleBackColor = true;
            // 
            // ARB
            // 
            this.ARB.AutoSize = true;
            this.ARB.Location = new System.Drawing.Point(6, 22);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(33, 19);
            this.ARB.TabIndex = 0;
            this.ARB.Text = "A";
            this.ARB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 158);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox groupBox1;
        private RadioButton DRB;
        private RadioButton CRB;
        private RadioButton BRB;
        private RadioButton ARB;
    }
}