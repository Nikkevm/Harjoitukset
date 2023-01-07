namespace Harjoitus15_NiklasVuorio
{
    partial class Stopwatch_Form
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
            this.components = new System.ComponentModel.Container();
            this.TimerTM = new System.Windows.Forms.Timer(this.components);
            this.StartBT = new System.Windows.Forms.Button();
            this.TimeLB = new System.Windows.Forms.Label();
            this.ResetTB = new System.Windows.Forms.Button();
            this.StopTB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerTM
            // 
            this.TimerTM.Enabled = true;
            this.TimerTM.Tick += new System.EventHandler(this.TimerTM_Tick);
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBT.Location = new System.Drawing.Point(12, 108);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(80, 36);
            this.StartBT.TabIndex = 0;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Digital-7 Italic", 71.99999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TimeLB.Location = new System.Drawing.Point(12, 9);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(493, 96);
            this.TimeLB.TabIndex = 1;
            this.TimeLB.Text = "00:00:00:000";
            // 
            // ResetTB
            // 
            this.ResetTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetTB.Location = new System.Drawing.Point(426, 108);
            this.ResetTB.Name = "ResetTB";
            this.ResetTB.Size = new System.Drawing.Size(80, 36);
            this.ResetTB.TabIndex = 2;
            this.ResetTB.Text = "Reset";
            this.ResetTB.UseVisualStyleBackColor = true;
            this.ResetTB.Click += new System.EventHandler(this.ResetTB_Click);
            // 
            // StopTB
            // 
            this.StopTB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopTB.Location = new System.Drawing.Point(225, 108);
            this.StopTB.Name = "StopTB";
            this.StopTB.Size = new System.Drawing.Size(80, 36);
            this.StopTB.TabIndex = 3;
            this.StopTB.Text = "Stop";
            this.StopTB.UseVisualStyleBackColor = true;
            this.StopTB.Click += new System.EventHandler(this.StopTB_Click);
            // 
            // Stopwatch_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 157);
            this.Controls.Add(this.StopTB);
            this.Controls.Add(this.ResetTB);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.StartBT);
            this.Name = "Stopwatch_Form";
            this.Text = "Stopwatch";
            this.Load += new System.EventHandler(this.Stopwatch_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerTM;
        private Button StartBT;
        private Label TimeLB;
        private Button ResetTB;
        private Button StopTB;
    }
}