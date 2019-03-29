namespace ProjetBanque
{
    partial class FormOperation
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
            this.comptecourant = new System.Windows.Forms.CheckBox();
            this.livret = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.montantoperation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValidOperation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comptecourant
            // 
            this.comptecourant.AutoSize = true;
            this.comptecourant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comptecourant.Location = new System.Drawing.Point(99, 62);
            this.comptecourant.Name = "comptecourant";
            this.comptecourant.Size = new System.Drawing.Size(152, 20);
            this.comptecourant.TabIndex = 0;
            this.comptecourant.Text = "Mon Compte Courant";
            this.comptecourant.UseVisualStyleBackColor = true;
            // 
            // livret
            // 
            this.livret.AutoSize = true;
            this.livret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livret.Location = new System.Drawing.Point(379, 62);
            this.livret.Name = "livret";
            this.livret.Size = new System.Drawing.Size(100, 20);
            this.livret.TabIndex = 1;
            this.livret.Text = "Mon Livret A";
            this.livret.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Depuis quel compte souhaitez-vous effectuer votre opération ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Veuillez choisir le montant \r\nsouhaité pour l\'opération :";
            // 
            // montantoperation
            // 
            this.montantoperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantoperation.Location = new System.Drawing.Point(309, 178);
            this.montantoperation.MaxLength = 10;
            this.montantoperation.Multiline = true;
            this.montantoperation.Name = "montantoperation";
            this.montantoperation.Size = new System.Drawing.Size(132, 40);
            this.montantoperation.TabIndex = 4;
            this.montantoperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 64);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vu qu\'on gère pas à qui \r\nenvoyer l\'argent et tout \r\nvous avez plus qu\'à \r\nappuye" +
    "r sur ce bouton :";
            // 
            // ValidOperation
            // 
            this.ValidOperation.Font = new System.Drawing.Font("Impact", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidOperation.Location = new System.Drawing.Point(617, 364);
            this.ValidOperation.Name = "ValidOperation";
            this.ValidOperation.Size = new System.Drawing.Size(137, 64);
            this.ValidOperation.TabIndex = 6;
            this.ValidOperation.Text = "GET RICH !";
            this.ValidOperation.UseVisualStyleBackColor = true;
            this.ValidOperation.Click += new System.EventHandler(this.ValidOperation_Click);
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ValidOperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montantoperation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.livret);
            this.Controls.Add(this.comptecourant);
            this.Name = "FormOperation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox comptecourant;
        private System.Windows.Forms.CheckBox livret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montantoperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ValidOperation;
    }
}