using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotequeYams;

namespace Yams2
{
    class Joueurs
    {
        String name;
        Des[] des;
        Dictionary<String, int> scores;
        int[] tabScore;
        Scores getScore = new Scores();

        int[] chiffreDes;

        public Joueurs(String name)
        {
            this.name = name;
            des = new Des[5];
            des[0] = new Des();
            des[1] = new Des();
            des[2] = new Des();
            des[3] = new Des();
            des[4] = new Des();

            scores = new Dictionary<string, int>();

            scores.Add("As", 0);
            scores.Add("Deux", 0);
            scores.Add("Trois", 0);
            scores.Add("Quatre", 0);
            scores.Add("Cinq", 0);
            scores.Add("Six", 0);
            scores.Add("Total", 0);
            scores.Add("Bonus", -63);
            scores.Add("Total 1", 0);
            scores.Add("Brelan", 0);
            scores.Add("Carre", 0);
            scores.Add("Full", 0);
            scores.Add("Petite Suite", 0);
            scores.Add("Grande Suite", 0);
            scores.Add("Yams", 0);
            scores.Add("Chance", 0);
            scores.Add("Total 2", 0);
            scores.Add("Total 1 + 2", 0);
        }

        public String GetName
        {
            get
            {
                return name;
            }
        }

        public void RollAll()
        {
            for (int i = 0; i < 5; i++)
            {
                des[i].Roll();
            }
        }

        public void RollUn()
        {
            des[0].Roll();
        }

        public void RollDeux()
        {
            des[1].Roll();
        }

        public void RollTrois()
        {
            des[2].Roll();
        }

        public void RollQuatre()
        {
            des[3].Roll();
        }

        public void RollCinq()
        {
            des[4].Roll();
        }

        public int GetDesUn
        {
            get
            {
                return des[0].GetChiffre;
            }
        }

        public int GetDesDeux
        {
            get
            {
                return des[1].GetChiffre;
            }
        }

        public int GetDesTrois
        {
            get
            {
                return des[2].GetChiffre;
            }
        }

        public int GetDesQuatre
        {
            get
            {
                return des[3].GetChiffre;
            }
        }

        public int GetDesCinq
        {
            get
            {
                return des[4].GetChiffre;
            }
        }

        public void LockUn()
        {
            des[0].Lock();
        }
        public void UnlockUn()
        {
            des[0].Unlock();
        }
        public bool GetLockUn
        {
            get
            {
                return des[0].getLocked;
            }
        }

        public void LockDeux()
        {
            des[1].Lock();
        }
        public void UnlockDeux()
        {
            des[1].Unlock();
        }
        public bool GetLockDeux
        {
            get
            {
                return des[1].getLocked;
            }
        }

        public void LockTrois()
        {
            des[2].Lock();
        }
        public void UnlockTrois()
        {
            des[2].Unlock();
        }
        public bool GetLockTrois
        {
            get
            {
                return des[2].getLocked;
            }
        }

        public void LockQuatre()
        {
            des[3].Lock();
        }
        public void UnlockQuatre()
        {
            des[3].Unlock();
        }
        public bool GetLockQuatre
        {
            get
            {
                return des[3].getLocked;
            }
        }

        public void LockCinq()
        {
            des[4].Lock();
        }
        public void UnlockCinq()
        {
            des[4].Unlock();
        }
        public bool GetLockCinq
        {
            get
            {
                return des[4].getLocked;
            }
        }

        public void ResetDes()
        {
            for(int i = 0; i < 5; i++)
            {
                des[i].Reset();
            }
        }

        public void SetChiffreDes()
        {
            chiffreDes = new int[5];

            chiffreDes[0] = des[0].GetChiffre;
            chiffreDes[1] = des[1].GetChiffre;
            chiffreDes[2] = des[2].GetChiffre;
            chiffreDes[3] = des[3].GetChiffre;
            chiffreDes[4] = des[4].GetChiffre;
        }

        public void SetDicoAs()
        {
            if(getScore.GetStatusAs == false)
            {
                SetChiffreDes();
                getScore.SetScoreAs(chiffreDes);
                scores["As"] = getScore.GetScoreAs;
            }
        }

        public int GetDicoAs
        {
            get
            {
                return scores["As"];
            }
        }

        public bool GetStatusAs
        {
            get
            {
                return getScore.GetStatusAs;
            }
        }


        public void SetDicoDeux()
        {
            if (getScore.GetStatusDeux == false)
            {
                SetChiffreDes();
                getScore.SetScoreDeux(chiffreDes);
                scores["Deux"] = getScore.GetScoreDeux;
            }
        }

        public int GetDicoDeux
        {
            get
            {
                return scores["Deux"];
            }
        }

        public bool GetStatusDeux
        {
            get
            {
                return getScore.GetStatusDeux;
            }
        }


        public void SetDicoTrois()
        {
            if (getScore.GetStatusTrois == false)
            {
                SetChiffreDes();
                getScore.SetScoreTrois(chiffreDes);
                scores["Trois"] = getScore.GetScoreTrois;
            }
        }

        public int GetDicoTrois
        {
            get
            {
                return scores["Trois"];
            }
        }

        public bool GetStatusTrois
        {
            get
            {
                return getScore.GetStatusTrois;
            }
        }


        public void SetDicoQuatre()
        {
            if (getScore.GetStatusQuatre == false)
            {
                SetChiffreDes();
                getScore.SetScoreQuatre(chiffreDes);
                scores["Quatre"] = getScore.GetScoreQuatre;
            }
        }

        public int GetDicoQuatre
        {
            get
            {
                return scores["Quatre"];
            }
        }

        public bool GetStatusQuatre
        {
            get
            {
                return getScore.GetStatusQuatre;
            }
        }


        public void SetDicoCinq()
        {
            if (getScore.GetStatusCinq == false)
            {
                SetChiffreDes();
                getScore.SetScoreCinq(chiffreDes);
                scores["Cinq"] = getScore.GetScoreCinq;
            }
        }

        public int GetDicoCinq
        {
            get
            {
                return scores["Cinq"];
            }
        }

        public bool GetStatusCinq
        {
            get
            {
                return getScore.GetStatusCinq;
            }
        }


        public void SetDicoSix()
        {
            if (getScore.GetStatusSix == false)
            {
                SetChiffreDes();
                getScore.SetScoreSix(chiffreDes);
                scores["Six"] = getScore.GetScoreSix;
            }
        }

        public int GetDicoSix
        {
            get
            {
                return scores["Six"];
            }
        }

        public bool GetStatusSix
        {
            get
            {
                return getScore.GetStatusSix;
            }
        }


        public void SetDicoBrelan()
        {
            if (getScore.GetStatusBrelan == false)
            {
                SetChiffreDes();
                getScore.SetScoreBrelan(chiffreDes);
                scores["Brelan"] = getScore.GetScoreBrelan;
            }
        }

        public int GetDicoBrelan
        {
            get
            {
                return scores["Brelan"];
            }
        }

        public bool GetStatusBrelan
        {
            get
            {
                return getScore.GetStatusBrelan;
            }
        }

        public void SetDicoCarre()
        {
            if (getScore.GetStatusCarre == false)
            {
                SetChiffreDes();
                getScore.SetScoreCarre(chiffreDes);
                scores["Carre"] = getScore.GetScoreCarre;
            }
        }

        public int GetDicoCarre
        {
            get
            {
                return scores["Carre"];
            }
        }

        public bool GetStatusCarre
        {
            get
            {
                return getScore.GetStatusCarre;
            }
        }


        public void SetDicoFull()
        {
            if (getScore.GetStatusFull == false)
            {
                SetChiffreDes();
                getScore.SetScoreFull(chiffreDes);
                scores["Full"] = getScore.GetScoreFull;
            }
        }

        public int GetDicoFull
        {
            get
            {
                return scores["Full"];
            }
        }

        public bool GetStatusFull
        {
            get
            {
                return getScore.GetStatusFull;
            }
        }


        public void SetDicoPetSuite()
        {
            if (getScore.GetStatusPetSuite == false)
            {
                SetChiffreDes();
                getScore.SetScorePetSuite(chiffreDes);
                scores["Petite Suite"] = getScore.GetScorePetSuite;
            }
        }

        public int GetDicoPetSuite
        {
            get
            {
                return scores["Petite Suite"];
            }
        }

        public bool GetStatusPetSuite
        {
            get
            {
                return getScore.GetStatusPetSuite;
            }
        }


        public void SetDicoGrdSuite()
        {
            if (getScore.GetStatusGrdSuite == false)
            {
                SetChiffreDes();
                getScore.SetScoreGrdSuite(chiffreDes);
                scores["Grande Suite"] = getScore.GetScoreGrdSuite;
            }
        }

        public int GetDicoGrdSuite
        {
            get
            {
                return scores["Grande Suite"];
            }
        }

        public bool GetStatusGrdSuite
        {
            get
            {
                return getScore.GetStatusGrdSuite;
            }
        }


        public void SetDicoYams()
        {
            if (getScore.GetStatusYams == false)
            {
                SetChiffreDes();
                getScore.SetScoreYams(chiffreDes);
                scores["Yams"] = getScore.GetScoreYams;
            }
        }

        public int GetDicoYams
        {
            get
            {
                return scores["Yams"];
            }
        }

        public bool GetStatusYams
        {
            get
            {
                return getScore.GetStatusYams;
            }
        }


        public void SetDicoChance()
        {
            if (getScore.GetStatusChance == false)
            {
                SetChiffreDes();
                getScore.SetScoreChance(chiffreDes);
                scores["Chance"] = getScore.GetScoreChance;
            }
        }

        public int GetDicoChance
        {
            get
            {
                return scores["Chance"];
            }
        }

        public bool GetStatusChance
        {
            get
            {
                return getScore.GetStatusChance;
            }
        }

        public void SetDicoTotal()
        {
            getScore.SetTotal();
            scores["Total"] = getScore.GetTotal;
        }

        public int GetDicoTotal
        {
            get
            {
                return scores["Total"];
            }
        }


        public void SetDicoBonus()
        {
            getScore.SetBonus();
            scores["Bonus"] = getScore.GetBonus;
        }

        public int GetDicoBonus
        {
            get
            {
                return scores["Bonus"];
            }
        }


        public void SetDicoTotal1()
        {
            getScore.SetTotal1();
            scores["Total 1"] = getScore.GetTotal1;
        }

        public int GetDicoTotal1
        {
            get
            {
                return scores["Total 1"];
            }
        }


        public void SetDicoTotal2()
        {
            getScore.SetTotal2();
            scores["Total 2"] = getScore.GetTotal2;
        }

        public int GetDicoTotal2
        {
            get
            {
                return scores["Total 2"];
            }
        }


        public void SetDicoTotal3()
        {
            getScore.SetTotal3();
            scores["Total 3"] = getScore.GetTotal3;
        }

        public int GetDicoTotal3
        {
            get
            {
                return scores["Total 3"];
            }
        }
    }
}
