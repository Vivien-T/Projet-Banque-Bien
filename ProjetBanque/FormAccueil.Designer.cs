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
            this.soldemsg = new System.Windows.Forms.Label();
            this.solde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message_accueil
            // 
            this.message_accueil.AutoSize = true;
            this.message_accueil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_accueil.Location = new System.Drawing.Point(12, 9);
            this.message_accueil.Name = "message_accueil";
            this.message_accueil.Size = new System.Drawing.Size(383, 25);
            this.message_accueil.TabIndex = 0;
            this.message_accueil.Text = "Bienvenue Mr. [Nom] [Prénom] !\r\n";
            // 
            // send
            // 
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.Location = new System.Drawing.Point(402, 281);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(120, 99);
            this.send.TabIndex = 1;
            this.send.Text = "Envoyer de l\'argent";
            this.send.UseVisualStyleBackColor = true;
            // 
            // ask
            // 
            this.ask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ask.Location = new System.Drawing.Point(578, 281);
            this.ask.Name = "ask";
            this.ask.Size = new System.Drawing.Size(120, 99);
            this.ask.TabIndex = 2;
            this.ask.Text = "Demander de l\'argent";
            this.ask.UseVisualStyleBackColor = true;
            // 
            // soldemsg
            // 
            this.soldemsg.AutoSize = true;
            this.soldemsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.soldemsg.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldemsg.Location = new System.Drawing.Point(14, 121);
            this.soldemsg.Name = "soldemsg";
            this.soldemsg.Size = new System.Drawing.Size(204, 62);
            this.soldemsg.TabIndex = 3;
            this.soldemsg.Text = "Votre solde est \r\nactuellement de :";
            // 
            // solde
            // 
            this.solde.AutoSize = true;
            this.solde.Font = new System.Drawing.Font("OpenSymbol", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solde.Location = new System.Drawing.Point(263, 130);
            this.solde.Name = "solde";
            this.solde.Size = new System.Drawing.Size(113, 40);
            this.solde.TabIndex = 4;
            this.solde.Text = "[solde]";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solde);
            this.Controls.Add(this.soldemsg);
            this.Controls.Add(this.ask);
            this.Controls.Add(this.send);
            this.Controls.Add(this.message_accueil);
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
        private System.Windows.Forms.Label soldemsg;
        private System.Windows.Forms.Label solde;
    }
}