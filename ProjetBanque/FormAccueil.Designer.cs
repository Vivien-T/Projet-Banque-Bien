namespace ProjetBanque
{
    partial class FormAccueil
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
            this.message_accueil = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.ask = new System.Windows.Forms.Button();
            this.soldecomptemsg = new System.Windows.Forms.Label();
            this.soldecompte = new System.Windows.Forms.Label();
            this.soldelivretmsg = new System.Windows.Forms.Label();
            this.soldelivret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message_accueil
            // 
            this.message_accueil.AutoSize = true;
            this.message_accueil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_accueil.Location = new System.Drawing.Point(9, 7);
            this.message_accueil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.message_accueil.Name = "message_accueil";
            this.message_accueil.Size = new System.Drawing.Size(300, 18);
            this.message_accueil.TabIndex = 0;
            this.message_accueil.Text = "Bienvenue Mr. [Nom] [Prénom] !\r\n";
            // 
            // send
            // 
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.Location = new System.Drawing.Point(411, 335);
            this.send.Margin = new System.Windows.Forms.Padding(2);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(90, 80);
            this.send.TabIndex = 1;
            this.send.Text = "Envoyer de l\'argent";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // ask
            // 
            this.ask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ask.Location = new System.Drawing.Point(563, 335);
            this.ask.Margin = new System.Windows.Forms.Padding(2);
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(90, 80);
            this.ask.TabIndex = 2;
            this.ask.Text = "Demander de l\'argent";
            this.ask.UseVisualStyleBackColor = true;
            this.ask.Click += new System.EventHandler(this.ask_Click);
            // 
            // soldecomptemsg
            // 
            this.soldecomptemsg.AutoSize = true;
            this.soldecomptemsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.soldecomptemsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldecomptemsg.Location = new System.Drawing.Point(10, 98);
            this.soldecomptemsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soldecomptemsg.Name = "soldecomptemsg";
            this.soldecomptemsg.Size = new System.Drawing.Size(351, 54);
            this.soldecomptemsg.TabIndex = 3;
            this.soldecomptemsg.Text = "Votre solde de compte courant est \r\nactuellement de :";
            // 
            // soldecompte
            // 
            this.soldecompte.AutoSize = true;
            this.soldecompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldecompte.Location = new System.Drawing.Point(404, 115);
            this.soldecompte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soldecompte.Name = "soldecompte";
            this.soldecompte.Size = new System.Drawing.Size(111, 37);
            this.soldecompte.TabIndex = 4;
            this.soldecompte.Text = "[solde]";
            // 
            // soldelivretmsg
            // 
            this.soldelivretmsg.AutoSize = true;
            this.soldelivretmsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.soldelivretmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldelivretmsg.Location = new System.Drawing.Point(10, 205);
            this.soldelivretmsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soldelivretmsg.Name = "soldelivretmsg";
            this.soldelivretmsg.Size = new System.Drawing.Size(268, 54);
            this.soldelivretmsg.TabIndex = 5;
            this.soldelivretmsg.Text = "Votre solde de livret A est \r\nactuellement de :";
            // 
            // soldelivret
            // 
            this.soldelivret.AutoSize = true;
            this.soldelivret.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldelivret.Location = new System.Drawing.Point(404, 222);
            this.soldelivret.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soldelivret.Name = "soldelivret";
            this.soldelivret.Size = new System.Drawing.Size(111, 37);
            this.soldelivret.TabIndex = 6;
            this.soldelivret.Text = "[solde]";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 477);
            this.Controls.Add(this.soldelivret);
            this.Controls.Add(this.soldelivretmsg);
            this.Controls.Add(this.soldecompte);
            this.Controls.Add(this.soldecomptemsg);
            this.Controls.Add(this.ask);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message_accueil);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAccueil";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message_accueil;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button ask;
        private System.Windows.Forms.Label soldecomptemsg;
        private System.Windows.Forms.Label soldecompte;
        private System.Windows.Forms.Label soldelivretmsg;
        private System.Windows.Forms.Label soldelivret;
    }
}