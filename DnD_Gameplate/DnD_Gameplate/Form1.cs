using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DnD_Gameplate
{
    public partial class frm_Mainplate : Form
    {
        Charakter spieler;
        string[] stats = new string[14];
        string name;
        string xgame;

        public frm_Mainplate()
        {
            InitializeComponent();
        }

        private void btn_Levelup_Click(object sender, EventArgs e)
        {
            Levelup lvlup = new Levelup(spieler);
            if (lvlup.ShowDialog() == DialogResult.OK)
            {
                Write(spieler.Name, 1);
                Aktualisierung();
            }
        }

        private void btn_Kampf_Click(object sender, EventArgs e)
        {

        }

        #region Game
        private void btn_NG_Click(object sender, EventArgs e)
        {
            xgame = "NewChar";
            NewGame Char = new NewGame();
            if (Char.ShowDialog() == DialogResult.OK)
            {
                Write(xgame, 1);
                Aktualisierung();
            }
        }
        private void btn_LG_Click(object sender, EventArgs e)
        {

            LoadSaveGame lsg1 = new LoadSaveGame();
            if (lsg1.ShowDialog() == DialogResult.OK)
            {
                xgame = "help";
                Write(xgame, 0);
                Write(name, 1);
                File.Delete(@".\" + xgame + ".txt");
                Aktualisierung();
            }
        }
        private void btn_SG_Click(object sender, EventArgs e)
        {
            LoadSaveGame lsg1 = new LoadSaveGame();
            if (lsg1.ShowDialog() == DialogResult.OK)
            {
                xgame = "help";
                Write(xgame, 0);
                File.Delete(@".\" + name + ".txt");
                //File.Create(@".\" + name + ".txt");
                Read(name);
                File.Delete(@".\" + xgame + ".txt");
                Aktualisierung();
            }
        }

        #endregion
        private void Aktualisierung()
        {
            spieler = Erstellung();
            lbl_Name_Stat.Text = spieler.Name;
            lbl_Level_Stat.Text = Convert.ToString(spieler.Lvl);
            lbl_Waffe_Stat.Text = Convert.ToString(spieler.Waffe);
            lbl_HP_Stat.Text = Convert.ToString(spieler.HP);
            lbl_MP_Stat.Text = Convert.ToString(spieler.MP);
            lbl_STR_Stat.Text = Convert.ToString(spieler.Staerke);
            lbl_CON_Stat.Text = Convert.ToString(spieler.Konstitution);
            lbl_DEX_Stat.Text = Convert.ToString(spieler.Geschick);
            lbl_INT_Stat.Text = Convert.ToString(spieler.Intelligenz);
            lbl_WIS_Stat.Text = Convert.ToString(spieler.Weisheit);
            lbl_CHA_Stat.Text = Convert.ToString(spieler.Charisma);
            lbl_Schmuck_Stat.Text = spieler.Zubehoer1;
            lbl_Schmuck1_Stat.Text = spieler.Zubehoer2;
        }

        private void Write(string datei, int x)
        {
            StreamReader reader;
            int zaehler = 0;
            string line;
            if(!File.Exists(@".\" + datei + ".txt"))
            {
                File.Create(@".\" + datei + ".txt");
            }
            reader = new StreamReader(@".\" + datei + ".txt");


            if (x == 1)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    stats[zaehler] = line;
                    zaehler++;
                }
            }
            else
            {
                name = reader.ReadLine();
            }
            reader.Close();
        }
        private void Read(string datei)
        {
            stats[0] = lbl_Name_Stat.Text;
            stats[1] = lbl_Waffe_Stat.Text;
            stats[2] = lbl_Level_Stat.Text;
            stats[3] = lbl_HP_Stat.Text;
            stats[4] = lbl_MP_Stat.Text;
            stats[5] = lbl_STR_Stat.Text;
            stats[6] = lbl_CON_Stat.Text;
            stats[7] = lbl_DEX_Stat.Text;
            stats[8] = lbl_INT_Stat.Text;
            stats[9] = lbl_WIS_Stat.Text;
            stats[10] = lbl_CHA_Stat.Text;
            stats[11] = lbl_Schmuck_Stat.Text;
            stats[12] = lbl_Schmuck1_Stat.Text;
            stats[13] = Convert.ToString(spieler.Manause);
            File.WriteAllLines(@".\" + datei + ".txt", stats);

        }
        private Charakter Erstellung()
        {
            Charakter help = new Charakter(stats[0], stats[1], Convert.ToInt32(stats[2]), Convert.ToInt32(stats[3]),
                                        Convert.ToInt32(stats[4]), Convert.ToInt32(stats[5]), Convert.ToInt32(stats[6]), Convert.ToInt32(stats[7]),
                                        Convert.ToInt32(stats[8]), Convert.ToInt32(stats[9]), Convert.ToInt32(stats[10]), stats[11], stats[12], Convert.ToInt32(stats[13]));
            return help;
        }


    }
}
