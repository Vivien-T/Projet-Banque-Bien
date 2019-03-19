namespace ProjetBanque
{
    partial class FormClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.intro = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NomClient = new System.Windows.Forms.Label();
            this.PrenomClient = new System.Windows.Forms.Label();
            this.DateNaissClient = new System.Windows.Forms.Label();
            this.AdresseClient = new System.Windows.Forms.Label();
            this.CPClient = new System.Windows.Forms.Label();
            this.VilleClient = new System.Windows.Forms.Label();
            this.TelClient = new System.Windows.Forms.Label();
            this.MailClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intro
            // 
            this.intro.AutoSize = true;
            this.intro.Location = new System.Drawing.Point(22, 9);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(529, 17);
            this.intro.TabIndex = 0;
            this.intro.Text = "Bienvenue cher client, pourriez-vous confirmer si vos informations sont correctes" +
    " ?";
            // 
            // Valider
            // 
            this.Valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Valider.Location = new System.Drawing.Point(520, 400);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(116, 38);
            this.Valider.TabIndex = 1;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // Retour
            // 
            this.Retour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Retour.Location = new System.Drawing.Point(660, 400);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(116, 38);
            this.Retour.TabIndex = 2;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date de Naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Code Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Téléphone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mail";
            // 
            // NomClient
            // 
            this.NomClient.AutoSize = true;
            this.NomClient.Location = new System.Drawing.Point(191, 74);
            this.NomClient.Name = "NomClient";
            this.NomClient.Size = new System.Drawing.Size(75, 17);
            this.NomClient.TabIndex = 12;
            this.NomClient.Text = "didn\'t work";
            // 
            // PrenomClient
            // 
            this.PrenomClient.AutoSize = true;
            this.PrenomClient.Location = new System.Drawing.Point(191, 123);
            this.PrenomClient.Name = "PrenomClient";
            this.PrenomClient.Size = new System.Drawing.Size(75, 17);
            this.PrenomClient.TabIndex = 13;
            this.PrenomClient.Text = "didn\'t work";
            // 
            // DateNaissClient
            // 
            this.DateNaissClient.AutoSize = true;
            this.DateNaissClient.Location = new System.Drawing.Point(191, 181);
            this.DateNaissClient.Name = "DateNaissClient";
            this.DateNaissClient.Size = new System.Drawing.Size(75, 17);
            this.DateNaissClient.TabIndex = 14;
            this.DateNaissClient.Text = "didn\'t work";
            // 
            // AdresseClient
            // 
            this.AdresseClient.AutoSize = true;
            this.AdresseClient.Location = new System.Drawing.Point(191, 233);
            this.AdresseClient.Name = "AdresseClient";
            this.AdresseClient.Size = new System.Drawing.Size(75, 17);
            this.AdresseClient.TabIndex = 15;
            this.AdresseClient.Text = "didn\'t work";
            // 
            // CPClient
            // 
            this.CPClient.AutoSize = true;
            this.CPClient.Location = new System.Drawing.Point(191, 279);
            this.CPClient.Name = "CPClient";
            this.CPClient.Size = new System.Drawing.Size(75, 17);
            this.CPClient.TabIndex = 16;
            this.CPClient.Text = "didn\'t work";
            // 
            // VilleClient
            // 
            this.VilleClient.AutoSize = true;
            this.VilleClient.Location = new System.Drawing.Point(517, 74);
            this.VilleClient.Name = "VilleClient";
            this.VilleClient.Size = new System.Drawing.Size(75, 17);
            this.VilleClient.TabIndex = 18;
            this.VilleClient.Text = "didn\'t work";
            // 
            // TelClient
            // 
            this.TelClient.AutoSize = true;
            this.TelClient.Location = new System.Drawing.Point(517, 123);
            this.TelClient.Name = "TelClient";
            this.TelClient.Size = new System.Drawing.Size(75, 17);
            this.TelClient.TabIndex = 19;
            this.TelClient.Text = "didn\'t work";
            // 
            // MailClient
            // 
            this.MailClient.AutoSize = true;
            this.MailClient.Location = new System.Drawing.Point(517, 181);
            this.MailClient.Name = "MailClient";
            this.MailClient.Size = new System.Drawing.Size(75, 17);
            this.MailClient.TabIndex = 20;
            this.MailClient.Text = "didn\'t work";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MailClient);
            this.Controls.Add(this.TelClient);
            this.Controls.Add(this.VilleClient);
            this.Controls.Add(this.CPClient);
            this.Controls.Add(this.AdresseClient);
            this.Controls.Add(this.DateNaissClient);
            this.Controls.Add(this.PrenomClient);
            this.Controls.Add(this.NomClient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.intro);
            this.Name = "FormClient";
            this.Text = "Page Client Compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intro;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label NomClient;
        private System.Windows.Forms.Label PrenomClient;
        private System.Windows.Forms.Label DateNaissClient;
        private System.Windows.Forms.Label AdresseClient;
        private System.Windows.Forms.Label CPClient;
        private System.Windows.Forms.Label VilleClient;
        private System.Windows.Forms.Label TelClient;
        private System.Windows.Forms.Label MailClient;
    }
}