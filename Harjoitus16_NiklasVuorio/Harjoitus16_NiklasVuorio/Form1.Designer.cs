namespace Harjoitus16_NiklasVuorio
{
    partial class AjastinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MinuteCB = new System.Windows.Forms.ComboBox();
            this.SecondCB = new System.Windows.Forms.ComboBox();
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.TimerTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minuutit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(124, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit";
            // 
            // MinuteCB
            // 
            this.MinuteCB.FormattingEnabled = true;
            this.MinuteCB.Location = new System.Drawing.Point(12, 44);
            this.MinuteCB.Name = "MinuteCB";
            this.MinuteCB.Size = new System.Drawing.Size(106, 23);
            this.MinuteCB.TabIndex = 2;
            // 
            // SecondCB
            // 
            this.SecondCB.FormattingEnabled = true;
            this.SecondCB.Location = new System.Drawing.Point(126, 44);
            this.SecondCB.Name = "SecondCB";
            this.SecondCB.Size = new System.Drawing.Size(106, 23);
            this.SecondCB.TabIndex = 3;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLB.Location = new System.Drawing.Point(25, 70);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(191, 86);
            this.TimeLB.TabIndex = 4;
            this.TimeLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartBT.Location = new System.Drawing.Point(12, 159);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(106, 52);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StopBT.Location = new System.Drawing.Point(126, 159);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(106, 52);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // TimerTM
            // 
            this.TimerTM.Tick += new System.EventHandler(this.TimerTM_Tick);
            // 
            // AjastinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 239);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.SecondCB);
            this.Controls.Add(this.MinuteCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjastinForm";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.AjastinForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox MinuteCB;
        private ComboBox SecondCB;
        private Label TimeLB;
        private Button StartBT;
        private Button StopBT;
        private System.Windows.Forms.Timer TimerTM;
    }
}