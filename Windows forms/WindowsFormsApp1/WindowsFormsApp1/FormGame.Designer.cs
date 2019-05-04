namespace WindowsFormsApp1
{
    partial class FormGame
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOption4 = new System.Windows.Forms.Button();
            this.buttonOption3 = new System.Windows.Forms.Button();
            this.buttonOption2 = new System.Windows.Forms.Button();
            this.buttonOption1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.labelCurrentlyQuestion = new System.Windows.Forms.Label();
            this.buttonSurrender = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelQuestion.Location = new System.Drawing.Point(117, 50);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(515, 41);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelQuestion);
            this.panel1.Controls.Add(this.buttonOption4);
            this.panel1.Controls.Add(this.buttonOption3);
            this.panel1.Controls.Add(this.buttonOption2);
            this.panel1.Controls.Add(this.buttonOption1);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 402);
            this.panel1.TabIndex = 0;
            // 
            // buttonOption4
            // 
            this.buttonOption4.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption4.Location = new System.Drawing.Point(373, 282);
            this.buttonOption4.Name = "buttonOption4";
            this.buttonOption4.Size = new System.Drawing.Size(250, 52);
            this.buttonOption4.TabIndex = 4;
            this.buttonOption4.Text = "Psiquico";
            this.buttonOption4.UseVisualStyleBackColor = true;
            this.buttonOption4.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOption3
            // 
            this.buttonOption3.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption3.Location = new System.Drawing.Point(115, 282);
            this.buttonOption3.Name = "buttonOption3";
            this.buttonOption3.Size = new System.Drawing.Size(205, 52);
            this.buttonOption3.TabIndex = 3;
            this.buttonOption3.Text = "aire";
            this.buttonOption3.UseVisualStyleBackColor = true;
            this.buttonOption3.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOption2
            // 
            this.buttonOption2.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption2.Location = new System.Drawing.Point(373, 186);
            this.buttonOption2.Name = "buttonOption2";
            this.buttonOption2.Size = new System.Drawing.Size(250, 54);
            this.buttonOption2.TabIndex = 2;
            this.buttonOption2.Text = "fuego";
            this.buttonOption2.UseVisualStyleBackColor = true;
            this.buttonOption2.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonOption1
            // 
            this.buttonOption1.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption1.Location = new System.Drawing.Point(115, 186);
            this.buttonOption1.Name = "buttonOption1";
            this.buttonOption1.Size = new System.Drawing.Size(205, 54);
            this.buttonOption1.TabIndex = 1;
            this.buttonOption1.Text = "Agua";
            this.buttonOption1.UseVisualStyleBackColor = true;
            this.buttonOption1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTime.Location = new System.Drawing.Point(13, 474);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(27, 20);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "10";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(362, 468);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(12, 9);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(77, 13);
            this.labelPlayer.TabIndex = 3;
            this.labelPlayer.Text = "Jugador actual";
            // 
            // labelPoints
            // 
            this.labelPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(648, 9);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(93, 13);
            this.labelPoints.TabIndex = 4;
            this.labelPoints.Text = "Puntuación actual";
            // 
            // labelCurrentlyQuestion
            // 
            this.labelCurrentlyQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentlyQuestion.AutoSize = true;
            this.labelCurrentlyQuestion.Location = new System.Drawing.Point(648, 22);
            this.labelCurrentlyQuestion.Name = "labelCurrentlyQuestion";
            this.labelCurrentlyQuestion.Size = new System.Drawing.Size(82, 13);
            this.labelCurrentlyQuestion.TabIndex = 5;
            this.labelCurrentlyQuestion.Text = "Pregunta actual";
            // 
            // buttonSurrender
            // 
            this.buttonSurrender.Location = new System.Drawing.Point(713, 471);
            this.buttonSurrender.Name = "buttonSurrender";
            this.buttonSurrender.Size = new System.Drawing.Size(75, 23);
            this.buttonSurrender.TabIndex = 6;
            this.buttonSurrender.Text = "Rendirse";
            this.buttonSurrender.UseVisualStyleBackColor = true;
            this.buttonSurrender.Click += new System.EventHandler(this.buttonSurrender_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.buttonSurrender);
            this.Controls.Add(this.labelCurrentlyQuestion);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panel1);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego quimica";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public string respuesta1 = "fuego";
        public string[] pregunta = new string[20];
        public string[] respuestasc = new string[20];
        public string[,] respuestasi = new string[50,30];
       
        
        public bool correcta=false;
        int conteo = 10;
        public int posicion = 0;

        int puntuacion=0;
        int vueltas = 0;
        int puntotal = 0;
        int preguntadas =0;

        
       


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOption1;
        private System.Windows.Forms.Button buttonOption4;
        private System.Windows.Forms.Button buttonOption3;
        private System.Windows.Forms.Button buttonOption2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.Label labelCurrentlyQuestion;
        private System.Windows.Forms.Button buttonSurrender;
    }
}

