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
    public partial class FormScoreTable : Form
    {
        ScoreTable scoreTable;
        List<Label> labelListSinglePlayer;
        public FormScoreTable()
        {
            InitializeComponent();
            scoreTable = new ScoreTable(1);
            labelListSinglePlayer = new List<Label>()
            {
                label1,label2,label3,label4,label5,label6,label7,label8,label9,label10,label9,label10,label11,label12,label13,label14,label15
            };
            SetScores();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.Show();        
        }

        public void SetScores()
        {
            int index = 0;
            foreach(Player player in scoreTable.GetRecord())
            {
                labelListSinglePlayer[index].Text = player.ToString();
                index++;
            }
            
        }

        private void tabPageScoresTwoPlayers_Click(object sender, EventArgs e)
        {

        }
    }
}
