using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{   
    public partial class FormMenuPrincipal : Form
    {
        FormScoreTable formScoreTable;
        FormGame formGame;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            formGame = new FormGame();
            formScoreTable = new FormScoreTable();
        }

        private void buttonInciair_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGame.Show();
        }

        private void buttonTabla_Click(object sender, EventArgs e)
        {
            this.Hide();
            formScoreTable.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
