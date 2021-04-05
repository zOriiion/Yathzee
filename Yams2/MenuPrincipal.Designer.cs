
namespace Yams2
{
    partial class MenuPrincipal
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.comboNbrJoueur = new System.Windows.Forms.ComboBox();
            this.inputJoueur1 = new System.Windows.Forms.TextBox();
            this.inputJoueur2 = new System.Windows.Forms.TextBox();
            this.inputJoueur3 = new System.Windows.Forms.TextBox();
            this.inputJoueur4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(74, 38);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(144, 20);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Nombre de joueurs :";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(189, 90);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(94, 29);
            this.buttonValider.TabIndex = 1;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // comboNbrJoueur
            // 
            this.comboNbrJoueur.FormattingEnabled = true;
            this.comboNbrJoueur.Location = new System.Drawing.Point(241, 38);
            this.comboNbrJoueur.Name = "comboNbrJoueur";
            this.comboNbrJoueur.Size = new System.Drawing.Size(42, 28);
            this.comboNbrJoueur.TabIndex = 2;
            // 
            // inputJoueur1
            //
            this.inputJoueur1.Location = new System.Drawing.Point(74, 151);
            this.inputJoueur1.Name = "inputJoueur1";
            this.inputJoueur1.Size = new System.Drawing.Size(144, 27);
            this.inputJoueur1.TabIndex = 3;
            // 
            // inputJoueur2
            // 
            this.inputJoueur2.Location = new System.Drawing.Point(74, 184);
            this.inputJoueur2.Name = "inputJoueur2";
            this.inputJoueur2.Size = new System.Drawing.Size(144, 27);
            this.inputJoueur2.TabIndex = 4;
            // 
            // inputJoueur3
            // 
            this.inputJoueur3.Location = new System.Drawing.Point(74, 217);
            this.inputJoueur3.Name = "inputJoueur3";
            this.inputJoueur3.Size = new System.Drawing.Size(144, 27);
            this.inputJoueur3.TabIndex = 5;
            // 
            // inputJoueur4
            // 
            this.inputJoueur4.Location = new System.Drawing.Point(74, 251);
            this.inputJoueur4.Name = "inputJoueur4";
            this.inputJoueur4.Size = new System.Drawing.Size(144, 27);
            this.inputJoueur4.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(295, 410);
            this.Controls.Add(this.inputJoueur4);
            this.Controls.Add(this.inputJoueur3);
            this.Controls.Add(this.inputJoueur2);
            this.Controls.Add(this.inputJoueur1);
            this.Controls.Add(this.comboNbrJoueur);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.labelMenu);
            this.MaximumSize = new System.Drawing.Size(313, 457);
            this.MinimumSize = new System.Drawing.Size(313, 457);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ComboBox comboNbrJoueur;
        private System.Windows.Forms.TextBox inputJoueur1;
        private System.Windows.Forms.TextBox inputJoueur2;
        private System.Windows.Forms.TextBox inputJoueur3;
        private System.Windows.Forms.TextBox inputJoueur4;
    }
}

