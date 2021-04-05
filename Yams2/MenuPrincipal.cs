using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yams2
{
    public partial class MenuPrincipal : Form
    {
        bool nbrJoueurValide = false;
        FormJeu formJeu = new FormJeu();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            inputJoueur1.Visible = false;
            inputJoueur2.Visible = false;
            inputJoueur3.Visible = false;
            inputJoueur4.Visible = false;

            labelMenu.Top = ((this.ClientSize.Height - labelMenu.Height) / 2) - 100;
            labelMenu.Left = (this.ClientSize.Width - labelMenu.Width) / 2;

            comboNbrJoueur.Top = (this.ClientSize.Height - comboNbrJoueur.Height) / 2;
            comboNbrJoueur.Left = (this.ClientSize.Width - comboNbrJoueur.Width) / 2;

            buttonValider.Top = ((this.ClientSize.Height - buttonValider.Height) / 2) + 100;
            buttonValider.Left = (this.ClientSize.Width - buttonValider.Width) / 2;

            comboNbrJoueur.DropDownStyle = ComboBoxStyle.DropDownList;

            Dictionary<string, int> comboValue = new Dictionary<string, int>();
            comboValue.Add("1", 1);
            comboValue.Add("2", 2);
            comboValue.Add("3", 3);
            comboValue.Add("4", 4);

            comboNbrJoueur.DataSource = new BindingSource(comboValue, null);
            comboNbrJoueur.DisplayMember = "Value";
            comboNbrJoueur.ValueMember = "Key";
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            if (nbrJoueurValide == false)
            {
                nbrJoueurValide = true;

                comboNbrJoueur.Visible = false;

                inputJoueur1.Left = (this.ClientSize.Width - inputJoueur1.Width) / 2;
                inputJoueur2.Left = (this.ClientSize.Width - inputJoueur2.Width) / 2;
                inputJoueur3.Left = (this.ClientSize.Width - inputJoueur3.Width) / 2;
                inputJoueur4.Left = (this.ClientSize.Width - inputJoueur4.Width) / 2;

                labelMenu.Text = "Nom des joueurs : ";

                formJeu.nombreJoueur = ((KeyValuePair<string, int>)comboNbrJoueur.SelectedItem).Value;

                switch (formJeu.nombreJoueur)
                {
                    case 1:

                        labelMenu.Text = "Nom du joueur : ";

                        inputJoueur1.Visible = true;
                        inputJoueur1.Top = (this.ClientSize.Height - inputJoueur1.Height) / 2;
                        
                        break;

                    case 2:

                        inputJoueur1.Visible = true;
                        inputJoueur1.Top = ((this.ClientSize.Height - inputJoueur1.Height) / 2) - 30;

                        inputJoueur2.Visible = true;
                        inputJoueur2.Top = ((this.ClientSize.Height - inputJoueur2.Height) / 2) + 30;

                        labelMenu.Top = ((this.ClientSize.Height - labelMenu.Height) / 2) - 90;

                        buttonValider.Top = ((this.ClientSize.Height - buttonValider.Height) / 2) + 90;

                        break;

                    case 3:

                        inputJoueur1.Visible = true;
                        inputJoueur1.Top = ((this.ClientSize.Height - inputJoueur1.Height) / 2) - 50;

                        inputJoueur2.Visible = true;
                        inputJoueur2.Top = (this.ClientSize.Height - inputJoueur2.Height) / 2;

                        inputJoueur3.Visible = true;
                        inputJoueur3.Top = ((this.ClientSize.Height - inputJoueur3.Height) / 2) + 50;

                        labelMenu.Top = ((this.ClientSize.Height - labelMenu.Height) / 2) - 100;

                        buttonValider.Top = ((this.ClientSize.Height - buttonValider.Height) / 2) + 100;

                        break;

                    case 4:

                        inputJoueur1.Visible = true;
                        inputJoueur1.Top = ((this.ClientSize.Height - inputJoueur1.Height) / 2) - 75;

                        inputJoueur2.Visible = true;
                        inputJoueur2.Top = ((this.ClientSize.Height - inputJoueur2.Height) / 2) - 25;

                        inputJoueur3.Visible = true;
                        inputJoueur3.Top = ((this.ClientSize.Height - inputJoueur3.Height) / 2) + 25;

                        inputJoueur4.Visible = true;
                        inputJoueur4.Top = ((this.ClientSize.Height - inputJoueur3.Height) / 2) + 75;

                        labelMenu.Top = ((this.ClientSize.Height - labelMenu.Height) / 2) - 125;

                        buttonValider.Top = ((this.ClientSize.Height - buttonValider.Height) / 2) + 125;
                        inputJoueur4.Visible = true;

                        break;
                } 
            }
            else
            {
                switch (formJeu.nombreJoueur)
                {
                    case 1:

                        formJeu.nomDesJoueurs = new string[1];
                        formJeu.nomDesJoueurs[0] = inputJoueur1.Text;

                        break;
                        
                    case 2:

                        formJeu.nomDesJoueurs = new string[2];
                        formJeu.nomDesJoueurs[0] = inputJoueur1.Text;
                        formJeu.nomDesJoueurs[1] = inputJoueur2.Text;

                        break;

                    case 3:

                        formJeu.nomDesJoueurs = new string[3];
                        formJeu.nomDesJoueurs[0] = inputJoueur1.Text;
                        formJeu.nomDesJoueurs[1] = inputJoueur2.Text;
                        formJeu.nomDesJoueurs[2] = inputJoueur2.Text;

                        break;

                    case 4:

                        formJeu.nomDesJoueurs = new string[4];
                        formJeu.nomDesJoueurs[0] = inputJoueur1.Text;
                        formJeu.nomDesJoueurs[1] = inputJoueur2.Text;
                        formJeu.nomDesJoueurs[2] = inputJoueur2.Text;
                        formJeu.nomDesJoueurs[3] = inputJoueur2.Text;

                        break;
                }

                formJeu.ShowDialog();
            }
        }

        public void Fini()
        {
            this.Close();
        }
    }
}
