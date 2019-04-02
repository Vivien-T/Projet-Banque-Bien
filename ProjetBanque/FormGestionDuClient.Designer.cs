namespace ProjetBanque
{
    partial class FormGestionDuClient
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
            this.delete = new System.Windows.Forms.Button();
            this.argcompte = new System.Windows.Forms.TextBox();
            this.arglivret = new System.Windows.Forms.TextBox();
            this.valide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Location = new System.Drawing.Point(371, 396);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 62);
            this.delete.TabIndex = 0;
            this.delete.Text = "Supprimer le client";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // argcompte
            // 
            this.argcompte.Location = new System.Drawing.Point(136, 204);
            this.argcompte.Multiline = true;
            this.argcompte.Name = "argcompte";
            this.argcompte.Size = new System.Drawing.Size(127, 48);
            this.argcompte.TabIndex = 1;
            this.argcompte.Text = "error";
            // 
            // arglivret
            // 
            this.arglivret.Location = new System.Drawing.Point(593, 204);
            this.arglivret.Multiline = true;
            this.arglivret.Name = "arglivret";
            this.arglivret.Size = new System.Drawing.Size(127, 48);
            this.arglivret.TabIndex = 2;
            this.arglivret.Text = "error";
            // 
            // valide
            // 
            this.valide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valide.Location = new System.Drawing.Point(669, 396);
            this.valide.Name = "valide";
            this.valide.Size = new System.Drawing.Size(128, 62);
            this.valide.TabIndex = 3;
            this.valide.Text = "Valider";
            this.valide.UseVisualStyleBackColor = true;
            this.valide.Click += new System.EventHandler(this.valide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gestion du client:  [nom] [prénom]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Argent disponible sur le\r\n compte du client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "argent disponible sur le \r\nLivret A du client!";
            // 
            // FormGestionDuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valide);
            this.Controls.Add(this.arglivret);
            this.Controls.Add(this.argcompte);
            this.Controls.Add(this.delete);
            this.Name = "FormGestionDuClient";
            this.Text = "Administration du client";
            this.Load += new System.EventHandler(this.FormGestionDuClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox argcompte;
        private System.Windows.Forms.TextBox arglivret;
        private System.Windows.Forms.Button valide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}