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
    public partial class Levelup : Form
    {
        Charakter spieler;
        int hpup;
        int mpup;
        public Levelup(Charakter lvlup)
        {
            InitializeComponent();
            spieler = lvlup;
            
        }
        private void tb_Str_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Con_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Dex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Wis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_Cha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_Str_Click(object sender, EventArgs e)
        {
            spieler.Staerke += Convert.ToInt32(tb_Str.Text);
            tb_Str.Text = "";
        }

        private void btn_Con_Click(object sender, EventArgs e)
        {
            spieler.Konstitution += Convert.ToInt32(tb_Con.Text);
            tb_Con.Text = "";
        }

        private void btn_Dex_Click(object sender, EventArgs e)
        {
            spieler.Geschick += Convert.ToInt32(tb_Dex.Text);
            tb_Dex.Text = "";
        }

        private void btn_Int_Click(object sender, EventArgs e)
        {
            spieler.Intelligenz += Convert.ToInt32(tb_Int.Text);
            tb_Int.Text = "";
        }

        private void btn_Wis_Click(object sender, EventArgs e)
        {
            spieler.Weisheit += Convert.ToInt32(tb_Wis.Text);
            tb_Wis.Text = "";
        }

        private void btn_Cha_Click(object sender, EventArgs e)
        {
            spieler.Charisma += Convert.ToInt32(tb_Cha.Text);
            tb_Cha.Text = "";
        }

        private void btn_Fertig_Click(object sender, EventArgs e)
        {
            
            switch(spieler.Manause)
            {
                case 0:
                    hpup = 4;
                    mpup = 0;
                    break;
                case 1:
                    hpup = 3;
                    mpup = 1;
                    break;
                case 2:
                    hpup = 2;
                    mpup = 2;
                    break;
                case 3:
                    hpup = 2;
                    mpup = 3;
                    break;

                default:
                    break;
            }
            string[] stats = new string[14];
            stats[0] = spieler.Name;
            stats[1] = spieler.Waffe;
            stats[2] = Convert.ToString(spieler.Lvl + 1);
            stats[3] = Convert.ToString(spieler.HP + hpup);
            stats[4] = Convert.ToString(spieler.MP + mpup);
            stats[5] = Convert.ToString(spieler.Staerke);
            stats[6] = Convert.ToString(spieler.Konstitution);
            stats[7] = Convert.ToString(spieler.Geschick);
            stats[8] = Convert.ToString(spieler.Intelligenz); 
            stats[9] = Convert.ToString(spieler.Weisheit);
            stats[10] = Convert.ToString(spieler.Charisma);
            stats[11] = spieler.Zubehoer1;
            stats[12] = spieler.Zubehoer2;
            stats[13] = Convert.ToString(spieler.Manause);
            File.WriteAllLines(@".\" + spieler.Name + ".txt", stats);
            this.Close();
        }

        private void Levelup_Load(object sender, EventArgs e)
        {

        }
    }
}
