using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Gameplate
{
    public class Charakter
    {
        string name;
        string waffe;
        int lvl;
        int hp;
        int mp;
        int staerke;
        int konstitution;
        int geschick;
        int intelligenz;
        int weisheit;
        int charisma;
        int geschwindigkeit;
        string zubehoer1;
        string zubehoer2;
        int manause;
        Random crit;

        #region Eigenschaften

        public string Name
        {
            get { return name; }
        }

        public string Waffe
        {
            get { return waffe; }
            set { waffe = value; }
        }
        public int Lvl
        {
            get { return lvl; }
            set { lvl = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int MP
        {
            get { return mp; }
            set { mp = value; }
        }

        public int Staerke
        {
            get { return staerke; }
            set { staerke = value; }
        }

        public int Konstitution
        {
            get { return konstitution; }
            set { konstitution = value; }
        }

        public int Geschick
        {
            get { return geschick; }
            set { geschick = value; }
        }

        public int Intelligenz
        {
            get { return intelligenz; }
            set { intelligenz = value; }
        }
        public int Weisheit
        {
            get { return weisheit; }
            set { weisheit = value; }
        }
        public int Charisma
        {
            get { return charisma; }
            set { charisma = value; }
        }

        public int Geschwindigkeit
        {
            get { return geschwindigkeit; }
            set { geschwindigkeit = value; }
        }
        public string Zubehoer1
        {
            get { return zubehoer1; }
            set { zubehoer1 = value; }
        }
        public string Zubehoer2
        {
            get { return zubehoer2; }
            set { zubehoer2 = value; }
        }
        public int Manause
        {
            get { return manause; }
            set { manause = value; }
        }
        #endregion

        public Charakter(string sname, string weapon, int level, int health, int mana, int str, int con, int dex, int mage, int wis, int cha, string sch1, string sch2, int mu)
        {
            name = sname;
            waffe = weapon;
            lvl = level;
            hp = health;
            mp = mana;
            staerke = str;
            konstitution = con;
            geschick = dex;
            intelligenz = mage;
            weisheit = wis;
            charisma = cha;
            zubehoer1 = sch1;
            zubehoer2 = sch2;
            manause = mu;
        }

        public void Levelup(string attribut, int erhoehung)
        {
            switch (attribut)
            {
                case "staerke":
                    {
                        staerke += erhoehung;
                    }
                    break;
                case "konstitution":
                    {
                        konstitution += erhoehung;
                    }
                    break;
                case "geschick":
                    {
                        geschick += erhoehung;
                    }
                    break;
                case "intelligenz":
                    {
                        intelligenz += erhoehung;
                    }
                    break;
                case "weisheit":
                    {
                        weisheit += erhoehung;
                    }
                    break;
                case "charisma":
                    {
                        charisma += erhoehung;
                    }
                    break;
                default:
                    break;
            }
        }

        public int DMG_Calc(string attribut, int enemiecon, int modifikator) // modifikator = Würfelzahl | attribut = Staerke oder Intelligenz | enemiecon = CON von Gegner
        {
            int damage;
            if (attribut == "Staerke")
            {
                double dmg = ((staerke - enemiecon / 2) * (1 + modifikator / 100)) / 2;
                damage = Convert.ToInt32(dmg);
            }
            else
            {
                double dmg = ((intelligenz - enemiecon / 2) * (1 + modifikator / 100)) / 2;
                damage = Convert.ToInt32(dmg);
            }
            int crit = Crit_Calc();
            if(crit == 1)
            {
                return damage * 2;
            }
            else
            return damage;
        }

        public int Crit_Calc()
        {
            double critchance = geschick / 10;
            double critc = crit.NextDouble() * (100 - critchance) + critchance;
            if (critc <= critchance)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


    }
}
