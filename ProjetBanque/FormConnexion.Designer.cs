﻿namespace ProjetBanque
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnexion));
            this.btnValide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.TextBox();
            this.Ville = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnValide
            // 
            this.btnValide.AccessibleName = "";
            this.btnValide.Location = new System.Drawing.Point(692, 430);
            this.btnValide.Margin = new System.Windows.Forms.Padding(4);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(165, 38);
            this.btnValide.TabIndex = 0;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue sur votre Banque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(212, 76);
            this.Nom.Margin = new System.Windows.Forms.Padding(4);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(137, 22);
            this.Nom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom";
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(212, 121);
            this.Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(137, 22);
            this.Prenom.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 185);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date de naissance";
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(212, 236);
            this.Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(136, 22);
            this.Adresse.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Code postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "ville";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "téléphone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 466);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mail";
            // 
            // CP
            // 
            this.CP.Location = new System.Drawing.Point(212, 290);
            this.CP.Margin = new System.Windows.Forms.Padding(4);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(137, 22);
            this.CP.TabIndex = 14;
            // 
            // Ville
            // 
            this.Ville.Location = new System.Drawing.Point(212, 345);
            this.Ville.Margin = new System.Windows.Forms.Padding(4);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(137, 22);
            this.Ville.TabIndex = 15;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(212, 405);
            this.Tel.Margin = new System.Windows.Forms.Padding(4);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(137, 22);
            this.Tel.TabIndex = 16;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(212, 463);
            this.Mail.Margin = new System.Windows.Forms.Padding(4);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(137, 22);
            this.Mail.TabIndex = 17;
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.btnValide;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormConnexion";
            this.Text = "Page d\'Inscription";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CP;
        private System.Windows.Forms.TextBox Ville;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Mail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

