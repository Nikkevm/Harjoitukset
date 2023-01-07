namespace Harjoitus18_NiklasVuorio
{
    partial class KeypeopleForm
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
            this.LocationCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressLB = new System.Windows.Forms.Label();
            this.PostalLB = new System.Windows.Forms.Label();
            this.CityLB = new System.Windows.Forms.Label();
            this.PhoneLB = new System.Windows.Forms.Label();
            this.TitleLB = new System.Windows.Forms.Label();
            this.SijaintiLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PersonphoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LocationCB
            // 
            this.LocationCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationCB.FormattingEnabled = true;
            this.LocationCB.Location = new System.Drawing.Point(12, 78);
            this.LocationCB.Name = "LocationCB";
            this.LocationCB.Size = new System.Drawing.Size(121, 29);
            this.LocationCB.TabIndex = 0;
            this.LocationCB.SelectedIndexChanged += new System.EventHandler(this.LocationCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // PersonCB
            // 
            this.PersonCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonCB.FormattingEnabled = true;
            this.PersonCB.Location = new System.Drawing.Point(247, 78);
            this.PersonCB.Name = "PersonCB";
            this.PersonCB.Size = new System.Drawing.Size(174, 29);
            this.PersonCB.TabIndex = 3;
            this.PersonCB.SelectedIndexChanged += new System.EventHandler(this.PersonCB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(247, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valitse vastuuhenkilö";
            // 
            // AddressLB
            // 
            this.AddressLB.AutoSize = true;
            this.AddressLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressLB.Location = new System.Drawing.Point(12, 122);
            this.AddressLB.Name = "AddressLB";
            this.AddressLB.Size = new System.Drawing.Size(55, 21);
            this.AddressLB.TabIndex = 5;
            this.AddressLB.Text = "Osoite";
            // 
            // PostalLB
            // 
            this.PostalLB.AutoSize = true;
            this.PostalLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PostalLB.Location = new System.Drawing.Point(12, 157);
            this.PostalLB.Name = "PostalLB";
            this.PostalLB.Size = new System.Drawing.Size(98, 21);
            this.PostalLB.TabIndex = 6;
            this.PostalLB.Text = "Postinumero";
            // 
            // CityLB
            // 
            this.CityLB.AutoSize = true;
            this.CityLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityLB.Location = new System.Drawing.Point(12, 192);
            this.CityLB.Name = "CityLB";
            this.CityLB.Size = new System.Drawing.Size(75, 21);
            this.CityLB.TabIndex = 7;
            this.CityLB.Text = "Kaupunki";
            // 
            // PhoneLB
            // 
            this.PhoneLB.AutoSize = true;
            this.PhoneLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneLB.Location = new System.Drawing.Point(12, 225);
            this.PhoneLB.Name = "PhoneLB";
            this.PhoneLB.Size = new System.Drawing.Size(62, 21);
            this.PhoneLB.TabIndex = 8;
            this.PhoneLB.Text = "Puhelin";
            // 
            // TitleLB
            // 
            this.TitleLB.AutoSize = true;
            this.TitleLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLB.Location = new System.Drawing.Point(247, 122);
            this.TitleLB.Name = "TitleLB";
            this.TitleLB.Size = new System.Drawing.Size(48, 21);
            this.TitleLB.TabIndex = 9;
            this.TitleLB.Text = "Titteli";
            // 
            // SijaintiLB
            // 
            this.SijaintiLB.AutoSize = true;
            this.SijaintiLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SijaintiLB.Location = new System.Drawing.Point(247, 157);
            this.SijaintiLB.Name = "SijaintiLB";
            this.SijaintiLB.Size = new System.Drawing.Size(57, 21);
            this.SijaintiLB.TabIndex = 10;
            this.SijaintiLB.Text = "Sijainti";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLB.Location = new System.Drawing.Point(247, 192);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(87, 21);
            this.EmailLB.TabIndex = 11;
            this.EmailLB.Text = "Sähköposti";
            // 
            // PersonphoneLB
            // 
            this.PersonphoneLB.AutoSize = true;
            this.PersonphoneLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonphoneLB.Location = new System.Drawing.Point(247, 225);
            this.PersonphoneLB.Name = "PersonphoneLB";
            this.PersonphoneLB.Size = new System.Drawing.Size(62, 21);
            this.PersonphoneLB.TabIndex = 12;
            this.PersonphoneLB.Text = "Puhelin";
            // 
            // KeypeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 265);
            this.Controls.Add(this.PersonphoneLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.SijaintiLB);
            this.Controls.Add(this.TitleLB);
            this.Controls.Add(this.PhoneLB);
            this.Controls.Add(this.CityLB);
            this.Controls.Add(this.PostalLB);
            this.Controls.Add(this.AddressLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PersonCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocationCB);
            this.Name = "KeypeopleForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.KeypeopleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox LocationCB;
        private Label label1;
        private Label label2;
        private ComboBox PersonCB;
        private Label label3;
        private Label AddressLB;
        private Label PostalLB;
        private Label CityLB;
        private Label PhoneLB;
        private Label TitleLB;
        private Label SijaintiLB;
        private Label EmailLB;
        private Label PersonphoneLB;
    }
}