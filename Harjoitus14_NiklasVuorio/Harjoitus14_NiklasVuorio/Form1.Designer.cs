namespace Harjoitus14_NiklasVuorio
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
            this.inputTB = new System.Windows.Forms.RichTextBox();
            this.SaveBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTB.Location = new System.Drawing.Point(12, 12);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(776, 331);
            this.inputTB.TabIndex = 0;
            this.inputTB.Text = "";
            // 
            // SaveBT
            // 
            this.SaveBT.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveBT.Location = new System.Drawing.Point(12, 349);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(776, 89);
            this.SaveBT.TabIndex = 1;
            this.SaveBT.Text = "Tallenna päiväkirja";
            this.SaveBT.UseVisualStyleBackColor = true;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.inputTB);
            this.Name = "Form1";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox inputTB;
        private Button SaveBT;
    }
}