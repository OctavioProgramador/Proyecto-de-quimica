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
    public partial class FormGameTwoPlayers : Form
    {
        #region fields and Constructors

        ScoreTable scoreTable;
        Test newTestPlayer1 = new Test();
        Test newTestPlayer2 = new Test();
        public string namePlayer1;
        public string namePlayer2;
        public List<Question> questionsPlayer1;
        public List<Question> questionsPlayer2;
        int NumberOfQuestionsPlayer1;
        int NumberOfQuestionsPlayer2;
        int countingPlayer1 = 0;
        int positionPlayer1 = 0;
        int totalPointsPlayer1 = 0;
        int countingPlayer2 = 0;
        int positionPlayer2 = 0;
        int totalPointsPlayer2 = 0;
        bool CanExit1 = false;
        bool CanExit2 = false;    

        //Constructors

        public FormGameTwoPlayers()
        {
            InitializeComponent();
        }

        public FormGameTwoPlayers(string namePlayer1, string namePlayer2)
        {
            InitializeComponent();
            scoreTable = new ScoreTable(2);
            this.namePlayer1 = namePlayer1;
            labelPlayer1.Text = this.namePlayer1;
            this.namePlayer1 = namePlayer2;
            labelPlayer1.Text = this.namePlayer2;
            NumberOfQuestionsPlayer1 = 0;
            NumberOfQuestionsPlayer2 = 0;
            WriteQuestionPlayer1();
            WriteQuestionPlayer2();
        }

        #endregion

        //Handlers

        #region handlers        
        private void FormGameTwoPlayers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Q))
            {
                CorroborarRespuesta(newTestPlayer1.questions[positionPlayer1].Reply(1), 1);
                CorroborateTotalofQuestionsPlayer1();
            }
            else if (e.KeyCode.Equals(Keys.W))
            {
                CorroborarRespuesta(newTestPlayer1.questions[positionPlayer1].Reply(2), 1);
                CorroborateTotalofQuestionsPlayer1();
            }
            else if (e.KeyCode.Equals(Keys.A))
            {
                CorroborarRespuesta(newTestPlayer1.questions[positionPlayer1].Reply(3), 1);
                CorroborateTotalofQuestionsPlayer1();
            }
            else if (e.KeyCode.Equals(Keys.S))
            {
                CorroborarRespuesta(newTestPlayer1.questions[positionPlayer1].Reply(4), 1);
                CorroborateTotalofQuestionsPlayer1();
            }

            else if (e.KeyCode.Equals(Keys.NumPad7))
            {
                CorroborarRespuesta(newTestPlayer2.questions[positionPlayer2].Reply(1), 2);
                CorroborateTotalofQuestionsPlayer2();
            }
            else if (e.KeyCode.Equals(Keys.NumPad8))
            {
                CorroborarRespuesta(newTestPlayer2.questions[positionPlayer2].Reply(2), 2);
                CorroborateTotalofQuestionsPlayer2();
            }
            else if (e.KeyCode.Equals(Keys.NumPad4))
            {
                CorroborarRespuesta(newTestPlayer2.questions[positionPlayer2].Reply(3), 2);
                CorroborateTotalofQuestionsPlayer2();
            }
            else if (e.KeyCode.Equals(Keys.NumPad5))
            {
                CorroborarRespuesta(newTestPlayer2.questions[positionPlayer2].Reply(4), 2);
                CorroborateTotalofQuestionsPlayer2();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            countingPlayer1--;
            labelTime1.BringToFront();
            labelTime1.Text = "Tiempo restante: " + (countingPlayer1.ToString());
            if (countingPlayer1 < 1)
            {
                NumberOfQuestionsPlayer1++;
                WriteQuestionPlayer1();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.PerformStep();
            countingPlayer2--;
            labelTime1.BringToFront();
            labelTime2.Text = "Tiempo restante: " + (countingPlayer2.ToString());
            if (countingPlayer2 < 1)
            {
                NumberOfQuestionsPlayer2++;
                WriteQuestionPlayer2();
            }
        }

        #endregion

        //Methods

        #region methods
        public void WriteQuestionPlayer1()
        {
            progressBar1.Value = 0;
            Random rnd = new Random();

            int randomIndex = rnd.Next(0, newTestPlayer1.questions.Count);
            
            labelQuestionPlayer1.Text = newTestPlayer1.questions[randomIndex].QuestionText;
            buttonOption1Player1.Text = newTestPlayer1.questions[randomIndex].GetPosibleAnswer(0);
            buttonOption2Player1.Text = newTestPlayer1.questions[randomIndex].GetPosibleAnswer(1);
            buttonOption3Player1.Text = newTestPlayer1.questions[randomIndex].GetPosibleAnswer(2);
            buttonOption4Player1.Text = newTestPlayer1.questions[randomIndex].GetPosibleAnswer(3);
            countingPlayer1 = 11;
            positionPlayer1 = randomIndex;

            labelCurrentlyQuestion1.Text = "Preguntas respondidas: " + NumberOfQuestionsPlayer1.ToString();
            labelPoints1.Text = "Puntos totales: " + totalPointsPlayer1.ToString();
            labelTime1.Text = "Tiempo restante: " + (countingPlayer1.ToString());
        }

        public void WriteQuestionPlayer2()
        {
            progressBar2.Value = 0;
            Random rnd = new Random();

            int randomIndex = rnd.Next(0, newTestPlayer2.questions.Count);

            labelQuestionPlayer2.Text = newTestPlayer2.questions[randomIndex].QuestionText;
            buttonOption1Player2.Text = newTestPlayer2.questions[randomIndex].GetPosibleAnswer(0);
            buttonOption2Player2.Text = newTestPlayer2.questions[randomIndex].GetPosibleAnswer(1);
            buttonOption3Player2.Text = newTestPlayer2.questions[randomIndex].GetPosibleAnswer(2);
            buttonOption4Player2.Text = newTestPlayer2.questions[randomIndex].GetPosibleAnswer(3);
            countingPlayer2 = 11;
            positionPlayer2 = randomIndex;

            labelCurrentlyQuestion2.Text = "Preguntas respondidas: " + NumberOfQuestionsPlayer1.ToString();
            labelPoints2.Text = "Puntos totales: " + totalPointsPlayer2.ToString();
            labelTime2.Text = "Tiempo restante: " + (countingPlayer2.ToString());
        }

        void PointSistem(int player)
        {
            if (player == 1)
            {
                timer1.Stop();
                if (countingPlayer1 > 10)
                {
                    totalPointsPlayer1 = totalPointsPlayer1 + 5;
                }
                else if (countingPlayer1 > 5)
                {
                    totalPointsPlayer1 = totalPointsPlayer1 + 3;
                }
                else
                {
                    totalPointsPlayer1 = totalPointsPlayer1 + 1;
                }
                timer1.Start();
            }
            else if (player ==2)
            {
                timer2.Stop();
                if (countingPlayer2 > 10)
                {
                    totalPointsPlayer2 = totalPointsPlayer2 + 5;
                }
                else if (countingPlayer2 > 5)
                {
                    totalPointsPlayer2 = totalPointsPlayer2 + 3;
                }
                else
                {
                    totalPointsPlayer2 = totalPointsPlayer2 + 1;
                }
                timer2.Start();

            }
        }

        private void CorroborarRespuesta(bool condicionLogica, int player)
        {
            if (condicionLogica)
            {
                PointSistem(player);
            }
            if (player == 1)
            {
                NumberOfQuestionsPlayer1++;
                WriteQuestionPlayer1();
            }
            if (player == 2)
            {
                NumberOfQuestionsPlayer2++;
                WriteQuestionPlayer2();            
            }
        }

        void CorroborateTotalofQuestionsPlayer1()
        {
            if (NumberOfQuestionsPlayer1 >= 15)
            {
                timer1.Stop();
                MessageBox.Show("tu puntuacion fue " + totalPointsPlayer1);
                scoreTable.AddPuntuation(new Player(labelPlayer1.Text, totalPointsPlayer1));
                CanExit1 = true;
                ExitThisForm();
            }
        }

        void CorroborateTotalofQuestionsPlayer2()
        {
            if (NumberOfQuestionsPlayer2 >= 15)
            {
                timer1.Stop();
                MessageBox.Show("tu puntuacion fue " + totalPointsPlayer2);
                scoreTable.AddPuntuation(new Player(labelPlayer2.Text, totalPointsPlayer2));
                CanExit2 = true;
                ExitThisForm();
            }
        }

        void ExitThisForm()
        {
            if (CanExit1 == true && CanExit2 == true)
            {
                this.Close();
                FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
                formMenuPrincipal.Show();
            }            
        }



        #endregion
    }
}
