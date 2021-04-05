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
    public partial class FormJeu : Form
    {
        public int nombreJoueur;
        public String[] nomDesJoueurs;
        Joueurs[] joueur;
        int numeroLance = 1;
        int joueurEnCours = 1;
        MenuPrincipal menuPrincipal;

        public FormJeu()
        {
            InitializeComponent();
        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            joueur = new Joueurs[nombreJoueur];

            if(nombreJoueur == 1)
            {
                joueur[0] = new Joueurs(nomDesJoueurs[0]);
            }

            if (nombreJoueur == 2)
            {
                joueur[0] = new Joueurs(nomDesJoueurs[0]);
                joueur[1] = new Joueurs(nomDesJoueurs[1]);
            }

            if (nombreJoueur == 3)
            {
                joueur[0] = new Joueurs(nomDesJoueurs[0]);
                joueur[1] = new Joueurs(nomDesJoueurs[1]);
                joueur[2] = new Joueurs(nomDesJoueurs[2]);
            }

            if (nombreJoueur == 4)
            {
                joueur[0] = new Joueurs(nomDesJoueurs[0]);
                joueur[1] = new Joueurs(nomDesJoueurs[1]);
                joueur[2] = new Joueurs(nomDesJoueurs[2]);
                joueur[3] = new Joueurs(nomDesJoueurs[3]);
            }

            numeroLance = 1;
            joueurEnCours = 1;

            labelJoueurTour.Text = "Au tour de " + joueur[0].GetName;

            labelTotal.BackColor = Color.FromArgb(205, 217, 110);
            labelTotal1.BackColor = Color.FromArgb(205, 217, 110);
            labelTotal2.BackColor = Color.FromArgb(205, 217, 110);
            labelTotal3.BackColor = Color.FromArgb(205, 217, 110);
            labelBonus.BackColor = Color.FromArgb(255, 255, 136);

            pictureBoxDesUn.Left = ((this.ClientSize.Width - pictureBoxDesUn.Width) / 2) - 180;
            pictureBoxDesUn.Top = ((this.ClientSize.Height - pictureBoxDesUn.Height) / 2) - 120;

            pictureBoxDesDeux.Left = ((this.ClientSize.Width - pictureBoxDesDeux.Width) / 2) - 90;
            pictureBoxDesDeux.Top = ((this.ClientSize.Height - pictureBoxDesDeux.Height) / 2) - 50;

            pictureBoxDesTrois.Left = (this.ClientSize.Width - pictureBoxDesTrois.Width) / 2;
            pictureBoxDesTrois.Top = ((this.ClientSize.Height - pictureBoxDesTrois.Height) / 2) - 120;

            pictureBoxDesQuatre.Left = ((this.ClientSize.Width - pictureBoxDesQuatre.Width) / 2) + 90;
            pictureBoxDesQuatre.Top = ((this.ClientSize.Height - pictureBoxDesQuatre.Height) / 2) - 50;

            pictureBoxDesCinq.Left = ((this.ClientSize.Width - pictureBoxDesCinq.Width) / 2) + 180;
            pictureBoxDesCinq.Top = ((this.ClientSize.Height - pictureBoxDesCinq.Height) / 2) - 120;

            buttonRoll.FlatStyle = FlatStyle.Flat;
            buttonRoll.FlatAppearance.BorderSize = 0;
            buttonRoll.Left = ((this.ClientSize.Width - buttonRoll.Width) / 2);
            buttonRoll.Top = ((this.ClientSize.Height - buttonRoll.Height) / 2) + 100;

            buttonAsMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonAsMid.FlatStyle = FlatStyle.Flat;
            buttonAsMid.FlatAppearance.BorderSize = 0;

            buttonDeuxMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonDeuxMid.FlatStyle = FlatStyle.Flat;
            buttonDeuxMid.FlatAppearance.BorderSize = 0;

            buttonTroisMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonTroisMid.FlatStyle = FlatStyle.Flat;
            buttonTroisMid.FlatAppearance.BorderSize = 0;

            buttonQuatreMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonQuatreMid.FlatStyle = FlatStyle.Flat;
            buttonQuatreMid.FlatAppearance.BorderSize = 0;

            buttonCinqMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonCinqMid.FlatStyle = FlatStyle.Flat;
            buttonCinqMid.FlatAppearance.BorderSize = 0;

            buttonSixMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonSixMid.FlatStyle = FlatStyle.Flat;
            buttonSixMid.FlatAppearance.BorderSize = 0;

            buttonBrelanMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonBrelanMid.FlatStyle = FlatStyle.Flat;
            buttonBrelanMid.FlatAppearance.BorderSize = 0;

            buttonCarreMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonCarreMid.FlatStyle = FlatStyle.Flat;
            buttonCarreMid.FlatAppearance.BorderSize = 0;

            buttonFullMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonFullMid.FlatStyle = FlatStyle.Flat;
            buttonFullMid.FlatAppearance.BorderSize = 0;

            buttonPetSuiteMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonPetSuiteMid.FlatStyle = FlatStyle.Flat;
            buttonPetSuiteMid.FlatAppearance.BorderSize = 0;

            buttonGrdSuiteMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonGrdSuiteMid.FlatStyle = FlatStyle.Flat;
            buttonGrdSuiteMid.FlatAppearance.BorderSize = 0;

            buttonYamsMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonYamsMid.FlatStyle = FlatStyle.Flat;
            buttonYamsMid.FlatAppearance.BorderSize = 0;

            buttonChanceMid.BackColor = Color.FromArgb(255, 255, 136);
            buttonChanceMid.FlatStyle = FlatStyle.Flat;
            buttonChanceMid.FlatAppearance.BorderSize = 0;

        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            if (CheckPartieFini() == false)
            {
                if (numeroLance == 1)
                {
                    buttonRoll.Text = "Lancer 2";
                    joueur[joueurEnCours - 1].RollAll();
                    ChangeAllDes();
                    numeroLance++;
                }
                else
                {
                    buttonRoll.Text = "Lancer 3";

                    if (joueur[joueurEnCours - 1].GetLockUn == false)
                    {
                        joueur[joueurEnCours - 1].RollUn();
                        ChangeDesUn();
                    }
                    if (joueur[joueurEnCours - 1].GetLockDeux == false)
                    {
                        joueur[joueurEnCours - 1].RollDeux();
                        ChangeDesDeux();
                    }
                    if (joueur[joueurEnCours - 1].GetLockTrois == false)
                    {
                        joueur[joueurEnCours - 1].RollTrois();
                        ChangeDesTrois();
                    }
                    if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                    {
                        joueur[joueurEnCours - 1].RollQuatre();
                        ChangeDesQuatre();
                    }
                    if (joueur[joueurEnCours - 1].GetLockCinq == false)
                    {
                        joueur[joueurEnCours - 1].RollCinq();
                        ChangeDesCinq();
                    }

                    numeroLance++;
                }
                if (numeroLance == 4)
                {
                    joueur[joueurEnCours - 1].UnlockUn();
                    joueur[joueurEnCours - 1].UnlockDeux();
                    joueur[joueurEnCours - 1].UnlockTrois();
                    joueur[joueurEnCours - 1].UnlockQuatre();
                    joueur[joueurEnCours - 1].UnlockCinq();

                    ChangeAllDes();

                    buttonRoll.Enabled = false;
                }
            }
            else
            {
                
            }
        }

        private void ChangeAllDes()
        {
            ChangeDesUn();
            ChangeDesDeux();
            ChangeDesTrois();
            ChangeDesQuatre();
            ChangeDesCinq();
        }

        private void ChangeDesUn()
        {
            if (joueur[joueurEnCours - 1].GetDesUn == 0)
            {
                pictureBoxDesUn.Image = Properties.Resources.DesBlank;
            }
            if (joueur[joueurEnCours - 1].GetDesUn == 1)
            {
                if (joueur[joueurEnCours - 1].GetLockUn == false)
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesUn;
                }
                else
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesUnBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesUn == 2)
            {
                if (joueur[joueurEnCours - 1].GetLockUn == false)
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesDeux;
                }
                else
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesDeuxBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesUn == 3)
            {
                if (joueur[joueurEnCours - 1].GetLockUn == false)
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesTrois;
                }
                else
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesTroisBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesUn == 4)
            {
                if (joueur[joueurEnCours - 1].GetLockUn == false)
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesQuatre;
                }
                else
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesQuatreBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesUn == 5)
            {
                if (joueur[joueurEnCours - 1].GetLockUn == false)
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesCinq;
                }
                else
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesCinqBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesUn == 6)
            {
                if (joueur[joueurEnCours - 1].GetLockUn == false)
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesSix;
                }
                else
                {
                    pictureBoxDesUn.Image = Properties.Resources.DesSixBlock;
                }
            }
        }

        private void ChangeDesDeux()
        {
            if (joueur[joueurEnCours - 1].GetDesDeux == 0)
            {
                pictureBoxDesDeux.Image = Properties.Resources.DesBlank;
            }
            if (joueur[joueurEnCours - 1].GetDesDeux == 1)
            {
                if (joueur[joueurEnCours - 1].GetLockDeux == false)
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesUn;
                }
                else
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesUnBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesDeux == 2)
            {
                if (joueur[joueurEnCours - 1].GetLockDeux == false)
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesDeux;
                }
                else
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesDeuxBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesDeux == 3)
            {
                if (joueur[joueurEnCours - 1].GetLockDeux == false)
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesTrois;
                }
                else
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesTroisBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesDeux == 4)
            {
                if (joueur[joueurEnCours - 1].GetLockDeux == false)
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesQuatre;
                }
                else
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesQuatreBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesDeux == 5)
            {
                if (joueur[joueurEnCours - 1].GetLockDeux == false)
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesCinq;
                }
                else
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesCinqBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesDeux == 6)
            {
                if (joueur[joueurEnCours - 1].GetLockDeux == false)
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesSix;
                }
                else
                {
                    pictureBoxDesDeux.Image = Properties.Resources.DesSixBlock;
                }
            }
        }

        private void ChangeDesTrois()
        {
            if (joueur[joueurEnCours - 1].GetDesTrois == 0)
            {
                pictureBoxDesTrois.Image = Properties.Resources.DesBlank;
            }
            if (joueur[joueurEnCours - 1].GetDesTrois == 1)
            {
                if (joueur[joueurEnCours - 1].GetLockTrois == false)
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesUn;
                }
                else
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesUnBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesTrois == 2)
            {
                if (joueur[joueurEnCours - 1].GetLockTrois == false)
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesDeux;
                }
                else
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesDeuxBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesTrois == 3)
            {
                if (joueur[joueurEnCours - 1].GetLockTrois == false)
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesTrois;
                }
                else
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesTroisBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesTrois == 4)
            {
                if (joueur[joueurEnCours - 1].GetLockTrois == false)
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesQuatre   ;
                }
                else
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesQuatreBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesTrois == 5)
            {
                if (joueur[joueurEnCours - 1].GetLockTrois == false)
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesCinq;
                }
                else
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesCinqBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesTrois == 6)
            {
                if (joueur[joueurEnCours - 1].GetLockTrois == false)
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesSix;
                }
                else
                {
                    pictureBoxDesTrois.Image = Properties.Resources.DesSixBlock;
                }
            }
        }

        private void ChangeDesQuatre()
        {
            if (joueur[joueurEnCours - 1].GetDesQuatre == 0)
            {
                pictureBoxDesQuatre.Image = Properties.Resources.DesBlank;
            }
            if (joueur[joueurEnCours - 1].GetDesQuatre == 1)
            {
                if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesUn;
                }
                else
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesUnBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesQuatre == 2)
            {
                if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesDeux;
                }
                else
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesDeuxBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesQuatre == 3)
            {
                if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesTrois;
                }
                else
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesTroisBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesQuatre == 4)
            {
                if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesQuatre;
                }
                else
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesQuatreBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesQuatre == 5)
            {
                if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesCinq;
                }
                else
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesCinqBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesQuatre == 6)
            {
                if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesSix;
                }
                else
                {
                    pictureBoxDesQuatre.Image = Properties.Resources.DesSixBlock;
                }
            }
        }

        private void ChangeDesCinq()
        {
            if (joueur[joueurEnCours - 1].GetDesCinq == 0)
            {
                pictureBoxDesCinq.Image = Properties.Resources.DesBlank;
            }
            if (joueur[joueurEnCours - 1].GetDesCinq == 1)
            {
                if (joueur[joueurEnCours - 1].GetLockCinq == false)
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesUn;
                }
                else
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesUnBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesCinq == 2)
            {
                if (joueur[joueurEnCours - 1].GetLockCinq == false)
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesDeux;
                }
                else
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesDeuxBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesCinq == 3)
            {
                if (joueur[joueurEnCours - 1].GetLockCinq == false)
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesTrois;
                }
                else
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesTroisBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesCinq == 4)
            {
                if (joueur[joueurEnCours - 1].GetLockCinq == false)
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesQuatre;
                }
                else
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesQuatreBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesCinq == 5)
            {
                if (joueur[joueurEnCours - 1].GetLockCinq == false)
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesCinq;
                }
                else
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesCinqBlock;
                }
            }
            if (joueur[joueurEnCours - 1].GetDesCinq == 6)
            {
                if (joueur[joueurEnCours - 1].GetLockCinq == false)
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesSix;
                }
                else
                {
                    pictureBoxDesCinq.Image = Properties.Resources.DesSixBlock;
                }
            }
        }

        private void pictureBoxDesUn_Click(object sender, EventArgs e)
        {
            if(numeroLance != 1 && numeroLance != 4)
            {
                if (joueur[joueurEnCours - 1].GetLockUn == false)
                {
                    joueur[joueurEnCours - 1].LockUn();
                }
                else
                {
                    joueur[joueurEnCours - 1].UnlockUn();
                }
                ChangeDesUn();
            }
        }

        private void pictureBoxDesDeux_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1 && numeroLance != 4)
            {
                if (joueur[joueurEnCours - 1].GetLockDeux == false)
                {
                    joueur[joueurEnCours - 1].LockDeux();
                }
                else
                {
                    joueur[joueurEnCours - 1].UnlockDeux();
                }
                ChangeDesDeux();
            }
        }

        private void pictureBoxDesTrois_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1 && numeroLance != 4)
            {
                if (joueur[joueurEnCours - 1].GetLockTrois == false)
                {
                    joueur[joueurEnCours - 1].LockTrois();
                }
                else
                {
                    joueur[joueurEnCours - 1].UnlockTrois();
                }
                ChangeDesTrois();
            }
        }

        private void pictureBoxDesQuatre_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1 && numeroLance != 4)
            {
                if (joueur[joueurEnCours - 1].GetLockQuatre == false)
                {
                    joueur[joueurEnCours - 1].LockQuatre();
                }
                else
                {
                    joueur[joueurEnCours - 1].UnlockQuatre();
                }
                ChangeDesQuatre();
            }
        }

        private void pictureBoxDesCinq_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1 && numeroLance != 4)
            {
                if (joueur[joueurEnCours - 1].GetLockCinq == false)
                {
                    joueur[joueurEnCours - 1].LockCinq();
                }
                else
                {
                    joueur[joueurEnCours - 1].UnlockCinq();
                }
                ChangeDesCinq();
            }
        }

        private void buttonAsMid_Click(object sender, EventArgs e)
        {
            if(numeroLance != 1){
                joueur[joueurEnCours - 1].SetDicoAs();

                if (joueur[joueurEnCours - 1].GetDicoAs != 0)
                {
                    buttonAsMid.Text = joueur[joueurEnCours - 1].GetDicoAs.ToString();
                }
                else
                {
                    buttonAsMid.Text = "X";
                }
                ChangeTotal();
                ChangeBonus();
                ChangeTotal1();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonDeuxMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoDeux();

                if (joueur[joueurEnCours - 1].GetDicoDeux != 0)
                {
                    buttonDeuxMid.Text = joueur[joueurEnCours - 1].GetDicoDeux.ToString();
                }
                else
                {
                    buttonDeuxMid.Text = "X";
                }
                ChangeTotal();
                ChangeBonus();
                ChangeTotal1();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonTroisMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoTrois();

                if (joueur[joueurEnCours - 1].GetDicoTrois != 0)
                {
                    buttonTroisMid.Text = joueur[joueurEnCours - 1].GetDicoTrois.ToString();
                }
                else
                {
                    buttonTroisMid.Text = "X";
                }
                ChangeTotal();
                ChangeBonus();
                ChangeTotal1();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonQuatreMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoQuatre();

                if (joueur[joueurEnCours - 1].GetDicoQuatre != 0)
                {
                    buttonQuatreMid.Text = joueur[joueurEnCours - 1].GetDicoQuatre.ToString();
                }
                else
                {
                    buttonQuatreMid.Text = "X";
                }
                ChangeTotal();
                ChangeBonus();
                ChangeTotal1();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonCinqMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoCinq();

                if (joueur[joueurEnCours - 1].GetDicoCinq != 0)
                {
                    buttonCinqMid.Text = joueur[joueurEnCours - 1].GetDicoCinq.ToString();
                }
                else
                {
                    buttonCinqMid.Text = "X";
                }
                ChangeTotal();
                ChangeBonus();
                ChangeTotal1();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonSixMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoSix();

                if (joueur[joueurEnCours - 1].GetDicoSix != 0)
                {
                    buttonSixMid.Text = joueur[joueurEnCours - 1].GetDicoSix.ToString();
                }
                else
                {
                    buttonSixMid.Text = "X";
                }
                ChangeTotal();
                ChangeBonus();
                ChangeTotal1();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonBrelanMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoBrelan();

                if (joueur[joueurEnCours - 1].GetDicoBrelan != 0)
                {
                    buttonBrelanMid.Text = joueur[joueurEnCours - 1].GetDicoBrelan.ToString();
                }
                else
                {
                    buttonBrelanMid.Text = "X";
                }
                ChangeTotal2();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonCarreMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoCarre();

                if (joueur[joueurEnCours - 1].GetDicoCarre != 0)
                {
                    buttonCarreMid.Text = joueur[joueurEnCours - 1].GetDicoCarre.ToString();
                }
                else
                {
                    buttonCarreMid.Text = "X";
                }
                ChangeTotal2();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonFullMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoFull();

                if (joueur[joueurEnCours - 1].GetDicoFull != 0)
                {
                    buttonFullMid.Text = joueur[joueurEnCours - 1].GetDicoFull.ToString();
                }
                else
                {
                    buttonFullMid.Text = "X";
                }
                ChangeTotal2();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonPetSuiteMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoPetSuite();

                if (joueur[joueurEnCours - 1].GetDicoPetSuite != 0)
                {
                    buttonPetSuiteMid.Text = joueur[joueurEnCours - 1].GetDicoPetSuite.ToString();
                }
                else
                {
                    buttonPetSuiteMid.Text = "X";
                }
                ChangeTotal2();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonGrdSuiteMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoGrdSuite();

                if (joueur[joueurEnCours - 1].GetDicoGrdSuite != 0)
                {
                    buttonGrdSuiteMid.Text = joueur[joueurEnCours - 1].GetDicoGrdSuite.ToString();
                }
                else
                {
                    buttonGrdSuiteMid.Text = "X";
                }
                ChangeTotal2();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonYamsMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoYams();

                if (joueur[joueurEnCours - 1].GetDicoYams != 0)
                {
                    buttonYamsMid.Text = joueur[joueurEnCours - 1].GetDicoYams.ToString();
                }
                else
                {
                    buttonYamsMid.Text = "X";
                }
                ChangeTotal2();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void buttonChanceMid_Click(object sender, EventArgs e)
        {
            if (numeroLance != 1)
            {
                joueur[joueurEnCours - 1].SetDicoChance();

                if (joueur[joueurEnCours - 1].GetDicoChance != 0)
                {
                    buttonChanceMid.Text = joueur[joueurEnCours - 1].GetDicoChance.ToString();
                }
                else
                {
                    buttonChanceMid.Text = "X";
                }
                ChangeTotal2();
                ChangeTotal3();
                ChangementJoueur();
            }
        }

        private void ChangeTotal()
        {
            joueur[joueurEnCours - 1].SetDicoTotal();
            labelTotal.Text = joueur[joueurEnCours - 1].GetDicoTotal.ToString();
        }

        private void ChangeTotal1()
        {
            joueur[joueurEnCours - 1].SetDicoTotal1();
            labelTotal1.Text = joueur[joueurEnCours - 1].GetDicoTotal1.ToString();
        }

        private void ChangeTotal2()
        {
            joueur[joueurEnCours - 1].SetDicoTotal2();
            labelTotal2.Text = joueur[joueurEnCours - 1].GetDicoTotal2.ToString();
        }

        private void ChangeTotal3()
        {
            joueur[joueurEnCours - 1].SetDicoTotal3();
            labelTotal3.Text = joueur[joueurEnCours - 1].GetDicoTotal3.ToString();
        }

        private void ChangeBonus()
        {
            joueur[joueurEnCours - 1].SetDicoBonus();
            labelBonus.Text = joueur[joueurEnCours - 1].GetDicoBonus.ToString();
        }


        private void ChangementJoueur()
        {
            if (CheckPartieFini() == false)
            {
                if (joueurEnCours == nombreJoueur)
                {
                    joueurEnCours = 1;
                }
                else
                {
                    joueurEnCours++;
                }
                labelJoueurTour.Text = "Au tour de " + joueur[joueurEnCours - 1].GetName;

                joueur[joueurEnCours - 1].ResetDes();

                ChangeAllDes();

                numeroLance = 1;

                buttonRoll.Text = "Lancer 1";
                buttonRoll.Enabled = true;

                ChangementTable();
            }
            else
            {
                PartieFini();
            }
        }

        private void ChangementTable()
        {
            if(joueur[joueurEnCours - 1].GetStatusAs == false)
            {
                buttonAsMid.Text = "";
                buttonAsMid.Enabled = true;
            }
            else
            {
                buttonAsMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoAs == 0)
                {
                    buttonAsMid.Text = "X";
                }
                else
                {
                    buttonAsMid.Text = joueur[joueurEnCours - 1].GetDicoAs.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusDeux == false)
            {
                buttonDeuxMid.Text = "";
                buttonDeuxMid.Enabled = true;
            }
            else
            {
                buttonDeuxMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoDeux == 0)
                {
                    buttonDeuxMid.Text = "X";
                }
                else
                {
                    buttonDeuxMid.Text = joueur[joueurEnCours - 1].GetDicoDeux.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusTrois == false)
            {
                buttonTroisMid.Text = "";
                buttonTroisMid.Enabled = true;
            }
            else
            {
                buttonTroisMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoTrois == 0)
                {
                    buttonTroisMid.Text = "X";
                }
                else
                {
                    buttonTroisMid.Text = joueur[joueurEnCours - 1].GetDicoTrois.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusQuatre == false)
            {
                buttonQuatreMid.Text = "";
                buttonQuatreMid.Enabled = true;
            }
            else
            {
                buttonQuatreMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoQuatre == 0)
                {
                    buttonQuatreMid.Text = "X";
                }
                else
                {
                    buttonQuatreMid.Text = joueur[joueurEnCours - 1].GetDicoQuatre.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusCinq == false)
            {
                buttonCinqMid.Text = "";
                buttonCinqMid.Enabled = true;
            }
            else
            {
                buttonCinqMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoCinq == 0)
                {
                    buttonCinqMid.Text = "X";
                }
                else
                {
                    buttonCinqMid.Text = joueur[joueurEnCours - 1].GetDicoCinq.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusSix == false)
            {
                buttonSixMid.Text = "";
                buttonSixMid.Enabled = true;
            }
            else
            {
                buttonSixMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoSix == 0)
                {
                    buttonSixMid.Text = "X";
                }
                else
                {
                    buttonSixMid.Text = joueur[joueurEnCours - 1].GetDicoSix.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusBrelan == false)
            {
                buttonBrelanMid.Text = "";
                buttonBrelanMid.Enabled = true;
            }
            else
            {
                buttonBrelanMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoBrelan == 0)
                {
                    buttonBrelanMid.Text = "X";
                }
                else
                {
                    buttonBrelanMid.Text = joueur[joueurEnCours - 1].GetDicoBrelan.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusCarre == false)
            {
                buttonCarreMid.Text = "";
                buttonCarreMid.Enabled = true;
            }
            else
            {
                buttonCarreMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoCarre == 0)
                {
                    buttonCarreMid.Text = "X";
                }
                else
                {
                    buttonCarreMid.Text = joueur[joueurEnCours - 1].GetDicoCarre.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusFull == false)
            {
                buttonFullMid.Text = "";
                buttonFullMid.Enabled = true;
            }
            else
            {
                buttonFullMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoFull == 0)
                {
                    buttonFullMid.Text = "X";
                }
                else
                {
                    buttonFullMid.Text = joueur[joueurEnCours - 1].GetDicoFull.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusPetSuite == false)
            {
                buttonPetSuiteMid.Text = "";
                buttonPetSuiteMid.Enabled = true;
            }
            else
            {
                buttonPetSuiteMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoPetSuite == 0)
                {
                    buttonPetSuiteMid.Text = "X";
                }
                else
                {
                    buttonPetSuiteMid.Text = joueur[joueurEnCours - 1].GetDicoPetSuite.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusGrdSuite == false)
            {
                buttonGrdSuiteMid.Text = "";
                buttonGrdSuiteMid.Enabled = true;
            }
            else
            {
                buttonGrdSuiteMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoGrdSuite == 0)
                {
                    buttonGrdSuiteMid.Text = "X";
                }
                else
                {
                    buttonGrdSuiteMid.Text = joueur[joueurEnCours - 1].GetDicoGrdSuite.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusYams == false)
            {
                buttonYamsMid.Text = "";
                buttonYamsMid.Enabled = true;
            }
            else
            {
                buttonYamsMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoYams == 0)
                {
                    buttonYamsMid.Text = "X";
                }
                else
                {
                    buttonYamsMid.Text = joueur[joueurEnCours - 1].GetDicoYams.ToString();
                }
            }

            if (joueur[joueurEnCours - 1].GetStatusChance == false)
            {
                buttonChanceMid.Text = "";
                buttonChanceMid.Enabled = true;
            }
            else
            {
                buttonChanceMid.Enabled = false;

                if (joueur[joueurEnCours - 1].GetDicoChance == 0)
                {
                    buttonChanceMid.Text = "X";
                }
                else
                {
                    buttonChanceMid.Text = joueur[joueurEnCours - 1].GetDicoChance.ToString();
                }
            }

            ChangeTotal();
            ChangeBonus();
            ChangeTotal1();
            ChangeTotal2();
            ChangeTotal3();
        }

        private bool CheckPartieFini()
        {
            if(joueur[nombreJoueur - 1].GetStatusAs == true && joueur[nombreJoueur - 1].GetStatusDeux == true 
                && joueur[nombreJoueur - 1].GetStatusTrois == true && joueur[nombreJoueur - 1].GetStatusQuatre == true 
                && joueur[nombreJoueur - 1].GetStatusCinq == true && joueur[nombreJoueur - 1].GetStatusSix == true
                && joueur[nombreJoueur - 1].GetStatusBrelan == true && joueur[nombreJoueur - 1].GetStatusCarre == true
                && joueur[nombreJoueur - 1].GetStatusFull == true && joueur[nombreJoueur - 1].GetStatusPetSuite == true
                && joueur[nombreJoueur - 1].GetStatusGrdSuite == true && joueur[nombreJoueur - 1].GetStatusYams == true
                && joueur[nombreJoueur - 1].GetStatusChance == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PartieFini()
        {
            pictureBoxDesUn.Top = ((this.ClientSize.Height - pictureBoxDesUn.Height) / 2) - 200;

            pictureBoxDesDeux.Top = ((this.ClientSize.Height - pictureBoxDesDeux.Height) / 2) - 130;

            pictureBoxDesTrois.Top = ((this.ClientSize.Height - pictureBoxDesTrois.Height) / 2) - 200;

            pictureBoxDesQuatre.Top = ((this.ClientSize.Height - pictureBoxDesQuatre.Height) / 2) - 130;

            pictureBoxDesCinq.Top = ((this.ClientSize.Height - pictureBoxDesCinq.Height) / 2) - 200;

            labelJoueurTour.Top = (this.ClientSize.Height - labelJoueurTour.Height) / 2;

            buttonRoll.Top = ((this.ClientSize.Height - buttonRoll.Height) / 2) + 200;
            buttonRoll.Text = "Retour au menu";

            if (nombreJoueur == 1)
            {
                labelJoueurTour.Text = "Partie terminé, points : " + joueur[0].GetDicoTotal3;
            }

            if (nombreJoueur == 2)
            {
                if (joueur[0].GetDicoTotal3 == joueur[1].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité, points : " + joueur[0].GetDicoTotal3;
                }
                if (joueur[0].GetDicoTotal3 > joueur[1].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 1 a gagné, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3;
                }
                else
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 2 a gagné, points : " + joueur[1].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[0].GetDicoTotal3;
                }
            }

            if (nombreJoueur == 3)
            {
                if (joueur[0].GetDicoTotal3 == joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 == joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité, points : " + joueur[0].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 et 2, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[1].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 et 3, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[1].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[0].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 2 et 3, points : " + joueur[1].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 > joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 1 a gagné, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[1].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 2 a gagné, points : " + joueur[1].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[2].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[2].GetDicoTotal3 > joueur[1].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 3 a gagné, points : " + joueur[2].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3;
                }
            }

            if (nombreJoueur == 4)
            {
                if (joueur[0].GetDicoTotal3 == joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[0].GetDicoTotal3 == joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité, points : " + joueur[0].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 2 et 3, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 4 : " + joueur[3].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 == joueur[3].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 2 et 4, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[0].GetDicoTotal3 == joueur[3].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[1].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 3 et 4, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3;
                }

                if (joueur[1].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[1].GetDicoTotal3 == joueur[3].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[0].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 2 3 et 4, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[2].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 et 2, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3 + "\n Points joueur 4 : " + joueur[3].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 et 3, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3 + "\n Points joueur 4 : " + joueur[3].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 == joueur[3].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 1 et 4, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[1].GetDicoTotal3 == joueur[2].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 2 et 3, points : " + joueur[1].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 4 : " + joueur[3].GetDicoTotal3;
                }

                if (joueur[1].GetDicoTotal3 == joueur[3].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 2 et 4, points : " + joueur[1].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3;
                }

                if (joueur[2].GetDicoTotal3 == joueur[3].GetDicoTotal3 && joueur[2].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[2].GetDicoTotal3 > joueur[1].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, égalité entre Joueur 3 et 4, points : " + joueur[2].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3;
                }

                if (joueur[0].GetDicoTotal3 > joueur[1].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[2].GetDicoTotal3 && joueur[0].GetDicoTotal3 > joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 1 a gagné, points : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3 + "\n Points joueur 4 : " + joueur[3].GetDicoTotal3;
                }

                if (joueur[1].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[2].GetDicoTotal3 && joueur[1].GetDicoTotal3 > joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 2 a gagné, points : " + joueur[1].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3 + "\n Points joueur 4 : " + joueur[3].GetDicoTotal3;
                }

                if (joueur[2].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[2].GetDicoTotal3 > joueur[1].GetDicoTotal3 && joueur[2].GetDicoTotal3 > joueur[3].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 3 a gagné, points : " + joueur[2].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3 + "\n Points joueur 4 : " + joueur[3].GetDicoTotal3;
                }

                if (joueur[3].GetDicoTotal3 > joueur[0].GetDicoTotal3 && joueur[3].GetDicoTotal3 > joueur[1].GetDicoTotal3 && joueur[3].GetDicoTotal3 > joueur[2].GetDicoTotal3)
                {
                    labelJoueurTour.Text = "Partie terminé, Joueur 4 a gagné, points : " + joueur[3].GetDicoTotal3 + "\n Points joueur 1 : " + joueur[0].GetDicoTotal3 + "\n Points joueur 2 : " + joueur[1].GetDicoTotal3 + "\n Points joueur 3 : " + joueur[2].GetDicoTotal3;
                }
            }
        }
    }
}
