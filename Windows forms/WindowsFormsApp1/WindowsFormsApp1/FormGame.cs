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
    public partial class FormGame : Form
    {
        ScoreTable scoreTable;
        Test newTest= new Test();
        public string namePlayer;
        public List<Question> questions;
        int NumberOfQuestions;

        #region Constructors

        public FormGame()
        {
            InitializeComponent();
        }

        public FormGame(string name)
        {
            InitializeComponent();
            scoreTable = new ScoreTable(1);
            namePlayer = name;
            labelPlayer.Text = namePlayer;
            NumberOfQuestions = 0;
            WriteQuestion();           
        }
        #endregion

        #region Handlers 
        private void button1_Click(object sender, EventArgs e)
        {
            CorroborarRespuesta(newTest.questions[posicion].Reply( ( ( Button )sender ).TabIndex ) );
            CorroborateTotalofQuestions();
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            conteo--;
            labelTime.BringToFront();
            labelTime.Text = "Tiempo restante: "+(conteo.ToString());
            if (conteo < 1)
            {
                NumberOfQuestions++;                
                WriteQuestion();
            }
        }

        private void buttonSurrender_Click(object sender, EventArgs e)
        {
            ExitThisForm();
        }
        #endregion

        #region Methods
        void CorroborateTotalofQuestions()
        {
            if (NumberOfQuestions >= 15)
            {
                timer1.Stop();
                MessageBox.Show("tu puntuacion fue " + puntotal);
                scoreTable.AddPuntuation(new Player(labelPlayer.Text, puntotal));
                ExitThisForm();
            }
        }

        void ExitThisForm()
        {
            this.Close();
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.Show();
        }

        void Punt(int tiempo)
        {
            timer1.Stop();
            if (tiempo > 10)
            {
                puntotal = puntotal + 5;
            }
            else if (tiempo > 5)
            {
                puntotal = puntotal + 3;
            }
            else
            {
                puntotal = puntotal + 1;
            }
            timer1.Start();          
        }

        public void WriteQuestion() {
            progressBar1.Value = 0;
            Random rnd = new Random();
            
            int randomIndex = rnd.Next(0, newTest.questions.Count);
            labelQuestion.Text = newTest.questions[randomIndex].QuestionText;
            buttonOption1.Text = newTest.questions[randomIndex].GetPosibleAnswer(0);
            buttonOption2.Text = newTest.questions[randomIndex].GetPosibleAnswer(1);
            buttonOption3.Text = newTest.questions[randomIndex].GetPosibleAnswer(2);
            buttonOption4.Text = newTest.questions[randomIndex].GetPosibleAnswer(3);
            conteo = 11;
            posicion = randomIndex;

            labelCurrentlyQuestion.Text = "Preguntas respondidas: "+NumberOfQuestions.ToString();
            labelPoints.Text = "Puntos totales: " + puntotal.ToString();
            labelTime.Text = "Tiempo restante: " + (conteo.ToString());
        }   

        private void CorroborarRespuesta(bool condiciónLogica)
        {   
            if (condiciónLogica)
            {
                Punt(conteo);
            }
            NumberOfQuestions++;
            WriteQuestion();
        }
        #endregion
    }
}
