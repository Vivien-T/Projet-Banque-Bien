namespace ProjetBanque
{
    partial class Formgestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.listboxclients = new System.Windows.Forms.CheckedListBox();
            this.confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veuillez sélectionner le client \r\nque vous souhaitez gérer :";
            // 
            // listboxclients
            // 
            this.listboxclients.FormattingEnabled = true;
            this.listboxclients.Location = new System.Drawing.Point(340, 55);
            this.listboxclients.Name = "listboxclients";
            this.listboxclients.Size = new System.Drawing.Size(448, 379);
            this.listboxclients.TabIndex = 3;
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(37, 320);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(191, 101);
            this.confirm.TabIndex = 4;
            this.confirm.Text = "Valider";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Formgestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.listboxclients);
            this.Controls.Add(this.label1);
            this.Name = "Formgestion";
            this.Text = "Gestion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formgestion_FormClosed);
            this.Load += new System.EventHandler(this.Formgestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox listboxclients;
        private System.Windows.Forms.Button confirm;
    }
}