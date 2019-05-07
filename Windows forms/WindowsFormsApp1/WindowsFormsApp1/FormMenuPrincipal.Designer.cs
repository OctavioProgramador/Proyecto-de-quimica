namespace WindowsFormsApp1
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonInciairMode1 = new System.Windows.Forms.Button();
            this.buttonStartMode2 = new System.Windows.Forms.Button();
            this.buttonTabla = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.buttonInciairMode1);
            this.flowLayoutPanel1.Controls.Add(this.buttonStartMode2);
            this.flowLayoutPanel1.Controls.Add(this.buttonTabla);
            this.flowLayoutPanel1.Controls.Add(this.buttonSalir);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(188, 118);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(257, 276);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // buttonInciairMode1
            // 
            this.buttonInciairMode1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInciairMode1.BackgroundImage")));
            this.buttonInciairMode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonInciairMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInciairMode1.Location = new System.Drawing.Point(3, 3);
            this.buttonInciairMode1.Name = "buttonInciairMode1";
            this.buttonInciairMode1.Size = new System.Drawing.Size(251, 61);
            this.buttonInciairMode1.TabIndex = 0;
            this.buttonInciairMode1.UseVisualStyleBackColor = true;
            this.buttonInciairMode1.Click += new System.EventHandler(this.buttonInciair_Click);
            // 
            // buttonStartMode2
            // 
            this.buttonStartMode2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartMode2.BackgroundImage")));
            this.buttonStartMode2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartMode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartMode2.Location = new System.Drawing.Point(3, 70);
            this.buttonStartMode2.Name = "buttonStartMode2";
            this.buttonStartMode2.Size = new System.Drawing.Size(251, 61);
            this.buttonStartMode2.TabIndex = 3;
            this.buttonStartMode2.UseVisualStyleBackColor = true;
            this.buttonStartMode2.Click += new System.EventHandler(this.buttonStartMode2_Click);
            // 
            // buttonTabla
            // 
            this.buttonTabla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTabla.BackgroundImage")));
            this.buttonTabla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabla.Location = new System.Drawing.Point(3, 137);
            this.buttonTabla.Name = "buttonTabla";
            this.buttonTabla.Size = new System.Drawing.Size(251, 61);
            this.buttonTabla.TabIndex = 1;
            this.buttonTabla.UseVisualStyleBackColor = true;
            this.buttonTabla.Click += new System.EventHandler(this.buttonTabla_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSalir.BackgroundImage")));
            this.buttonSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Location = new System.Drawing.Point(3, 204);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(251, 61);
            this.buttonSalir.TabIndex = 2;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juego de química ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonInciairMode1;
        private System.Windows.Forms.Button buttonTabla;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartMode2;
    }
}