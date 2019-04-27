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
    public partial class FormName : Form
    {
        public FormName()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text).Length != 0)
            {
                this.Close();
                FormGame formGame = new FormGame(textBoxName.Text);
                formGame.Show();
            }
        }
    }
}
