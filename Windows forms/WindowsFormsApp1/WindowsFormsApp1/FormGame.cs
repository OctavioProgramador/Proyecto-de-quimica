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
         Test newTest;
        public List<Question> questions;
        public FormGame()
        {
            InitializeComponent();

            newTest = new Test();
            /*
            questions = new List<Question>();
            questions.Add(new Question("2+2", "4", "2", "3", "5"));
            questions.Add(new Question("2*2", "4", "2", "3", "5"));
            questions.Add(new Question("2+3", "5", "2", "3", "6"));
            questions.Add(new Question("2/2", "1", "2", "3", "5"));
            questions.Add(new Question("2-1", "1", "2", "3", "5"));
            */
            Llenar();
 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            CorroborarRespuesta(newTest.questions[posicion].Reply(1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CorroborarRespuesta(newTest.questions[posicion].Reply(2));
        }

        void button3_Click(object sender, EventArgs e)
        {
            CorroborarRespuesta(newTest.questions[posicion].Reply(3));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CorroborarRespuesta(newTest.questions[posicion].Reply(4));
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
            if (MessageBox.Show("CORRECTO", "Salir", MessageBoxButtons.OK , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.OK)
            {
                timer1.Start();
            }
            //MessageBox.Show("Correcto ");
           // timer1.Stop();
        }

        private void Llenar() {

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, newTest.questions.Count<Question>());
            labelQuestion.Text = newTest.questions[randomIndex].QuestionText;
            buttonOption1.Text = newTest.questions[randomIndex].GetPosibleAnswer(0);
            buttonOption2.Text = newTest.questions[randomIndex].GetPosibleAnswer(1);
            buttonOption3.Text = newTest.questions[randomIndex].GetPosibleAnswer(2);
            buttonOption4.Text = newTest.questions[randomIndex].GetPosibleAnswer(3);
            conteo = 11;
            posicion = randomIndex;
        }

        private void CorroborarRespuesta(bool condiciónLogica)
        {   
            if (condiciónLogica)
            {
                Punt(conteo);
            }
            preguntadas++;
            progressBar1.PerformStep();
            Llenar();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo--;
            label2.BringToFront();
            label2.Text = (conteo.ToString());      

            if (preguntadas >= 15)
            {
                timer1.Stop();
                MessageBox.Show("tu puntuacion fue " + puntotal);
                this.Close();
                FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
                formMenuPrincipal.Show();
            }

            if (conteo <1)
            {          
                preguntadas++; 
                progressBar1.PerformStep();
                Llenar();
            }

        }
    }
}
