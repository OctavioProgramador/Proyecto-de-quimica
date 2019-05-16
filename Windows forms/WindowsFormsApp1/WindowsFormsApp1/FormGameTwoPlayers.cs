﻿using System;
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
        int TimeLeftPlayer1 = 0;
        int positionPlayer1 = 0;
        int totalPointsPlayer1 = 0;
        int timeLeftPlayer2 = 0;
        int positionPlayer2 = 0;
        int totalPointsPlayer2 = 0;
        bool CanPlay1 = true;
        bool CanPlay2 = true;    

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
            this.namePlayer2 = namePlayer2;
            labelPlayer2.Text = this.namePlayer2;
            NumberOfQuestionsPlayer1 = 0;
            NumberOfQuestionsPlayer2 = 0;
            WriteQuestionPlayer1();
            WriteQuestionPlayer2();
        }

        #endregion

        #region handlers        
        private void FormGameTwoPlayers_KeyDown(object sender, KeyEventArgs e)
        {

            if (CanPlay1)
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
            }

            if (CanPlay2)
            {
                if (e.KeyCode.Equals(Keys.NumPad7))
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Lo que hice fue poner los códigos de los 2 timers en uno sólo.
            //Pero cada uno se reinicia según el método PointSistem
            progressBar1.PerformStep();
            TimeLeftPlayer1--;
            //labelTime1.BringToFront();
            labelTime1.Text = "Tiempo restante: " + (TimeLeftPlayer1.ToString());
            if (TimeLeftPlayer1 < 1)
            {
                CorroborateTotalofQuestionsPlayer1();
                NumberOfQuestionsPlayer1++;
                WriteQuestionPlayer1();
            }

            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.PerformStep();
            timeLeftPlayer2--;
            //labelTime2.BringToFront();
            labelTime2.Text = "Tiempo restante: " + (timeLeftPlayer2.ToString());
            if (timeLeftPlayer2 < 1)
            {

                CorroborateTotalofQuestionsPlayer2();
                NumberOfQuestionsPlayer2++;
                WriteQuestionPlayer2();
            }
        }

        private void buttonSurrenderPlayer1_Click(object sender, EventArgs e)
        {

            Player1Finished();

        }

        private void buttonSurrenderPlayer2_Click(object sender, EventArgs e)
        {
            Player2Finished();
        }       
        #endregion

        #region methods
        public void WriteQuestionPlayer1()
        {
            if (CanPlay1)
            {
                
                progressBar1.Value = 0;
                Random rnd = new Random();

                int randomIndex = rnd.Next(0, newTestPlayer1.questions.Count);

                labelQuestionPlayer1.Text = newTestPlayer1.questions[randomIndex].QuestionText;
                buttonOption1Player1.Text = "Q.-" + newTestPlayer1.questions[randomIndex].GetPosibleAnswer(0);
                buttonOption2Player1.Text = "W.-" + newTestPlayer1.questions[randomIndex].GetPosibleAnswer(1);
                buttonOption3Player1.Text = "A.-" + newTestPlayer1.questions[randomIndex].GetPosibleAnswer(2);
                buttonOption4Player1.Text = "S.-" + newTestPlayer1.questions[randomIndex].GetPosibleAnswer(3);
                TimeLeftPlayer1 = 11;

                positionPlayer1 = randomIndex;
                //MessageBox.Show(positionPlayer1.ToString());
               // labelCurrentlyQuestion1.Text = "Preguntas respondidas: " + NumberOfQuestionsPlayer1.ToString();
                labelPoints1.Text = "Puntos totales: " + totalPointsPlayer1.ToString();
                labelTime1.Text = "Tiempo restante: " + (TimeLeftPlayer1.ToString());
                //Con esto evitamos que vuelva a aparecer la pregunta eliminandola de la clase test
                
            }         
        }

        public void WriteQuestionPlayer2()
        {
            if (CanPlay2)
            {
                progressBar2.Value = 0;
                Random rnd = new Random();

                int randomIndex = rnd.Next(0, newTestPlayer2.questions.Count);

                labelQuestionPlayer2.Text = newTestPlayer2.questions[randomIndex].QuestionText;
                buttonOption1Player2.Text = "7.-" + newTestPlayer2.questions[randomIndex].GetPosibleAnswer(0);
                buttonOption2Player2.Text = "8.-" + newTestPlayer2.questions[randomIndex].GetPosibleAnswer(1);
                buttonOption3Player2.Text = "4.-" + newTestPlayer2.questions[randomIndex].GetPosibleAnswer(2);
                buttonOption4Player2.Text = "5.-" + newTestPlayer2.questions[randomIndex].GetPosibleAnswer(3);
                timeLeftPlayer2 = 11;
                positionPlayer2 = randomIndex;
                //MessageBox.Show(positionPlayer2.ToString());
                //labelCurrentlyQuestion2.Text = "Preguntas respondidas: " + NumberOfQuestionsPlayer2.ToString();
                labelPoints2.Text = "Puntos totales: " + totalPointsPlayer2.ToString();
                labelTime2.Text = "Tiempo restante: " + (timeLeftPlayer2.ToString());
                //Con esto evitamos que vuelva a aparecer la pregunta eliminandola de la clase test
                //newTestPlayer2.RemoveQuestion(randomIndex);
            }           
        }

        void PointSystem(int player)
        {
            if (player == 1)
            {
                timer1.Stop();
                if (TimeLeftPlayer1 > 10)
                {
                    totalPointsPlayer1 = totalPointsPlayer1 + 5;
                }
                else if (TimeLeftPlayer1 > 5)
                {
                    totalPointsPlayer1 = totalPointsPlayer1 + 3;
                }
                else
                {
                    totalPointsPlayer1 = totalPointsPlayer1 + 1;
                }
                timer1.Start();
            }

            if (player ==2)
            {
                timer2.Stop();
                if (timeLeftPlayer2 > 10)
                {
                    totalPointsPlayer2 = totalPointsPlayer2 + 5;
                }
                else if (timeLeftPlayer2 > 5)
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
                PointSystem(player);
            }
            if (player == 1)
            {
                newTestPlayer1.RemoveQuestion(positionPlayer1);
                NumberOfQuestionsPlayer1++;
                WriteQuestionPlayer1();
            }
            if (player == 2)
            {
                newTestPlayer2.RemoveQuestion(positionPlayer2);
                NumberOfQuestionsPlayer2++;
                WriteQuestionPlayer2();            
            }
            
        }

        void CorroborateTotalofQuestionsPlayer1()
        {

            if (NumberOfQuestionsPlayer1 >= 15)
            {
                Player1Finished();
            }
        }

        void CorroborateTotalofQuestionsPlayer2()
        {
            //newTestPlayer2.RemoveQuestion(positionPlayer2);
            if (NumberOfQuestionsPlayer2 >= 15)
            {
                Player2Finished();
            }
        }

        void ExitThisForm()
        {
            if (CanPlay1 == false && CanPlay2 == false)
            {
                timer1.Stop();
                MessageBox.Show(namePlayer1+": " + totalPointsPlayer1+"\n"+ namePlayer2+": " + totalPointsPlayer2);
                
                scoreTable.AddPuntuation(new Player(namePlayer1, totalPointsPlayer1));
                scoreTable.AddPuntuation(new Player(namePlayer2, totalPointsPlayer2));
                this.Close();
                FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
                formMenuPrincipal.Show();
            }            
        }

        private void Player1Finished()
        {
            progressBar1.Value = 0;
            progressBar1.Enabled = false;
            timer1.Stop();
            CanPlay1 = false;
            ExitThisForm();
        }

        private void Player2Finished()
        {
            progressBar2.Value = 0;
            progressBar2.Enabled = false;
            timer2.Stop();
            CanPlay2 = false;
            ExitThisForm();
        }  
        #endregion
    }
}
