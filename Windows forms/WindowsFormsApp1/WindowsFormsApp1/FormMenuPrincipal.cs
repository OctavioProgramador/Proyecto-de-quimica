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
        FormName formName;
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
            formName = new FormName(1); 
            this.Hide();
            formName.Show();
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

        private void buttonStartMode2_Click(object sender, EventArgs e)
        {
            formName = new FormName(2);
            this.Hide();
            formName.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
