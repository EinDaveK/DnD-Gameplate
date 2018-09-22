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
    
    public partial class NewGame : Form
    {
        string[] stats = new string[14];
        public NewGame()
        {
            InitializeComponent();
        }

        private void btn_Anlage_Click(object sender, EventArgs e)
        {
            stats[0] = tb_Name.Text;
            stats[1] = tb_Waffe.Text;
            stats[2] = "1";
            stats[3] = tb_HP.Text;
            stats[4] = tb_MP.Text;
            stats[5] = tb_Str.Text;
            stats[6] = tb_Con.Text;
            stats[7] = tb_Dex.Text;
            stats[8] = tb_Int.Text;
            stats[9] = tb_Wis.Text;
            stats[10] = tb_Cha.Text;
            stats[11] = "Leer";
            stats[12] = "Leer";
            stats[13] = tb_ManaUse.Text;
            File.WriteAllLines(@".\NewChar.txt", stats);
        }

        private void NewGame_Load(object sender, EventArgs e)
        {

        }
    }
}
