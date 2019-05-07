namespace WindowsFormsApp1
{
    partial class FormGameTwoPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.buttonSurrenderPlayer1 = new System.Windows.Forms.Button();
            this.labelCurrentlyQuestion1 = new System.Windows.Forms.Label();
            this.labelPoints1 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelTime1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelQuestionPlayer1 = new System.Windows.Forms.Label();
            this.buttonOption4Player1 = new System.Windows.Forms.Button();
            this.buttonOption3Player1 = new System.Windows.Forms.Button();
            this.buttonOption2Player1 = new System.Windows.Forms.Button();
            this.buttonOption1Player1 = new System.Windows.Forms.Button();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.labelCurrentlyQuestion2 = new System.Windows.Forms.Label();
            this.buttonSurrenderPlayer2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPoints2 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelQuestionPlayer2 = new System.Windows.Forms.Label();
            this.buttonOption4Player2 = new System.Windows.Forms.Button();
            this.buttonOption3Player2 = new System.Windows.Forms.Button();
            this.buttonOption2Player2 = new System.Windows.Forms.Button();
            this.buttonOption1Player2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelPlayer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPlayer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelPlayer1.Controls.Add(this.buttonSurrenderPlayer1);
            this.panelPlayer1.Controls.Add(this.labelCurrentlyQuestion1);
            this.panelPlayer1.Controls.Add(this.labelPoints1);
            this.panelPlayer1.Controls.Add(this.labelPlayer1);
            this.panelPlayer1.Controls.Add(this.progressBar1);
            this.panelPlayer1.Controls.Add(this.labelTime1);
            this.panelPlayer1.Controls.Add(this.panel1);
            this.panelPlayer1.Location = new System.Drawing.Point(12, 12);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(576, 709);
            this.panelPlayer1.TabIndex = 0;
            // 
            // buttonSurrenderPlayer1
            // 
            this.buttonSurrenderPlayer1.Location = new System.Drawing.Point(457, 669);
            this.buttonSurrenderPlayer1.Name = "buttonSurrenderPlayer1";
            this.buttonSurrenderPlayer1.Size = new System.Drawing.Size(75, 23);
            this.buttonSurrenderPlayer1.TabIndex = 13;
            this.buttonSurrenderPlayer1.Text = "Rendirse";
            this.buttonSurrenderPlayer1.UseVisualStyleBackColor = true;
            // 
            // labelCurrentlyQuestion1
            // 
            this.labelCurrentlyQuestion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentlyQuestion1.AutoSize = true;
            this.labelCurrentlyQuestion1.Location = new System.Drawing.Point(414, 43);
            this.labelCurrentlyQuestion1.Name = "labelCurrentlyQuestion1";
            this.labelCurrentlyQuestion1.Size = new System.Drawing.Size(82, 13);
            this.labelCurrentlyQuestion1.TabIndex = 12;
            this.labelCurrentlyQuestion1.Text = "Pregunta actual";
            // 
            // labelPoints1
            // 
            this.labelPoints1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPoints1.AutoSize = true;
            this.labelPoints1.Location = new System.Drawing.Point(16, 36);
            this.labelPoints1.Name = "labelPoints1";
            this.labelPoints1.Size = new System.Drawing.Size(93, 13);
            this.labelPoints1.TabIndex = 11;
            this.labelPoints1.Text = "Puntuación actual";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(14, 10);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(77, 13);
            this.labelPlayer1.TabIndex = 10;
            this.labelPlayer1.Text = "Jugador actual";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(226, 10);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(306, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 9;
            // 
            // labelTime1
            // 
            this.labelTime1.AutoSize = true;
            this.labelTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTime1.Location = new System.Drawing.Point(222, 36);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(27, 20);
            this.labelTime1.TabIndex = 8;
            this.labelTime1.Text = "10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelQuestionPlayer1);
            this.panel1.Controls.Add(this.buttonOption4Player1);
            this.panel1.Controls.Add(this.buttonOption3Player1);
            this.panel1.Controls.Add(this.buttonOption2Player1);
            this.panel1.Controls.Add(this.buttonOption1Player1);
            this.panel1.Location = new System.Drawing.Point(17, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 402);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "S";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Q";
            // 
            // labelQuestionPlayer1
            // 
            this.labelQuestionPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionPlayer1.Location = new System.Drawing.Point(17, 26);
            this.labelQuestionPlayer1.Name = "labelQuestionPlayer1";
            this.labelQuestionPlayer1.Size = new System.Drawing.Size(474, 137);
            this.labelQuestionPlayer1.TabIndex = 0;
            this.labelQuestionPlayer1.Text = "Texto por defecto";
            // 
            // buttonOption4Player1
            // 
            this.buttonOption4Player1.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption4Player1.Location = new System.Drawing.Point(262, 282);
            this.buttonOption4Player1.Name = "buttonOption4Player1";
            this.buttonOption4Player1.Size = new System.Drawing.Size(220, 52);
            this.buttonOption4Player1.TabIndex = 4;
            this.buttonOption4Player1.Text = "Psiquico";
            this.buttonOption4Player1.UseVisualStyleBackColor = true;
            // 
            // buttonOption3Player1
            // 
            this.buttonOption3Player1.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption3Player1.Location = new System.Drawing.Point(24, 282);
            this.buttonOption3Player1.Name = "buttonOption3Player1";
            this.buttonOption3Player1.Size = new System.Drawing.Size(205, 52);
            this.buttonOption3Player1.TabIndex = 3;
            this.buttonOption3Player1.Text = "aire";
            this.buttonOption3Player1.UseVisualStyleBackColor = true;
            // 
            // buttonOption2Player1
            // 
            this.buttonOption2Player1.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption2Player1.Location = new System.Drawing.Point(262, 183);
            this.buttonOption2Player1.Name = "buttonOption2Player1";
            this.buttonOption2Player1.Size = new System.Drawing.Size(217, 54);
            this.buttonOption2Player1.TabIndex = 2;
            this.buttonOption2Player1.Text = "fuego";
            this.buttonOption2Player1.UseVisualStyleBackColor = true;
            // 
            // buttonOption1Player1
            // 
            this.buttonOption1Player1.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption1Player1.Location = new System.Drawing.Point(24, 183);
            this.buttonOption1Player1.Name = "buttonOption1Player1";
            this.buttonOption1Player1.Size = new System.Drawing.Size(205, 54);
            this.buttonOption1Player1.TabIndex = 1;
            this.buttonOption1Player1.Text = "Agua";
            this.buttonOption1Player1.UseVisualStyleBackColor = true;
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.Controls.Add(this.labelCurrentlyQuestion2);
            this.panelPlayer2.Controls.Add(this.buttonSurrenderPlayer2);
            this.panelPlayer2.Controls.Add(this.label1);
            this.panelPlayer2.Controls.Add(this.labelPoints2);
            this.panelPlayer2.Controls.Add(this.labelPlayer2);
            this.panelPlayer2.Controls.Add(this.progressBar2);
            this.panelPlayer2.Controls.Add(this.labelTime2);
            this.panelPlayer2.Controls.Add(this.panel2);
            this.panelPlayer2.Location = new System.Drawing.Point(594, 12);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(616, 709);
            this.panelPlayer2.TabIndex = 1;
            // 
            // labelCurrentlyQuestion2
            // 
            this.labelCurrentlyQuestion2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCurrentlyQuestion2.AutoSize = true;
            this.labelCurrentlyQuestion2.Location = new System.Drawing.Point(460, 41);
            this.labelCurrentlyQuestion2.Name = "labelCurrentlyQuestion2";
            this.labelCurrentlyQuestion2.Size = new System.Drawing.Size(82, 13);
            this.labelCurrentlyQuestion2.TabIndex = 14;
            this.labelCurrentlyQuestion2.Text = "Pregunta actual";
            // 
            // buttonSurrenderPlayer2
            // 
            this.buttonSurrenderPlayer2.Location = new System.Drawing.Point(518, 669);
            this.buttonSurrenderPlayer2.Name = "buttonSurrenderPlayer2";
            this.buttonSurrenderPlayer2.Size = new System.Drawing.Size(75, 23);
            this.buttonSurrenderPlayer2.TabIndex = 13;
            this.buttonSurrenderPlayer2.Text = "Rendirse";
            this.buttonSurrenderPlayer2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pregunta actual";
            // 
            // labelPoints2
            // 
            this.labelPoints2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPoints2.AutoSize = true;
            this.labelPoints2.Location = new System.Drawing.Point(16, 36);
            this.labelPoints2.Name = "labelPoints2";
            this.labelPoints2.Size = new System.Drawing.Size(93, 13);
            this.labelPoints2.TabIndex = 11;
            this.labelPoints2.Text = "Puntuación actual";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Location = new System.Drawing.Point(16, 10);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(77, 13);
            this.labelPlayer2.TabIndex = 10;
            this.labelPlayer2.Text = "Jugador actual";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(264, 10);
            this.progressBar2.Maximum = 10;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(329, 23);
            this.progressBar2.Step = 1;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 9;
            // 
            // labelTime2
            // 
            this.labelTime2.AutoSize = true;
            this.labelTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTime2.Location = new System.Drawing.Point(260, 36);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(27, 20);
            this.labelTime2.TabIndex = 8;
            this.labelTime2.Text = "10";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelQuestionPlayer2);
            this.panel2.Controls.Add(this.buttonOption4Player2);
            this.panel2.Controls.Add(this.buttonOption3Player2);
            this.panel2.Controls.Add(this.buttonOption2Player2);
            this.panel2.Controls.Add(this.buttonOption1Player2);
            this.panel2.Location = new System.Drawing.Point(19, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 402);
            this.panel2.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "7";
            // 
            // labelQuestionPlayer2
            // 
            this.labelQuestionPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionPlayer2.Location = new System.Drawing.Point(15, 26);
            this.labelQuestionPlayer2.Name = "labelQuestionPlayer2";
            this.labelQuestionPlayer2.Size = new System.Drawing.Size(556, 137);
            this.labelQuestionPlayer2.TabIndex = 0;
            this.labelQuestionPlayer2.Text = "Texto por defecto";
            // 
            // buttonOption4Player2
            // 
            this.buttonOption4Player2.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption4Player2.Location = new System.Drawing.Point(307, 282);
            this.buttonOption4Player2.Name = "buttonOption4Player2";
            this.buttonOption4Player2.Size = new System.Drawing.Size(250, 52);
            this.buttonOption4Player2.TabIndex = 4;
            this.buttonOption4Player2.Text = "Psiquico";
            this.buttonOption4Player2.UseVisualStyleBackColor = true;
            // 
            // buttonOption3Player2
            // 
            this.buttonOption3Player2.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption3Player2.Location = new System.Drawing.Point(34, 282);
            this.buttonOption3Player2.Name = "buttonOption3Player2";
            this.buttonOption3Player2.Size = new System.Drawing.Size(205, 52);
            this.buttonOption3Player2.TabIndex = 3;
            this.buttonOption3Player2.Text = "aire";
            this.buttonOption3Player2.UseVisualStyleBackColor = true;
            // 
            // buttonOption2Player2
            // 
            this.buttonOption2Player2.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption2Player2.Location = new System.Drawing.Point(307, 183);
            this.buttonOption2Player2.Name = "buttonOption2Player2";
            this.buttonOption2Player2.Size = new System.Drawing.Size(250, 54);
            this.buttonOption2Player2.TabIndex = 2;
            this.buttonOption2Player2.Text = "fuego";
            this.buttonOption2Player2.UseVisualStyleBackColor = true;
            // 
            // buttonOption1Player2
            // 
            this.buttonOption1Player2.Font = new System.Drawing.Font("Arial", 15F);
            this.buttonOption1Player2.Location = new System.Drawing.Point(34, 183);
            this.buttonOption1Player2.Name = "buttonOption1Player2";
            this.buttonOption1Player2.Size = new System.Drawing.Size(205, 54);
            this.buttonOption1Player2.TabIndex = 1;
            this.buttonOption1Player2.Text = "Agua";
            this.buttonOption1Player2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormGameTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1228, 733);
            this.Controls.Add(this.panelPlayer1);
            this.Controls.Add(this.panelPlayer2);
            this.KeyPreview = true;
            this.Name = "FormGameTwoPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGameTwoPlayers_KeyDown);
            this.panelPlayer1.ResumeLayout(false);
            this.panelPlayer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPlayer2.ResumeLayout(false);
            this.panelPlayer2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Button buttonSurrenderPlayer1;
        private System.Windows.Forms.Label labelCurrentlyQuestion1;
        private System.Windows.Forms.Label labelPoints1;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelQuestionPlayer1;
        private System.Windows.Forms.Button buttonOption4Player1;
        private System.Windows.Forms.Button buttonOption3Player1;
        private System.Windows.Forms.Button buttonOption2Player1;
        private System.Windows.Forms.Button buttonOption1Player1;
        private System.Windows.Forms.Button buttonSurrenderPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPoints2;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelQuestionPlayer2;
        private System.Windows.Forms.Button buttonOption4Player2;
        private System.Windows.Forms.Button buttonOption3Player2;
        private System.Windows.Forms.Button buttonOption2Player2;
        private System.Windows.Forms.Button buttonOption1Player2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCurrentlyQuestion2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
    }
}