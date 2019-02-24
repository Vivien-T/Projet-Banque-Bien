namespace ProjetBanque
{
    partial class FormMain
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
            this.Texte_Acceuil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texte_Acceuil
            // 
            this.Texte_Acceuil.AutoSize = true;
            this.Texte_Acceuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Texte_Acceuil.Location = new System.Drawing.Point(53, 13);
            this.Texte_Acceuil.Name = "Texte_Acceuil";
            this.Texte_Acceuil.Size = new System.Drawing.Size(102, 31);
            this.Texte_Acceuil.TabIndex = 0;
            this.Texte_Acceuil.Text = "Accueil";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Texte_Acceuil);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Texte_Acceuil;
    }
}