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
        ScoreTable scoreTable2;
        List<Label> labelListSinglePlayer;
        List<Label> labelListSinglePlayer2;
        public FormScoreTable()
        {
            InitializeComponent();
            scoreTable = new ScoreTable(1);
            scoreTable2 = new ScoreTable(2);
            labelListSinglePlayer = new List<Label>()
            {
                label1,label2,label3,label4,label5,label6,label7,label8,label9,label10,label9,label10,label11,label12,label13,label14,label15
            };
            labelListSinglePlayer2 = new List<Label>()
            {
                labelDosJugadores1,labelDosJugadores2,labelDosJugadores3,labelDosJugadores4,labelDosJugadores5,
                labelDosJugadores6,labelDosJugadores7,labelDosJugadores8,labelDosJugadores9,labelDosJugadores10,
                labelDosJugadores11,labelDosJugadores12,labelDosJugadores13,labelDosJugadores14,labelDosJugadores15,
            };
            SetScores();
            SetScores2();
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
        public void SetScores2()
        {
            int index = 0;
            foreach (Player player in scoreTable2.GetRecord())
            {
                labelListSinglePlayer2[index].Text = player.ToString();
                index++;
            }
        }
        private void tabPageScoresTwoPlayers_Click(object sender, EventArgs e)
        {

        }
    }
}
