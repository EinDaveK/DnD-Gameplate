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
    public partial class LoadSaveGame : Form
    {

        public LoadSaveGame()
        {
            InitializeComponent();
        }

        private void LoadSaveGame_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Bestätigen_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@".\help.txt", tb_Name.Text);
        }
    }
}
